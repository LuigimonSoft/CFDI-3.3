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

namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    

    /// <summary>
    /// Complemento para incorporar al Comprobante Fiscal Digital por Internet (CFDI) la información que ampara conceptos de ingresos por salarios, la prestación de un servicio personal subordinado o conceptos asimilados a salarios (Nómina).
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    /*[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Nomina12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/Nomina12", IsNullable = false)]*/
    public partial class Nomina : System.ComponentModel.INotifyPropertyChanged
    {
        /*[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd";*/


        #region Propiedades Privadas
        [EditorBrowsable(EditorBrowsableState.Never)]
        private NominaEmisor _emisor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private NominaReceptor _receptor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private NominaPercepciones _percepciones;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private NominaDeducciones _deducciones;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<NominaOtroPago> _otrosPagos;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<NominaIncapacidad> _incapacidades;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TipoNomina _tipoNomina;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaInicialPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaFinalPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _numDiasPagados;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totalPercepciones;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totalDeducciones;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totalOtrosPagos;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Nomina class constructor
        /// </summary>
        public Nomina()
        {
            this._receptor = new NominaReceptor();
            this._version = "1.2";
            init();
        }

        /// <summary>
        /// Nodo condicional para expresar la información del contribuyente emisor del comprobante de nómina.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public NominaEmisor Emisor
        {
            get
            {
                return this._emisor;
            }
            set
            {
                if ((this._emisor == value))
                {
                    return;
                }
                if (((this._emisor == null)
                            || (_emisor.Equals(value) != true)))
                {
                    this._emisor = value;
                    this.OnPropertyChanged("Emisor");
                }
            }
        }

        /// <summary>
        /// Nodo requerido para precisar la información del contribuyente receptor del comprobante de nómina.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public NominaReceptor Receptor
        {
            get
            {
                return this._receptor;
            }
            set
            {
                if ((this._receptor == value))
                {
                    return;
                }
                if (((this._receptor == null)
                            || (_receptor.Equals(value) != true)))
                {
                    this._receptor = value;
                    this.OnPropertyChanged("Receptor");
                }
            }
        }

        /// <summary>
        /// Nodo condicional para expresar las percepciones aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public NominaPercepciones Percepciones
        {
            get
            {
                return this._percepciones;
            }
            set
            {
                if ((this._percepciones == value))
                {
                    return;
                }
                if (((this._percepciones == null)
                            || (_percepciones.Equals(value) != true)))
                {
                    this._percepciones = value;
                    this.OnPropertyChanged("Percepciones");
                }
            }
        }

        /// <summary>
        /// Nodo opcional para expresar las deducciones aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public NominaDeducciones Deducciones
        {
            get
            {
                return this._deducciones;
            }
            set
            {
                if ((this._deducciones == value))
                {
                    return;
                }
                if (((this._deducciones == null)
                            || (_deducciones.Equals(value) != true)))
                {
                    this._deducciones = value;
                    this.OnPropertyChanged("Deducciones");
                }
            }
        }

        /// <summary>
        /// Nodo condicional para expresar otros pagos aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OtroPago", IsNullable = false)]
        public List<NominaOtroPago> OtrosPagos
        {
            get
            {
                return this._otrosPagos;
            }
            set
            {
                if ((this._otrosPagos == value))
                {
                    return;
                }
                if (((this._otrosPagos == null)
                            || (_otrosPagos.Equals(value) != true)))
                {
                    this._otrosPagos = value;
                    this.OnPropertyChanged("OtrosPagos");
                }
            }
        }

        /// <summary>
        /// Nodo condicional para expresar información de las incapacidades.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Incapacidad", IsNullable = false)]
        public List<NominaIncapacidad> Incapacidades
        {
            get
            {
                return this._incapacidades;
            }
            set
            {
                if ((this._incapacidades == value))
                {
                    return;
                }
                if (((this._incapacidades == null)
                            || (_incapacidades.Equals(value) != true)))
                {
                    this._incapacidades = value;
                    this.OnPropertyChanged("Incapacidades");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para la expresión de la versión del complemento.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                if ((this._version == value))
                {
                    return;
                }
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("Version");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para indicar el tipo de nómina, puede ser O= Nómina ordinaria o E= Nómina extraordinaria.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoNomina TipoNomina
        {
            get
            {
                return this._tipoNomina;
            }
            set
            {
                if ((_tipoNomina.Equals(value) != true))
                {
                    this._tipoNomina = value;
                    this.OnPropertyChanged("TipoNomina");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "FechaPago")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String sFechaPago
        {
            get
            {
                return FechaPago.ToString("yyyy-MM-dd");
            }
            set
            {

                if ((FechaPago.ToString("yyyy-MM-dd").Equals(value) != true))
                {
                    FechaPago = System.Convert.ToDateTime(value);
                    this.OnPropertyChanged("FechaPago");
                }
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "FechaInicialPago")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String sFechaInicialPago
        {
            get
            {
                return FechaInicialPago.ToString("yyyy-MM-dd");
            }
            set
            {

                if ((FechaInicialPago.ToString("yyyy-MM-dd").Equals(value) != true))
                {
                    FechaInicialPago = System.Convert.ToDateTime(value);
                    this.OnPropertyChanged("FechaInicialPago");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "FechaFinalPago")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String sFechaFinalPago
        {
            get
            {
                return FechaFinalPago.ToString("yyyy-MM-dd");
            }
            set
            {

                if ((FechaFinalPago.ToString("yyyy-MM-dd").Equals(value) != true))
                {
                    FechaFinalPago = System.Convert.ToDateTime(value);
                    this.OnPropertyChanged("FechaFinalPago");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para la expresión del número o la fracción de días pagados.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(([1-9][0-9]{0,4})|[0])(.[0-9]{3})?")]
        public decimal NumDiasPagados
        {
            get
            {
                return this._numDiasPagados;
            }
            set
            {
                if ((_numDiasPagados.Equals(value) != true))
                {
                    if (value > new decimal(99999.999))
                        throw new Exception("El valor debe ser menor a 99999.999");
                    else if(value<0)
                        throw new Exception("El valor debe ser mayor o igual a cero");
                    else if(value.ToString().Contains("."))
                    {
                        string[] partes = value.ToString().Split('.');
                        if (partes[0].Length > 3)
                            throw new Exception("Solo se permiten maximo 3 decimales");
                    }
                    this._numDiasPagados = value;
                    this.OnPropertyChanged("NumDiasPagados");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para representar la suma de las percepciones.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalPercepciones
        {
            get
            {
                return this._totalPercepciones;
            }
            set
            {
                if ((_totalPercepciones.Equals(value) != true))
                {
                    this._totalPercepciones = value;
                    this.OnPropertyChanged("TotalPercepciones");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para representar la suma de las deducciones aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalDeducciones
        {
            get
            {
                return this._totalDeducciones;
            }
            set
            {
                if ((_totalDeducciones.Equals(value) != true))
                {
                    this._totalDeducciones = value;
                    this.OnPropertyChanged("TotalDeducciones");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para representar la suma de otros pagos.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalOtrosPagos
        {
            get
            {
                return this._totalOtrosPagos;
            }
            set
            {
                if ((_totalOtrosPagos.Equals(value) != true))
                {
                    this._totalOtrosPagos = value;
                    this.OnPropertyChanged("TotalOtrosPagos");
                }
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
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(Nomina));
                }
                return serializer;
            }
        }

        /// <summary>
        /// Serializes current Nomina object into an XML string
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
                xmlWriterSettings.CheckCharacters = true;
                xmlWriterSettings.Indent = false;
                xmlWriterSettings.IndentChars = "\t";
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
        /// Deserializes workflow markup into an Nomina object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Nomina object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Nomina obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Nomina);
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

        public static bool Deserialize(string input, out Nomina obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static Nomina Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                
                input = input.Replace("nomina12:", "");

               /* if (input.IndexOf("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"") == -1)
                {
                    input = input.Replace("<Nomina", "<Nomina xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:nomina12=\"http://www.sat.gob.mx/nomina12\" xsi:schemaLocation=\"http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd\"  ");
                }*/

                stringReader = new System.IO.StringReader(input);
                return ((Nomina)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Nomina Deserialize(System.IO.Stream s)
        {
            return ((Nomina)(Serializer.Deserialize(s)));
        }
        #endregion

        #region Guadar/Leer

        /// <summary>
        /// Serializes current Nomina object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool GuardarEnArchivo(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                GuardarEnArchivo(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool GuardarEnArchivo(string fileName, out System.Exception exception)
        {
            return GuardarEnArchivo(fileName, System.Text.Encoding.UTF8, out exception);
        }

        public virtual void GuardarEnArchivo(string fileName)
        {
            GuardarEnArchivo(fileName, System.Text.Encoding.UTF8);
        }

        public virtual void GuardarEnArchivo(string fileName, System.Text.Encoding encoding)
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
        /// Deserializes xml markup from file into an Nomina object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Nomina object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out Nomina obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Nomina);
            try
            {
                obj = LeerDesdeArchivo(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LeerDesdeArchivo(string fileName, out Nomina obj, out System.Exception exception)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LeerDesdeArchivo(string fileName, out Nomina obj)
        {
            System.Exception exception = null;
            return LeerDesdeArchivo(fileName, out obj, out exception);
        }

        public static Nomina LeerDesdeArchivo(string fileName)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
        }

        public static Nomina LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

        #endregion
    }
}

