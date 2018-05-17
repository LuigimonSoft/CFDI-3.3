
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
    /// Complemento requerido para el Timbrado Fiscal Digital que da validez al Comprobante fiscal digital por Internet.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/TimbreFiscalDigital")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/TimbreFiscalDigital", IsNullable=false)]
    public partial class TimbreFiscalDigital : System.ComponentModel.INotifyPropertyChanged
    {

        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/cfd/TimbreFiscalDigital/TimbreFiscalDigitalv11.xsd";

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _uUID;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaTimbrado;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rfcProvCertif;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _leyenda;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _selloCFD;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noCertificadoSAT;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _selloSAT;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// TimbreFiscalDigital class constructor
        /// </summary>
        public TimbreFiscalDigital()
        {
            PosicionEsquema = System.Windows.Forms.Application.StartupPath + "\\CFDI33";
            this._version = "1.1";

        }
        
        /// <summary>
        /// Atributo requerido para la expresión de la versión del estándar del Timbre Fiscal Digital
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
                if (((this._version == null) || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("Version");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar los 36 caracteres del folio fiscal (UUID) de la transacción de timbrado conforme al estándar RFC 4122
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[a-f0-9A-F]{8}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{12}")]
        public string UUID
        {
            get
            {
                return this._uUID;
            }
            set
            {
                if ((this._uUID == value))
                {
                    return;
                }
                if (((this._uUID == null) || (_uUID.Equals(value) != true)))
                {
                    this._uUID = value;
                    this.OnPropertyChanged("UUID");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar la fecha y hora, de la generación del timbre por la certificación digital del SAT. Se expresa en la forma AAAA-MM-DDThh:mm:ss y debe corresponder con la hora de la Zona Centro del Sistema de Horario en México.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaTimbrado
        {
            get
            {
                return this._fechaTimbrado;
            }
            set
            {
                if ((_fechaTimbrado.Equals(value) != true))
                {
                    this._fechaTimbrado = value;
                    this.OnPropertyChanged("FechaTimbrado");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar el RFC del proveedor de certificación de comprobantes fiscales digitales que genera el timbre fiscal digital.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcProvCertif
        {
            get
            {
                return this._rfcProvCertif;
            }
            set
            {
                if ((this._rfcProvCertif == value))
                {
                    return;
                }
                if (((this._rfcProvCertif == null) || (_rfcProvCertif.Equals(value) != true)))
                {
                    this._rfcProvCertif = value;
                    this.OnPropertyChanged("RfcProvCertif");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para registrar información que el SAT comunique a los usuarios del CFDI.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(150, MinimumLength=12)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([A-Z]|[a-z]|[0-9]| |Ñ|ñ|!|\"|%|&|\'|´|-|:|;|>|=|<|@|_|,|\\{|\\}|`|~|á|é|í|ó|ú|Á|É|Í|Ó|Ú|ü|Ü){1,150}")]
        public string Leyenda
        {
            get
            {
                return this._leyenda;
            }
            set
            {
                if ((this._leyenda == value))
                {
                    return;
                }
                if (((this._leyenda == null) || (_leyenda.Equals(value) != true)))
                {
                    this._leyenda = value;
                    this.OnPropertyChanged("Leyenda");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante fiscal o del comprobante de retenciones, que se ha timbrado. El sello debe ser expresado como una cadena de texto en formato Base 64.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelloCFD
        {
            get
            {
                return this._selloCFD;
            }
            set
            {
                if ((this._selloCFD == value))
                {
                    return;
                }
                if (((this._selloCFD == null) || (_selloCFD.Equals(value) != true)))
                {
                    this._selloCFD = value;
                    this.OnPropertyChanged("SelloCFD");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar el número de serie del certificado del SAT usado para generar el sello digital del Timbre Fiscal Digital.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{20}")]
        public string NoCertificadoSAT
        {
            get
            {
                return this._noCertificadoSAT;
            }
            set
            {
                if ((this._noCertificadoSAT == value))
                {
                    return;
                }
                if (((this._noCertificadoSAT == null) || (_noCertificadoSAT.Equals(value) != true)))
                {
                    this._noCertificadoSAT = value;
                    this.OnPropertyChanged("NoCertificadoSAT");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para contener el sello digital del Timbre Fiscal Digital, al que hacen referencia las reglas de la Resolución Miscelánea vigente. El sello debe ser expresado como una cadena de texto en formato Base 64.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelloSAT
        {
            get
            {
                return this._selloSAT;
            }
            set
            {
                if ((this._selloSAT == value))
                {
                    return;
                }
                if (((this._selloSAT == null) || (_selloSAT.Equals(value) != true)))
                {
                    this._selloSAT = value;
                    this.OnPropertyChanged("SelloSAT");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(TimbreFiscalDigital));
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
        /// Serializes current TimbreFiscalDigital object into an XML string
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
        /// Deserializes workflow markup into an TimbreFiscalDigital object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output TimbreFiscalDigital object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out TimbreFiscalDigital obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TimbreFiscalDigital);
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
        
        public static bool Deserialize(string input, out TimbreFiscalDigital obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static TimbreFiscalDigital Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                if (input.IndexOf("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"") == -1)
                {
                    input  = input.Replace("<tfd:TimbreFiscalDigital", "<tfd:TimbreFiscalDigital xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
                }
                
                stringReader = new System.IO.StringReader(input);
                return ((TimbreFiscalDigital)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }


        
        public static TimbreFiscalDigital Deserialize(System.IO.Stream s)
        {
            return ((TimbreFiscalDigital)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current TimbreFiscalDigital object into file
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
        /// Deserializes xml markup from file into an TimbreFiscalDigital object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TimbreFiscalDigital object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TimbreFiscalDigital obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TimbreFiscalDigital);
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
        
        public static bool LoadFromFile(string fileName, out TimbreFiscalDigital obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out TimbreFiscalDigital obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static TimbreFiscalDigital LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public  static TimbreFiscalDigital LoadFromFile(string fileName, System.Text.Encoding encoding)
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

