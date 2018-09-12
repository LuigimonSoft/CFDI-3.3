using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;
namespace FacturaElectronica.CFDI33.Complementos
{
    /// <summary>
    /// Elemento requerido para incorporar la información de la recepción de pagos.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPago : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PagosPagoDoctoRelacionado> _doctoRelacionado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PagosPagoImpuestos> _impuestos;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_FormaPago _formaDePagoP;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Moneda _monedaP;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tipoCambioP;
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _stipoCambioP;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _monto;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numOperacion;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rfcEmisorCtaOrd;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _nomBancoOrdExt;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _ctaOrdenante;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rfcEmisorCtaBen;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _ctaBeneficiario;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TipoCadenaPago _tipoCadPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private byte[] _certPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _cadPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private byte[] _selloPago;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Nodo condicional para expresar la lista de documentos relacionados con los pagos diferentes de anticipos. Por cada documento que se relacione se debe generar un nodo DoctoRelacionado.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DoctoRelacionado", Order = 0)]
        public List<PagosPagoDoctoRelacionado> DoctoRelacionado
        {
            get
            {
                return this._doctoRelacionado;
            }
            set
            {
                if ((this._doctoRelacionado == value))
                {
                    return;
                }
                if (((this._doctoRelacionado == null)
                     || (_doctoRelacionado.Equals(value) != true)))
                {
                    this._doctoRelacionado = value;
                    this.OnPropertyChanged("DoctoRelacionado");
                }
            }
        }

        /// <summary>
        /// Nodo condicional para expresar el resumen de los impuestos aplicables cuando este documento sea un anticipo.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Impuestos", Order = 1)]
        public List<PagosPagoImpuestos> Impuestos
        {
            get
            {
                return this._impuestos;
            }
            set
            {
                if ((this._impuestos == value))
                {
                    return;
                }
                if (((this._impuestos == null)
                     || (_impuestos.Equals(value) != true)))
                {
                    this._impuestos = value;
                    this.OnPropertyChanged("Impuestos");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "FechaPago")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])T(([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9])")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String sFechaPago
        {
            get
            {
                return FechaPago.ToString("yyyy-MM-ddThh:mm:ss");
            }
            set
            {

                if ((FechaPago.ToString("yyyy-MM-ddThh:mm:ss").Equals(value) != true))
                {
                    FechaPago = System.Convert.ToDateTime(value);
                    this.OnPropertyChanged("FechaPago");
                }
            }
        }
        /// <summary>
        /// Atributo requerido para expresar la clave de la forma en que se realiza el pago.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_FormaPago FormaDePagoP
        {
            get
            {
                return this._formaDePagoP;
            }
            set
            {
                if ((_formaDePagoP.Equals(value) != true))
                {
                    this._formaDePagoP = value;
                    this.OnPropertyChanged("FormaDePagoP");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada para realizar el pago, cuando se usa moneda nacional se registra MXN. El atributo Pagos:Pago:Monto y los atributos TotalImpuestosRetenidos, TotalImpuestosTrasladados, Traslados:Traslado:Importe y Retenciones:Retencion:Importe del nodo Pago:Impuestos deben ser expresados en esta moneda. Conforme con la especificación ISO 4217.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Moneda MonedaP
        {
            get
            {
                return this._monedaP;
            }
            set
            {
                if ((_monedaP.Equals(value) != true))
                {
                    this._monedaP = value;
                    this.OnPropertyChanged("MonedaP");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el tipo de cambio de la moneda a la fecha en que se realizó el pago. El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo MonedaP. Es requerido cuando el atributo MonedaP es diferente a MXN.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "TipoCambioP")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string stipoCambioP
        {
            get
            {
                if (TipoCambioP == 0)
                    return null;
                else
                    return _stipoCambioP;
            }

            set
            {
                TipoCambioP = System.Convert.ToDecimal(value);

            }

        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stipoCambioSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para representar el tipo de cambio conforme con la moneda usada. Es requerido cuando la clave de moneda es distinta de MXN y de XXX. El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo moneda. Si el valor está fuera del porcentaje aplicable a la moneda tomado del catálogo c_Moneda, el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para ratificar que el valor es correcto e integrar dicha clave en el atributo Confirmacion.
        /// </summary>
        [XmlIgnore]
        public decimal TipoCambioP
        {
            get
            {
                return this._tipoCambioP;
            }
            set
            {
                if (value < System.Convert.ToDecimal(0.000001))
                    throw new ArgumentException("El valor minimo permitido es 0.000001 ");
                String[] partes = value.ToString().Split('.');
                if (partes.Length > 1)
                {
                    int Parte1 = System.Convert.ToInt32(partes[0]);
                    decimal valorprueba = (value - Parte1);
                    if (valorprueba < System.Convert.ToDecimal(0.000001) && valorprueba != 0)
                        throw new ArgumentException("El numero de decimales maximo es de 6");
                }
                stipoCambioSpecified = true;
                if ((_tipoCambioP.Equals(value) != true))
                {
                    this._tipoCambioP = value;
                    _stipoCambioP = partes[0];
                    if (partes.Length > 1)
                    {
                        if (partes[1].Length > 6)
                            _stipoCambioP += "." + partes[1].Substring(0, 6);
                        else
                            _stipoCambioP += "." + partes[1];
                    }
                    else
                        _stipoCambioP += ".000000";

                    if (value == 1)
                        _stipoCambioP = "1";

                    this.OnPropertyChanged("TipoCambio");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioPSpecified { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "Monto")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strMonto
        {
            get
            {
                return Monto.strImporte;
            }
            set
            {
                if (Monto == null)
                    Monto = new t_Importe("0.000001");

                if ((Monto.strImporte.Equals(value) != true))
                {
                    this.Monto.strImporte = value;
                    this.OnPropertyChanged("Monto");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de cheque, número de autorización, número de referencia, clave de rastreo en caso de ser SPEI, línea de captura o algún número de referencia análogo que identifique la operación que ampara el pago efectuado
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(100, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,100}")]
        public string NumOperacion
        {
            get
            {
                return this._numOperacion;
            }
            set
            {
                if ((this._numOperacion == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 100, "NumOperacion", value, out Error))
                    throw new Exception(Error);

                if (((this._numOperacion == null) || (_numOperacion.Equals(value) != true)))
                {
                    this._numOperacion = value;
                    this.OnPropertyChanged("NumOperacion");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumOperacionSpecified { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "RfcEmisorCtaOrd")]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(13, MinimumLength = 12)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("XEXX010101000|[A-Z&Ñ]{3}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]")]
        public string sRfcEmisorCtaOrd
        {
            get
            {
                return RfcEmisorCtaOrd.Rfc;
            }
            set
            {
                if (RfcEmisorCtaOrd == null)
                    RfcEmisorCtaOrd = new t_RFC(value);

                if ((RfcEmisorCtaOrd.Rfc == value))
                {
                    return;
                }
                sRfcEmisorCtaOrdSpecified = true;
                if (((RfcEmisorCtaOrd.Rfc == null) || (RfcEmisorCtaOrd.Rfc.Equals(value) != true)))
                {
                    RfcEmisorCtaOrd.Rfc = value;
                    this.OnPropertyChanged("RfcEmisorCtaOrd");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sRfcEmisorCtaOrdSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para expresar el nombre del banco ordenante, es requerido en caso de ser extranjero. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(300, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,300}")]
        public string NomBancoOrdExt
        {
            get
            {
                return this._nomBancoOrdExt;
            }
            set
            {
                if ((this._nomBancoOrdExt == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 300, "NomBancoOrdExt", value, out Error))
                    throw new Exception(Error);
                if (((this._nomBancoOrdExt == null)
                     || (_nomBancoOrdExt.Equals(value) != true)))
                {
                    this._nomBancoOrdExt = value;
                    this.OnPropertyChanged("NomBancoOrdExt");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NomBancoOrdExtSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para incorporar el número de la cuenta con la que se realizó el pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(50, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z0-9_]{10,50}")]
        public string CtaOrdenante
        {
            get
            {
                return this._ctaOrdenante;
            }
            set
            {
                if ((this._ctaOrdenante == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(10, 50, "CtaOrdenante", value, out Error))
                    throw new Exception(Error);
                if (((this._ctaOrdenante == null)
                     || (_ctaOrdenante.Equals(value) != true)))
                {
                    this._ctaOrdenante = value;
                    this.OnPropertyChanged("CtaOrdenante");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtaOrdenanteSpecified { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName= "RfcEmisorCtaBen")]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(12, MinimumLength = 12)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z&amp;Ñ]{3}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]")]
        public string sRfcEmisorCtaBen
        {
            get
            {
                return RfcEmisorCtaBen.Rfc;
            }
            set
            {
                if (RfcEmisorCtaBen == null)
                    RfcEmisorCtaBen = new t_RFC_PM(value);

                if ((RfcEmisorCtaBen.Rfc == value))
                {
                    return;
                }
                sRfcEmisorCtaBenSpecified = true;
                if (((RfcEmisorCtaBen.Rfc == null) || (RfcEmisorCtaBen.Rfc.Equals(value) != true)))
                {
                    RfcEmisorCtaBen.Rfc = value;
                    this.OnPropertyChanged("RfcEmisorCtaBen");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sRfcEmisorCtaBenSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para incorporar el número de cuenta en donde se recibió el pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(50, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z0-9_]{10,50}")]
        public string CtaBeneficiario
        {
            get
            {
                return this._ctaBeneficiario;
            }
            set
            {
                if ((this._ctaBeneficiario == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(10, 50, "CtaBeneficiario", value, out Error))
                    throw new Exception(Error);
                CtaBeneficiarioSpecified = true;
                if (((this._ctaBeneficiario == null) || (_ctaBeneficiario.Equals(value) != true)))
                {
                    this._ctaBeneficiario = value;
                    this.OnPropertyChanged("CtaBeneficiario");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtaBeneficiarioSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para identificar la clave del tipo de cadena de pago que genera la entidad receptora del pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoCadenaPago TipoCadPago
        {
            get
            {
                return this._tipoCadPago;
            }
            set
            {
                if ((_tipoCadPago.Equals(value) != true))
                {
                    this._tipoCadPago = value;
                    this.OnPropertyChanged("TipoCadPago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCadPagoSpecified { get; set; }

        /// <summary>
        /// Atributo condicional que sirve para incorporar el certificado que ampara al pago, como una cadena de texto en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] CertPago
        {
            get
            {
                return this._certPago;
            }
            set
            {
                if ((this._certPago == value))
                {
                    return;
                }
                CertPagoSpecified = true;
                if (((this._certPago == null) || (_certPago.Equals(value) != true)))
                {
                    this._certPago = value;
                    this.OnPropertyChanged("CertPago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CertPagoSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para expresar la cadena original del comprobante de pago generado por la entidad emisora de la cuenta beneficiaria. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(8192, MinimumLength = 1)]
        public string CadPago
        {
            get
            {
                return this._cadPago;
            }
            set
            {
                if ((this._cadPago == value))
                {
                    return;
                }
                CadPagoSpecified = true;
                if (((this._cadPago == null) || (_cadPago.Equals(value) != true)))
                {
                    this._cadPago = value;
                    this.OnPropertyChanged("CadPago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CadPagoSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para integrar el sello digital que se asocie al pago. La entidad que emite el comprobante de pago, ingresa una cadena original y el sello digital en una sección de dicho comprobante, este sello digital es el que se debe registrar en este campo. Debe ser expresado como una cadena de texto en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] SelloPago
        {
            get
            {
                return this._selloPago;
            }
            set
            {
                if ((this._selloPago == value))
                {
                    return;
                }
                SelloPagoSpecified = true;
                if (((this._selloPago == null) || (_selloPago.Equals(value) != true)))
                {
                    this._selloPago = value;
                    this.OnPropertyChanged("SelloPago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelloPagoSpecified { get; set; }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PagosPago));
                }
                return serializer;
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PagosPago object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream, encoding);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        public virtual string Serialize()
        {
            return Serialize(System.Text.Encoding.UTF8);
        }

        /// <summary>
        /// Deserializes workflow markup into an PagosPago object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PagosPago object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PagosPago obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPago);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string input, out PagosPago obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static PagosPago Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PagosPago)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static PagosPago Deserialize(System.IO.Stream s)
        {
            return ((PagosPago)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current PagosPago object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
        }

        public virtual void SaveToFile(string fileName)
        {
            SaveToFile(fileName, System.Text.Encoding.UTF8);
        }

        public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize(encoding);
                streamWriter = new System.IO.StreamWriter(fileName, false, encoding);
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an PagosPago object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PagosPago object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PagosPago obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPago);
            try
            {
                obj = LoadFromFile(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out PagosPago obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out PagosPago obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PagosPago LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static PagosPago LoadFromFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file, encoding);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
}
