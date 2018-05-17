
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
    /// Complemento para el Comprobante Fiscal Digital por Internet (CFDI) para registrar información sobre la recepción de pagos. El emisor de este complemento para recepción de pagos debe ser quien las leyes le obligue a expedir comprobantes por los actos o actividades que realicen, por los ingresos que se perciban o por las retenciones de contribuciones que efectúen.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Pagos")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/Pagos", IsNullable=false)]
    public partial class Pagos : System.ComponentModel.INotifyPropertyChanged
    {

       /* [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd";*/

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PagosPago> _pago;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;
        
        private static XmlSerializer serializer;

        private Certificado _certificado;
        #endregion
        
        /// <summary>
        /// Pagos class constructor
        /// </summary>
        public Pagos(Certificado certificado)
        {
            this._pago = new List<PagosPago>();
            this._version = "1.0";
            _certificado = certificado;
        }

        public Pagos()
        {
            this._pago = new List<PagosPago>();
            this._version = "1.0";
            
        }

        /// <summary>
        /// Elemento requerido para incorporar la información de la recepción de pagos.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Pago", Order=0)]
        public List<PagosPago> Pago
        {
            get
            {
                return this._pago;
            }
            set
            {
                if ((this._pago == value))
                {
                    return;
                }
                if (((this._pago == null) 
                            || (_pago.Equals(value) != true)))
                {
                    this._pago = value;
                    this.OnPropertyChanged("Pago");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido que indica la versión del complemento para recepción de pagos.
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
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(Pagos));
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
        /// Serializes current Pagos object into an XML string
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
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("xsi", "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd");
                ns.Add("pago10", "http://www.sat.gob.mx/Pagos");
                Serializer.Serialize(xmlWriter, this, ns);
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
        /// Deserializes workflow markup into an Pagos object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Pagos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Pagos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Pagos);
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
        
        public static bool Deserialize(string input, out Pagos obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static Pagos Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((Pagos)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static Pagos Deserialize(System.IO.Stream s)
        {
            return ((Pagos)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current Pagos object into file
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
        /// Deserializes xml markup from file into an Pagos object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Pagos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Pagos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Pagos);
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
        
        public static bool LoadFromFile(string fileName, out Pagos obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out Pagos obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static Pagos LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static Pagos LoadFromFile(string fileName, System.Text.Encoding encoding)
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

        public bool GenerarXML(out String XML, out String Errores)
        {
            XML = String.Empty;
            Errores = String.Empty;
            bool Resultado = false;

            try
            {
                XML = Serialize(System.Text.Encoding.UTF8);
                return (!String.IsNullOrEmpty(XML));
            }
            catch (Exception ex)
            {
                Errores = ex.Message;
                if (ex.InnerException != null)
                    Errores += " innerEx:Pagos:" + ex.InnerException.Message;

            }


            return Resultado;
        }
    }
    
    
    

}

