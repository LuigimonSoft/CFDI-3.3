#pragma warning disable
namespace FacturaElectronica.CFDI33.Complementos
{
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
    
    
    /// <summary>
    /// Complemento al Comprobante Fiscal Digital para Impuestos Locales
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/implocal")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/implocal", IsNullable=false)]
    public partial class ImpuestosLocales : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<object> _items;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totaldeRetenciones;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totaldeTraslados;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// ImpuestosLocales class constructor
        /// </summary>
        public ImpuestosLocales()
        {
            this._items = new List<object>();
            this._version = "1.0";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RetencionesLocales", typeof(ImpuestosLocalesRetencionesLocales), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("TrasladosLocales", typeof(ImpuestosLocalesTrasladosLocales), Order=0)]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                if ((this._items == value))
                {
                    return;
                }
                if (((this._items == null) 
                            || (_items.Equals(value) != true)))
                {
                    this._items = value;
                    this.OnPropertyChanged("Items");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar la versión del complemento
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
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
                    this.OnPropertyChanged("version");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar la suma total de Retenciones aplicables
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotaldeRetenciones
        {
            get
            {
                return this._totaldeRetenciones;
            }
            set
            {
                if ((_totaldeRetenciones.Equals(value) != true))
                {
                    this._totaldeRetenciones = value;
                    this.OnPropertyChanged("TotaldeRetenciones");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar la suma total de traslados aplicables
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotaldeTraslados
        {
            get
            {
                return this._totaldeTraslados;
            }
            set
            {
                if ((_totaldeTraslados.Equals(value) != true))
                {
                    this._totaldeTraslados = value;
                    this.OnPropertyChanged("TotaldeTraslados");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(ImpuestosLocales));
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
        /// Serializes current ImpuestosLocales object into an XML string
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
        /// Deserializes workflow markup into an ImpuestosLocales object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ImpuestosLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ImpuestosLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocales);
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
        
        public static bool Deserialize(string input, out ImpuestosLocales obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static ImpuestosLocales Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ImpuestosLocales)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static ImpuestosLocales Deserialize(System.IO.Stream s)
        {
            return ((ImpuestosLocales)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current ImpuestosLocales object into file
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
        /// Deserializes xml markup from file into an ImpuestosLocales object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ImpuestosLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ImpuestosLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocales);
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
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocales obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocales obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ImpuestosLocales LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static ImpuestosLocales LoadFromFile(string fileName, System.Text.Encoding encoding)
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
            }


            return Resultado;
        }
    }
    
    /// <summary>
    /// Nodo opcional para la expresión de los impuestos locales retenidos
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/implocal")]
    public partial class ImpuestosLocalesRetencionesLocales : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _impLocRetenido;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tasadeRetencion;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Nombre del impuesto local retenido
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpLocRetenido
        {
            get
            {
                return this._impLocRetenido;
            }
            set
            {
                if ((this._impLocRetenido == value))
                {
                    return;
                }
                if (((this._impLocRetenido == null) 
                            || (_impLocRetenido.Equals(value) != true)))
                {
                    this._impLocRetenido = value;
                    this.OnPropertyChanged("ImpLocRetenido");
                }
            }
        }
        
        /// <summary>
        /// Porcentaje de retención del impuesto local
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasadeRetencion
        {
            get
            {
                return this._tasadeRetencion;
            }
            set
            {
                if ((_tasadeRetencion.Equals(value) != true))
                {
                    this._tasadeRetencion = value;
                    this.OnPropertyChanged("TasadeRetencion");
                }
            }
        }
        
        /// <summary>
        /// Monto del impuesto local retenido
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this._importe;
            }
            set
            {
                if ((_importe.Equals(value) != true))
                {
                    this._importe = value;
                    this.OnPropertyChanged("Importe");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(ImpuestosLocalesRetencionesLocales));
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
        /// Serializes current ImpuestosLocalesRetencionesLocales object into an XML string
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
        /// Deserializes workflow markup into an ImpuestosLocalesRetencionesLocales object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ImpuestosLocalesRetencionesLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ImpuestosLocalesRetencionesLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocalesRetencionesLocales);
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
        
        public static bool Deserialize(string input, out ImpuestosLocalesRetencionesLocales obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static ImpuestosLocalesRetencionesLocales Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ImpuestosLocalesRetencionesLocales)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static ImpuestosLocalesRetencionesLocales Deserialize(System.IO.Stream s)
        {
            return ((ImpuestosLocalesRetencionesLocales)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current ImpuestosLocalesRetencionesLocales object into file
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
        /// Deserializes xml markup from file into an ImpuestosLocalesRetencionesLocales object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ImpuestosLocalesRetencionesLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ImpuestosLocalesRetencionesLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocalesRetencionesLocales);
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
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocalesRetencionesLocales obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocalesRetencionesLocales obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ImpuestosLocalesRetencionesLocales LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static ImpuestosLocalesRetencionesLocales LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    
    /// <summary>
    /// Nodo opcional para la expresión de los impuestos locales trasladados
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/implocal")]
    public partial class ImpuestosLocalesTrasladosLocales : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _impLocTrasladado;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tasadeTraslado;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Nombre del impuesto local trasladado
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpLocTrasladado
        {
            get
            {
                return this._impLocTrasladado;
            }
            set
            {
                if ((this._impLocTrasladado == value))
                {
                    return;
                }
                if (((this._impLocTrasladado == null) 
                            || (_impLocTrasladado.Equals(value) != true)))
                {
                    this._impLocTrasladado = value;
                    this.OnPropertyChanged("ImpLocTrasladado");
                }
            }
        }
        
        /// <summary>
        /// Porcentaje de traslado del impuesto local
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasadeTraslado
        {
            get
            {
                return this._tasadeTraslado;
            }
            set
            {
                if ((_tasadeTraslado.Equals(value) != true))
                {
                    this._tasadeTraslado = value;
                    this.OnPropertyChanged("TasadeTraslado");
                }
            }
        }
        
        /// <summary>
        /// Monto del impuesto local trasladado
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this._importe;
            }
            set
            {
                if ((_importe.Equals(value) != true))
                {
                    this._importe = value;
                    this.OnPropertyChanged("Importe");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(ImpuestosLocalesTrasladosLocales));
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
        /// Serializes current ImpuestosLocalesTrasladosLocales object into an XML string
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
        /// Deserializes workflow markup into an ImpuestosLocalesTrasladosLocales object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ImpuestosLocalesTrasladosLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ImpuestosLocalesTrasladosLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocalesTrasladosLocales);
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
        
        public static bool Deserialize(string input, out ImpuestosLocalesTrasladosLocales obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static ImpuestosLocalesTrasladosLocales Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ImpuestosLocalesTrasladosLocales)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static ImpuestosLocalesTrasladosLocales Deserialize(System.IO.Stream s)
        {
            return ((ImpuestosLocalesTrasladosLocales)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current ImpuestosLocalesTrasladosLocales object into file
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
        /// Deserializes xml markup from file into an ImpuestosLocalesTrasladosLocales object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ImpuestosLocalesTrasladosLocales object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ImpuestosLocalesTrasladosLocales obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ImpuestosLocalesTrasladosLocales);
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
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocalesTrasladosLocales obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out ImpuestosLocalesTrasladosLocales obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ImpuestosLocalesTrasladosLocales LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static ImpuestosLocalesTrasladosLocales LoadFromFile(string fileName, System.Text.Encoding encoding)
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
#pragma warning restore
