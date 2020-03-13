using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace FacturaElectronica.CFDI33
{
    public partial class Comprobante
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        private Certificado _Contenidocertificado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private String _cadenaoriginal = String.Empty;

        [XmlIgnore]
        public String PosicionEsquema { set; get; }
        private void init()
        {
            this._conceptos = new List<ComprobanteConcepto>();
            this._receptor = new ComprobanteReceptor();
            this._emisor = new ComprobanteEmisor();
            this._version = "3.3";
            this._moneda = c_Moneda.MXN;
            Total = new t_Importe(0);
            SubTotal = new t_Importe(0);
            Emisor = new CFDI33.ComprobanteEmisor();
            Receptor = new ComprobanteReceptor();
            PosicionEsquema = System.Windows.Forms.Application.StartupPath+ "\\CFDI33";
        }

        /// <summary>
        /// Atributo requerido para representar la suma de los importes de los conceptos antes de descuentos e impuesto. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe SubTotal { set; get; }

        /// <summary>
        /// Atributo condicional para representar el importe total de los descuentos aplicables antes de impuestos. No se permiten valores negativos. Se debe registrar cuando existan conceptos con descuento.
        /// </summary>
        [XmlIgnore]
        public t_Importe Descuento {
            set
            {
                _descuento = value;
                strDescuentoSpecified = true;
            }
            get { return _descuento; }
        }

        /// <summary>
        /// Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, más las contribuciones recibidas (impuestos trasladados - federales o locales, derechos, productos, aprovechamientos, aportaciones de seguridad social, contribuciones de mejoras) menos los impuestos retenidos. Si el valor es superior al límite que establezca el SAT en la Resolución Miscelánea Fiscal vigente, el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para ratificar que el valor es correcto e integrar dicha clave en el atributo Confirmacion. No se permiten valores negativos.
        /// </summary>
        [XmlIgnore]
        public t_Importe Total { set; get; }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha y hora de expedición del Comprobante Fiscal Digital por Internet. Se expresa en la forma AAAA-MM-DDThh:mm:ss y debe corresponder con la hora local donde se expide el comprobante.
        /// </summary>
        [XmlIgnore]
        public System.DateTime Fecha { set; get; }

        [XmlIgnore]
        public Certificado ContenidoCertificado
        {
            set
            {
                _Contenidocertificado = value;
                Certificado = value.CertificadoBase64;
                NoCertificado = value.NumeroSerie;
                this.Emisor.Rfc = new t_RFC(value.RFCCertificado);
            }
            get
            {
                return _Contenidocertificado;
            }
        }

        [XmlIgnore]
        public String CadenaOriginal
        {
            get { return _cadenaoriginal; }
        }

        [XmlIgnore]
        public Complementos.TimbreFiscalDigital TimbreFiscalDigital { set; get; }

        [XmlIgnore]
        public Complementos.Pagos Pagos { set; get; }

        [XmlIgnore]
        public Complementos.ImpuestosLocales ImpuestosLocales { set; get; }

        [XmlIgnore]
        public Complementos.Nomina12.Nomina Nomina { set; get; }

        public Comprobante( Certificado certificado)
        {
            init();
            ContenidoCertificado = certificado;
            _Contenidocertificado = certificado;


        }

        public static Comprobante CargarCFDI(String Archivo,out List<String> Errores,bool Local=false)
        {
            List<String> Esquemas = new List<String>();
            Errores = new List<String>();

            //---------- Cargar esquemas a validar
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\cfdv33.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\tdCFDI.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\catCFDI.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\TimbreFiscalDigitalv11.xsd");
            //----

            

            if (System.IO.File.Exists(Archivo))
            {
                String XML = String.Empty;
                try
                {
                    XML = System.IO.File.ReadAllText(Archivo, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    Errores.Add(ex.Message);
                    return null;

                }

                String XMLTimbre = String.Empty;
                bool ContieneTimbre = RemoverTimbre(XML, out XMLTimbre, out XML);

                if (EsCFDIXmlValido(Esquemas, new StringReader(RemoverAddenda(XML).Replace("\r", "").Replace("\n", "")), out Errores))
                {
                    Comprobante Comp = LoadFromFile(Archivo, Encoding.UTF8);
                    if (Comp.GenerarCadenaOriginalCFDI(XML, out Errores, Local))
                    {
                        if (ContieneTimbre)
                        {
                            

                            Comp.TimbreFiscalDigital = Complementos.TimbreFiscalDigital.Deserialize(XMLTimbre);
                            Comp.TimbreFiscalDigital.GenerarQR(Comp.Emisor.Rfc.Rfc, Comp.Receptor.Rfc.Rfc, Comp.strTotal);
                        }
                        return Comp;
                    }
                    else
                        return null;

                }
                else
                {
                    return null;
                }
            }
            else
            {
                Errores.Add("No se encuentra el archivo");
                return null;
            }

        }

        public static Comprobante CargarXMLCFDI(String XML, out List<String> Errores,bool  Local=false)
        {
            List<String> Esquemas = new List<String>();
            Errores = new List<String>();

            //---------- Cargar esquemas a validar
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\cfdv33.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\tdCFDI.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\catCFDI.xsd");
            Esquemas.Add(System.Windows.Forms.Application.StartupPath + "\\CFDI33\\TimbreFiscalDigitalv11.xsd");
            //----

            String XMLTimbre=String.Empty;
            String XMLNomina = string.Empty;

            bool ContieneTimbre = RemoverTimbre(XML, out XMLTimbre, out XML);
            bool ContieneNomina = RemoverNomina(XML, out XMLNomina, out XML);
            
            if (EsCFDIXmlValido(Esquemas, new StringReader(RemoverAddenda(XML).Replace("\r", "").Replace("\n", "")), out Errores))
            {
                Comprobante Comp = Deserialize(XML);
                if (Comp.GenerarCadenaOriginalCFDI(XML, out Errores, Local))
                {
                    if (ContieneTimbre)
                    {
                        Comp.TimbreFiscalDigital = Complementos.TimbreFiscalDigital.Deserialize(XMLTimbre);
                        Comp.TimbreFiscalDigital.GenerarQR(Comp.Emisor.Rfc.Rfc, Comp.Receptor.Rfc.Rfc, Comp.strTotal);
                    }
                    if(ContieneNomina)
                    {
                        Comp.Nomina = Complementos.Nomina12.Nomina.Deserialize(XMLNomina);
                    }

                    return Comp;
                }
                else
                    return null;
                /*if (ContieneTimbre)
                {
                    Comp.TimbreFiscalDigital=Complementos.TimbreFiscalDigital.Deserialize(XMLTimbre);
                    Comp.TimbreFiscalDigital.GenerarQR(Comp.Emisor.Rfc.Rfc, Comp.Receptor.Rfc.Rfc, Comp.strTotal);
                }*/

            }
            else
            {
                return null;
            }

        }

        public bool GenerarXML(out String XML, out String Errores)
        {
            XML = String.Empty;
            Errores = String.Empty;
            bool Resultado = false;

            try
            {
                if (Pagos != null)
                {
                    XmlDocument doc = new XmlDocument();
                    String XMLPago = String.Empty;
                    String ErroresPago = String.Empty;
                    if (Pagos.GenerarXML(out XMLPago, out ErroresPago))
                    {
                        doc.LoadXml(XMLPago);
                        ComprobanteComplemento ComPago = new ComprobanteComplemento();
                        ComPago.Any.Add(doc.DocumentElement);
                        if (Complemento == null)
                            Complemento = new List<ComprobanteComplemento>();
                        Complemento.Add(ComPago);
                    }
                    else
                        Errores += ErroresPago;
                }

                if (ImpuestosLocales != null)
                {
                    XmlDocument doc = new XmlDocument();
                    String XMLImpLoc = String.Empty;
                    String ErroresImpLoc = String.Empty;
                    if (ImpuestosLocales.GenerarXML(out XMLImpLoc, out ErroresImpLoc))
                    {
                        doc.LoadXml(XMLImpLoc);
                        ComprobanteComplemento ComImpLoc = new ComprobanteComplemento();
                        ComImpLoc.Any.Add(doc.DocumentElement);
                        if (Complemento == null)
                            Complemento = new List<ComprobanteComplemento>();
                        Complemento.Add(ComImpLoc);
                    }
                    else
                        Errores += ErroresImpLoc;
                }

                if(Nomina!=null)
                {
                    schemaLocation +=" http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd";
                    XmlDocument doc = new XmlDocument();
                    String XMLNomina = String.Empty;
                    String ErroresNomina = String.Empty;
                    if (Nomina.GenerarXML(out XMLNomina, out ErroresNomina))
                    {
                        doc.LoadXml(XMLNomina);
                        ComprobanteComplemento ComNomina = new ComprobanteComplemento();
                        ComNomina.Any.Add(doc.DocumentElement);
                        if (Complemento == null)
                            Complemento = new List<ComprobanteComplemento>();
                        Complemento.Add(ComNomina);
                    }
                    else
                        Errores += ErroresNomina;
                }

                
                if (String.IsNullOrEmpty(Errores))
                {
                    XML = Serialize(System.Text.Encoding.UTF8);
                    XML = XML.Replace("&amp;apos;", "&apos;").Replace("&amp;quot;", "&quot;").Replace("&amp;lt;", "&lt;").Replace("&amp;gt;", "&gt;").Replace("&amp;amp;", "&amp;");
                    return (!String.IsNullOrEmpty(XML));
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                if(ex.InnerException!=null)
                    Errores += ex.Message+" innerex: "+ex.InnerException.Message;
                else
                    Errores += ex.Message;
            }
           

            return Resultado;
        }

        private  Boolean GenerarCadenaOriginalCFDI( String XML,  out List<String> Errores,bool Local=false)
        {
            Boolean Resultado = false;
            _cadenaoriginal = String.Empty;
            Errores = new List<string>();
            try
            {
                String ArchivoXSLT = (Local? "\\cadenaoriginal_3_3Local.xslt" : "\\cadenaoriginal_3_3.xslt");
                
                if (System.IO.File.Exists(PosicionEsquema + ArchivoXSLT))
                {
                    System.IO.StringReader XmlSR = new System.IO.StringReader(XML);
                    System.Xml.XPath.XPathDocument DocXml = new System.Xml.XPath.XPathDocument(XmlSR);
                    System.Xml.Xsl.XslTransform elXSLt = new System.Xml.Xsl.XslTransform();
                    
                    elXSLt.Load(PosicionEsquema + ArchivoXSLT);
                    System.IO.Stream str = new System.IO.MemoryStream();
                    elXSLt.Transform(DocXml, null, str);
                    str.Position = 0;
                    System.IO.StreamReader reader = new System.IO.StreamReader(str);
                    _cadenaoriginal = reader.ReadToEnd();
                    Resultado = true;
                    reader.Close();
                }
                else
                {
                    //cErrores ErrT = new cErrores(1061);
                    Errores.Add("No se encontro el archivo "+ PosicionEsquema + ArchivoXSLT);

                }
            }
            catch (Exception e)
            {
                Errores.Add(e.Message);
            }

            return Resultado;
        }


        public Boolean GenerarPreCFDI(out String CFDI, out List<String> Errores, bool Local = false)
        {
            Boolean Resultado = false;
            CFDI = String.Empty;
            Errores= new List<string>();

            if (ContenidoCertificado != null)
            {
                String XML = String.Empty;
                String error = String.Empty;
                Sello = "#SELLO#";
                decimal TotalTrasladosConceptos = 0;
                Conceptos.ForEach(Concepto=>
                {
                    if (Concepto.Impuestos != null)
                    {
                        if (Concepto.Impuestos.Traslados != null)
                            Concepto.Impuestos.Traslados.ForEach(X=> TotalTrasladosConceptos+= X.Importe.Valor);
                    }
                });

                if(TotalTrasladosConceptos!=Impuestos.TotalImpuestosTrasladados.Valor)
                    Errores.Add("El total de impuestos trasladados no coincide con la suma de los impuestos por concepto trasladado");

                decimal TotalRetencionesConceptos = 0;
                Conceptos.ForEach(Concepto =>
                {
                    if (Concepto.Impuestos != null)
                    {
                        if (Concepto.Impuestos.Retenciones != null)
                            Concepto.Impuestos.Retenciones.ForEach(X => TotalRetencionesConceptos += X.Importe.Valor);
                    }
                });

                if(Impuestos.TotalImpuestosRetenidos!=null)
                {
                    if (TotalRetencionesConceptos != Impuestos.TotalImpuestosRetenidos.Valor)
                    Errores.Add("El total de impuestos retenidos no coincide con la suma de los impuestos por concepto retenidos");
                }
                

                if (GenerarXML(out XML, out error))
                {
                    if (GenerarCadenaOriginalCFDI( XML, out Errores,Local))
                    {
                        
                        Sellador sellador = new Sellador(_Contenidocertificado);
                        if (sellador.SellarXML(CadenaOriginal, out _sello, out Errores))
                        {
                            Sello = _sello;
                            CFDI = XML.Replace("#SELLO#", _sello);
                            return true;
                        }

                    }
                    else
                        Errores.Add("Error al generar la cadena original Error: " + error);
                }
                else 
                    Errores.Add("Error al generar el XML Error: "+error);
            }
            else 
                Errores.Add("Se debe de agregar un certificado para poder sellar el comprobante");

            return Resultado;
        }


        public static bool VerificarLongitud(int minimo, int maximo, string campo,string contenido, out string error)
        {
            Boolean resultado = true;
            error = String.Empty;

            if (contenido.Length > maximo || contenido.Length < minimo)
            {
                resultado = false;
                error = "El campo " + campo + " debe tener entre " + minimo.ToString() + " y " + maximo.ToString()+ " caracteres";
            }

            return resultado;
        }

        #region Verificar XML de entrada
        private static System.Xml.XmlTextReader Reader = null;
        private static bool _IsValid = false;
        private static List<string> Resultado;

        private static bool EsCFDIXmlValido(List<String> PathsXSD, System.IO.StringReader XMLPath, out List<string> Errores)
        {

            try
            {
                // 0- Initialize variables...
                _IsValid = true;
                Resultado = new List<string>();


                // 1- Read XML file content
                Reader = new System.Xml.XmlTextReader(XMLPath);

                // 3- Create a new instance of XmlSchema object
                System.Xml.Schema.XmlSchema Schema = new System.Xml.Schema.XmlSchema();
                System.Xml.XmlReaderSettings ReaderSettings = new System.Xml.XmlReaderSettings();

                // 2- Read Schema file content
                foreach (String XSD in PathsXSD)
                {
                    StreamReader SR = new StreamReader(XSD);
                    Schema = System.Xml.Schema.XmlSchema.Read(SR, new System.Xml.Schema.ValidationEventHandler(ReaderSettings_ValidationEventHandler));
                    ReaderSettings.ValidationType = System.Xml.ValidationType.Schema;
                    ReaderSettings.Schemas.Add(Schema);
                }
                // 8- Add your ValidationEventHandler address to
                // XmlReaderSettings ValidationEventHandler
                ReaderSettings.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(ReaderSettings_ValidationEventHandler);

                // 9- Create a new instance of XmlReader object
                System.Xml.XmlReader objXmlReader = System.Xml.XmlReader.Create(Reader, ReaderSettings);

                // 10- Read XML content in a loop
                while (objXmlReader.Read())
                {
                    // empty loop
                }

                // Se cierra el validador
                objXmlReader.Close();
                Errores = Resultado;
                return _IsValid;
            }
            catch (Exception ex)
            {
                Errores = new List<string>();
                Errores.Add("Error de validacion del XML Error:"+ex.ToString());
                return true;
            }

        }

        private static void ReaderSettings_ValidationEventHandler(Object Sender, System.Xml.Schema.ValidationEventArgs args)
        {
            // 11- Implement your logic for each validation iteration
            string strTemp = "Linea: " + Reader.LineNumber + " - Posición: " + Reader.LinePosition + " - " + args.Message;
            Resultado.Add(strTemp);
            _IsValid = false;
        }

        public Boolean ValidaSelloDigital(string selloDigital, string cert, string cadena, out Boolean MD5, out Boolean SHA256, out String Error)
        {
            Boolean Resultado = false;
            MD5 = false;
            SHA256 = false;
            Error = null;
            try
            {
                Byte[] sello_byte = Convert.FromBase64String(selloDigital);
                Byte[] cert_byte = Convert.FromBase64String(cert);
                System.Security.Cryptography.X509Certificates.X509Certificate2 certificado = new System.Security.Cryptography.X509Certificates.X509Certificate2(cert_byte);
                String spk = certificado.PublicKey.Key.ToXmlString(false);
                System.Security.Cryptography.AsymmetricAlgorithm pk = System.Security.Cryptography.AsymmetricAlgorithm.Create();
                pk.FromXmlString(spk);
                System.Security.Cryptography.RSACryptoServiceProvider rsa = (System.Security.Cryptography.RSACryptoServiceProvider)pk;
                rsa.PersistKeyInCsp = false;
                Byte[] cadena_byte = System.Text.Encoding.UTF8.GetBytes(cadena);
                System.Security.Cryptography.SHA256CryptoServiceProvider x = new System.Security.Cryptography.SHA256CryptoServiceProvider();
                Byte[] data = x.ComputeHash(cadena_byte);
                System.Security.Cryptography.MD5CryptoServiceProvider x2 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                Byte[] data2 = x2.ComputeHash(cadena_byte);
                MD5 = rsa.VerifyHash(data2, System.Security.Cryptography.CryptoConfig.MapNameToOID("MD5"), sello_byte);
                SHA256 = rsa.VerifyHash(data, System.Security.Cryptography.CryptoConfig.MapNameToOID("SHA256"), sello_byte);
                //if (MD5 || SHA1)
                Resultado = true;

            }
            catch (Exception ex)
            {
                Error = "Error al desencriptar el sello digital Error:" + ex.Message;
            }
            return Resultado;
        }

        private static String RemoverAddenda(String XML)
        {
            String Addenda = String.Empty;
            String Resultado = String.Empty;
            Resultado = XML;
            if (XML.IndexOf("<cfdi:Addenda/>") != -1 || XML.IndexOf("<cfdi:Addenda />") != -1)
                Resultado = XML.Replace("<cfdi:Addenda/>", "").Replace("<cfdi:Addenda />", "");
            else
            {
                if (XML.IndexOf("<cfdi:Addenda") != -1)
                {
                    int pos = XML.IndexOf("<cfdi:Addenda");
                    int posF = XML.IndexOf("</cfdi:Addenda>") + ("</cfdi:Addenda>").Length;
                    Addenda = XML.Substring(pos, posF - pos);
                }
                if (XML.IndexOf("<Addenda") != -1)
                {
                    int pos = XML.IndexOf("<Addenda");
                    int posF = XML.IndexOf("</Addenda>") + ("</Addenda>").Length;
                    Addenda = XML.Substring(pos, posF - pos);
                }
                if (!String.IsNullOrEmpty(Addenda))
                {
                    Resultado = XML.Replace(Addenda, "");
                }
            }

            return Resultado;
        }

        private static bool RemoverTimbre(String XML,out String XMLTimbre,out String XMLSinTimbre)
        {
            bool Resultado = false;
            XMLSinTimbre = String.Empty;
            XMLTimbre = String.Empty;
            XMLSinTimbre = XML;
            if (XML.Contains("<tfd:TimbreFiscalDigital"))
            {
                Resultado = true;
                int inicio = XML.IndexOf("<tfd:TimbreFiscalDigital");
                int fin = XML.IndexOf("/>",inicio);
                if (fin == -1)
                    fin = XML.IndexOf("</tfd:TimbreFiscalDigital>")+ "</tfd:TimbreFiscalDigital>".Length;
                else
                    fin += ("/>").Length;

                XMLTimbre = XML.Substring(inicio, fin-inicio);
                XMLSinTimbre = XML.Replace(XMLTimbre, "");
            }
            return Resultado;
        }

        private static bool RemoverNomina(String XML, out String XMLNomina, out String XMLSinNomina)
        {
            bool Resultado = false;
            XMLSinNomina = String.Empty;
            XMLNomina = String.Empty;
            XMLSinNomina = XML;
            if (XML.Contains("<nomina12:Nomina"))
            {
                Resultado = true;
                int inicio = XML.IndexOf("<nomina12:Nomina");
                int fin = XML.IndexOf(">", inicio);
                //if (fin == -1)
                    fin = XML.IndexOf("</nomina12:Nomina>") + "</nomina12:Nomina>".Length;
                /*else
                    fin += ("/>").Length;*/

                XMLNomina = XML.Substring(inicio, fin - inicio);
                XMLSinNomina = XML.Replace(XMLNomina, "");
            }
            else if(XML.Contains("<Nomina"))
            {
                Resultado = true;
                int inicio = XML.IndexOf("<Nomina");
                int fin = XML.IndexOf(">", inicio);
                //if (fin == -1)
                fin = XML.IndexOf("</Nomina>") + "</Nomina>".Length;
                /*else
                    fin += ("/>").Length;*/

                XMLNomina = XML.Substring(inicio, fin - inicio);
                XMLSinNomina = XML.Replace(XMLNomina, "");
            }
            return Resultado;
        }


        #endregion
    }
}
