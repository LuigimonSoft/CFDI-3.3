#pragma warning disable
namespace FacturaElectronica.CFDI33.ComplementosConceptos
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
    /// Complemento concepto para la emisión de Comprobante Fiscal Digital (CFD) y Comprobante Fiscal Digital a través de Internet (CFDI) por orden y cuenta de terceros.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.sat.gob.mx/terceros", IsNullable=false)]
    public partial class PorCuentadeTerceros : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private PorCuentadeTercerosInformacionFiscalTercero _informacionFiscalTercero;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<object> _items;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private PorCuentadeTercerosImpuestos _impuestos;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rfc;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _nombre;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// PorCuentadeTerceros class constructor
        /// </summary>
        public PorCuentadeTerceros()
        {
            this._impuestos = new PorCuentadeTercerosImpuestos();
            this._items = new List<object>();
            this._version = "1.1";
        }
        
        /// <summary>
        /// Nodo opcional para expresar información fiscal de terceros
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PorCuentadeTercerosInformacionFiscalTercero InformacionFiscalTercero
        {
            get
            {
                return this._informacionFiscalTercero;
            }
            set
            {
                if ((this._informacionFiscalTercero == value))
                {
                    return;
                }
                if (((this._informacionFiscalTercero == null) 
                            || (_informacionFiscalTercero.Equals(value) != true)))
                {
                    this._informacionFiscalTercero = value;
                    this.OnPropertyChanged("InformacionFiscalTercero");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CuentaPredial", typeof(PorCuentadeTercerosCuentaPredial), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", typeof(PorCuentadeTercerosInformacionAduanera), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("Parte", typeof(PorCuentadeTercerosParte), Order=1)]
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
        /// Nodo requerido para capturar los impuestos aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PorCuentadeTercerosImpuestos Impuestos
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
        
        /// <summary>
        /// Atributo requerido con valor prefijado a 1.1 que indica la versión del estandar bajo el que se encuentra expresado el complemento.
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
        /// Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante sin guiones o espacios.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(13, MinimumLength=12)]
        public string rfc
        {
            get
            {
                return this._rfc;
            }
            set
            {
                if ((this._rfc == value))
                {
                    return;
                }
                if (((this._rfc == null) 
                            || (_rfc.Equals(value) != true)))
                {
                    this._rfc = value;
                    this.OnPropertyChanged("rfc");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para el nombre o razón social del contribuyente emisor del comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if ((this._nombre == value))
                {
                    return;
                }
                if (((this._nombre == null) 
                            || (_nombre.Equals(value) != true)))
                {
                    this._nombre = value;
                    this.OnPropertyChanged("nombre");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTerceros));
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
        /// Serializes current PorCuentadeTerceros object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTerceros object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTerceros object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTerceros obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTerceros);
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
        
        public static bool Deserialize(string input, out PorCuentadeTerceros obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTerceros Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTerceros)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTerceros Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTerceros)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTerceros object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTerceros object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTerceros object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTerceros obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTerceros);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTerceros obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTerceros obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTerceros LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTerceros LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo opcional para expresar información fiscal de terceros
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosInformacionFiscalTercero : t_UbicacionFiscal
    {
        
        #region Private fields
        private static XmlSerializer serializer;
        #endregion
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosInformacionFiscalTercero));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PorCuentadeTercerosInformacionFiscalTercero object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosInformacionFiscalTercero object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosInformacionFiscalTercero object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosInformacionFiscalTercero obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosInformacionFiscalTercero);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosInformacionFiscalTercero obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosInformacionFiscalTercero Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosInformacionFiscalTercero)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosInformacionFiscalTercero Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosInformacionFiscalTercero)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosInformacionFiscalTercero object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosInformacionFiscalTercero object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosInformacionFiscalTercero object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosInformacionFiscalTercero obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosInformacionFiscalTercero);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosInformacionFiscalTercero obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosInformacionFiscalTercero obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosInformacionFiscalTercero LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosInformacionFiscalTercero LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Tipo definido para expresar domicilios o direcciones
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/terceros")]
    public partial class t_UbicacionFiscal : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _calle;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noExterior;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noInterior;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _colonia;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _localidad;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _referencia;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _municipio;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _estado;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _pais;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _codigoPostal;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Este atributo requerido sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string calle
        {
            get
            {
                return this._calle;
            }
            set
            {
                if ((this._calle == value))
                {
                    return;
                }
                if (((this._calle == null) 
                            || (_calle.Equals(value) != true)))
                {
                    this._calle = value;
                    this.OnPropertyChanged("calle");
                }
            }
        }
        
        /// <summary>
        /// Este atributo opcional sirve para expresar el número particular en donde se da la ubicación sobre una calle dada.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string noExterior
        {
            get
            {
                return this._noExterior;
            }
            set
            {
                if ((this._noExterior == value))
                {
                    return;
                }
                if (((this._noExterior == null) 
                            || (_noExterior.Equals(value) != true)))
                {
                    this._noExterior = value;
                    this.OnPropertyChanged("noExterior");
                }
            }
        }
        
        /// <summary>
        /// Este atributo opcional sirve para expresar información adicional para especificar la ubicación cuando calle y número exterior (noExterior) no resulten suficientes para determinar la ubicación de forma precisa.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string noInterior
        {
            get
            {
                return this._noInterior;
            }
            set
            {
                if ((this._noInterior == value))
                {
                    return;
                }
                if (((this._noInterior == null) 
                            || (_noInterior.Equals(value) != true)))
                {
                    this._noInterior = value;
                    this.OnPropertyChanged("noInterior");
                }
            }
        }
        
        /// <summary>
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicación cuando se desea ser más específico en casos de ubicaciones urbanas.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string colonia
        {
            get
            {
                return this._colonia;
            }
            set
            {
                if ((this._colonia == value))
                {
                    return;
                }
                if (((this._colonia == null) 
                            || (_colonia.Equals(value) != true)))
                {
                    this._colonia = value;
                    this.OnPropertyChanged("colonia");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string localidad
        {
            get
            {
                return this._localidad;
            }
            set
            {
                if ((this._localidad == value))
                {
                    return;
                }
                if (((this._localidad == null) 
                            || (_localidad.Equals(value) != true)))
                {
                    this._localidad = value;
                    this.OnPropertyChanged("localidad");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para expresar una referencia de ubicación adicional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referencia
        {
            get
            {
                return this._referencia;
            }
            set
            {
                if ((this._referencia == value))
                {
                    return;
                }
                if (((this._referencia == null) 
                            || (_referencia.Equals(value) != true)))
                {
                    this._referencia = value;
                    this.OnPropertyChanged("referencia");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) en donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string municipio
        {
            get
            {
                return this._municipio;
            }
            set
            {
                if ((this._municipio == value))
                {
                    return;
                }
                if (((this._municipio == null) 
                            || (_municipio.Equals(value) != true)))
                {
                    this._municipio = value;
                    this.OnPropertyChanged("municipio");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido que sirve para precisar el estado o entidad federativa donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                if ((this._estado == value))
                {
                    return;
                }
                if (((this._estado == null) 
                            || (_estado.Equals(value) != true)))
                {
                    this._estado = value;
                    this.OnPropertyChanged("estado");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido que sirve para precisar el país donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pais
        {
            get
            {
                return this._pais;
            }
            set
            {
                if ((this._pais == value))
                {
                    return;
                }
                if (((this._pais == null) 
                            || (_pais.Equals(value) != true)))
                {
                    this._pais = value;
                    this.OnPropertyChanged("pais");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido que sirve para asentar el código postal en donde se da la ubicación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codigoPostal
        {
            get
            {
                return this._codigoPostal;
            }
            set
            {
                if ((this._codigoPostal == value))
                {
                    return;
                }
                if (((this._codigoPostal == null) 
                            || (_codigoPostal.Equals(value) != true)))
                {
                    this._codigoPostal = value;
                    this.OnPropertyChanged("codigoPostal");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(t_UbicacionFiscal));
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
        /// Serializes current t_UbicacionFiscal object into an XML string
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
        /// Deserializes workflow markup into an t_UbicacionFiscal object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output t_UbicacionFiscal object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out t_UbicacionFiscal obj, out System.Exception exception)
        {
            exception = null;
            obj = default(t_UbicacionFiscal);
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
        
        public static bool Deserialize(string input, out t_UbicacionFiscal obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static t_UbicacionFiscal Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((t_UbicacionFiscal)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static t_UbicacionFiscal Deserialize(System.IO.Stream s)
        {
            return ((t_UbicacionFiscal)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current t_UbicacionFiscal object into file
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
        /// Deserializes xml markup from file into an t_UbicacionFiscal object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output t_UbicacionFiscal object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out t_UbicacionFiscal obj, out System.Exception exception)
        {
            exception = null;
            obj = default(t_UbicacionFiscal);
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
        
        public static bool LoadFromFile(string fileName, out t_UbicacionFiscal obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out t_UbicacionFiscal obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static t_UbicacionFiscal LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static t_UbicacionFiscal LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Tipo definido para expresar información aduanera
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/terceros")]
    public partial class t_InformacionAduanera : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numero;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fecha;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _aduana;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Atributo requerido para expresar el número del documento aduanero que ampara la importación del bien.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                if ((this._numero == value))
                {
                    return;
                }
                if (((this._numero == null) 
                            || (_numero.Equals(value) != true)))
                {
                    this._numero = value;
                    this.OnPropertyChanged("numero");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para expresar la fecha de expedición del documento aduanero que ampara la importación del bien.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                if ((_fecha.Equals(value) != true))
                {
                    this._fecha = value;
                    this.OnPropertyChanged("fecha");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para precisar la aduana por la que se efectuó la importación del bien.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string aduana
        {
            get
            {
                return this._aduana;
            }
            set
            {
                if ((this._aduana == value))
                {
                    return;
                }
                if (((this._aduana == null) 
                            || (_aduana.Equals(value) != true)))
                {
                    this._aduana = value;
                    this.OnPropertyChanged("aduana");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(t_InformacionAduanera));
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
        /// Serializes current t_InformacionAduanera object into an XML string
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
        /// Deserializes workflow markup into an t_InformacionAduanera object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output t_InformacionAduanera object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out t_InformacionAduanera obj, out System.Exception exception)
        {
            exception = null;
            obj = default(t_InformacionAduanera);
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
        
        public static bool Deserialize(string input, out t_InformacionAduanera obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static t_InformacionAduanera Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((t_InformacionAduanera)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static t_InformacionAduanera Deserialize(System.IO.Stream s)
        {
            return ((t_InformacionAduanera)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current t_InformacionAduanera object into file
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
        /// Deserializes xml markup from file into an t_InformacionAduanera object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output t_InformacionAduanera object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out t_InformacionAduanera obj, out System.Exception exception)
        {
            exception = null;
            obj = default(t_InformacionAduanera);
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
        
        public static bool LoadFromFile(string fileName, out t_InformacionAduanera obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out t_InformacionAduanera obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static t_InformacionAduanera LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static t_InformacionAduanera LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo opcional para asentar el número de cuenta predial con el que fue registrado el inmueble, en el sistema catastral de la entidad federativa de que trate.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosCuentaPredial : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numero;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Atributo requerido para precisar el número de la cuenta predial del inmueble cubierto por el presente concepto en caso de recibos de arrendamiento.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                if ((this._numero == value))
                {
                    return;
                }
                if (((this._numero == null) 
                            || (_numero.Equals(value) != true)))
                {
                    this._numero = value;
                    this.OnPropertyChanged("numero");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosCuentaPredial));
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
        /// Serializes current PorCuentadeTercerosCuentaPredial object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosCuentaPredial object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosCuentaPredial object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosCuentaPredial obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosCuentaPredial);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosCuentaPredial obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosCuentaPredial Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosCuentaPredial)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosCuentaPredial Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosCuentaPredial)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosCuentaPredial object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosCuentaPredial object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosCuentaPredial object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosCuentaPredial obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosCuentaPredial);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosCuentaPredial obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosCuentaPredial obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosCuentaPredial LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosCuentaPredial LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosInformacionAduanera : t_InformacionAduanera
    {
        
        #region Private fields
        private static XmlSerializer serializer;
        #endregion
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosInformacionAduanera));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PorCuentadeTercerosInformacionAduanera object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosInformacionAduanera object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosInformacionAduanera object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosInformacionAduanera obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosInformacionAduanera);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosInformacionAduanera obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosInformacionAduanera Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosInformacionAduanera)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosInformacionAduanera Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosInformacionAduanera)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosInformacionAduanera object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosInformacionAduanera object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosInformacionAduanera object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosInformacionAduanera obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosInformacionAduanera);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosInformacionAduanera obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosInformacionAduanera obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosInformacionAduanera LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosInformacionAduanera LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo opcional para expresar las partes o componentes que integran la totalidad del concepto expresado en el CFD o CFDI
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosParte : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<t_InformacionAduanera> _informacionAduanera;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _cantidad;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _unidad;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noIdentificacion;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _descripcion;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _valorUnitario;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de partes o componentes importados vendidos de primera mano.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", Order=0)]
        public List<t_InformacionAduanera> InformacionAduanera
        {
            get
            {
                return this._informacionAduanera;
            }
            set
            {
                if ((this._informacionAduanera == value))
                {
                    return;
                }
                if (((this._informacionAduanera == null) 
                            || (_informacionAduanera.Equals(value) != true)))
                {
                    this._informacionAduanera = value;
                    this.OnPropertyChanged("InformacionAduanera");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                if ((_cantidad.Equals(value) != true))
                {
                    this._cantidad = value;
                    this.OnPropertyChanged("cantidad");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para precisar la unidad de medida aplicable para la cantidad expresada en la parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unidad
        {
            get
            {
                return this._unidad;
            }
            set
            {
                if ((this._unidad == value))
                {
                    return;
                }
                if (((this._unidad == null) 
                            || (_unidad.Equals(value) != true)))
                {
                    this._unidad = value;
                    this.OnPropertyChanged("unidad");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio amparado por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string noIdentificacion
        {
            get
            {
                return this._noIdentificacion;
            }
            set
            {
                if ((this._noIdentificacion == value))
                {
                    return;
                }
                if (((this._noIdentificacion == null) 
                            || (_noIdentificacion.Equals(value) != true)))
                {
                    this._noIdentificacion = value;
                    this.OnPropertyChanged("noIdentificacion");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                if ((this._descripcion == value))
                {
                    return;
                }
                if (((this._descripcion == null) 
                            || (_descripcion.Equals(value) != true)))
                {
                    this._descripcion = value;
                    this.OnPropertyChanged("descripcion");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para precisar el valor o precio unitario del bien o servicio cubierto por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valorUnitario
        {
            get
            {
                return this._valorUnitario;
            }
            set
            {
                if ((_valorUnitario.Equals(value) != true))
                {
                    this._valorUnitario = value;
                    this.OnPropertyChanged("valorUnitario");
                }
            }
        }
        
        /// <summary>
        /// Atributo opcional para precisar el importe total de los bienes o servicios de la presente parte. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en la parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal importe
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
                    this.OnPropertyChanged("importe");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosParte));
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
        /// Serializes current PorCuentadeTercerosParte object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosParte object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosParte object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosParte obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosParte);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosParte obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosParte Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosParte)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosParte Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosParte)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosParte object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosParte object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosParte object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosParte obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosParte);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosParte obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosParte obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosParte LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosParte LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo requerido para capturar los impuestos aplicables.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosImpuestos : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PorCuentadeTercerosImpuestosRetencion> _retenciones;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PorCuentadeTercerosImpuestosTraslado> _traslados;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Nodo opcional para capturar los impuestos retenidos aplicables
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable=false)]
        public List<PorCuentadeTercerosImpuestosRetencion> Retenciones
        {
            get
            {
                return this._retenciones;
            }
            set
            {
                if ((this._retenciones == value))
                {
                    return;
                }
                if (((this._retenciones == null) 
                            || (_retenciones.Equals(value) != true)))
                {
                    this._retenciones = value;
                    this.OnPropertyChanged("Retenciones");
                }
            }
        }
        
        /// <summary>
        /// Nodo opcional para asentar o referir los impuestos trasladados aplicables
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable=false)]
        public List<PorCuentadeTercerosImpuestosTraslado> Traslados
        {
            get
            {
                return this._traslados;
            }
            set
            {
                if ((this._traslados == value))
                {
                    return;
                }
                if (((this._traslados == null) 
                            || (_traslados.Equals(value) != true)))
                {
                    this._traslados = value;
                    this.OnPropertyChanged("Traslados");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosImpuestos));
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
        /// Serializes current PorCuentadeTercerosImpuestos object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosImpuestos object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestos);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestos obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosImpuestos Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosImpuestos)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosImpuestos Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosImpuestos)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosImpuestos object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosImpuestos object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosImpuestos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestos);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestos obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestos obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosImpuestos LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosImpuestos LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    /// Nodo para la información detallada de una retención de impuesto específico
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosImpuestosRetencion : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private PorCuentadeTercerosImpuestosRetencionImpuesto _impuesto;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto retenido
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PorCuentadeTercerosImpuestosRetencionImpuesto impuesto
        {
            get
            {
                return this._impuesto;
            }
            set
            {
                if ((_impuesto.Equals(value) != true))
                {
                    this._impuesto = value;
                    this.OnPropertyChanged("impuesto");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para señalar el importe o monto del impuesto retenido
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal importe
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
                    this.OnPropertyChanged("importe");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosImpuestosRetencion));
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
        /// Serializes current PorCuentadeTercerosImpuestosRetencion object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosImpuestosRetencion object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestosRetencion object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestosRetencion obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestosRetencion);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestosRetencion obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosImpuestosRetencion Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosImpuestosRetencion)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosImpuestosRetencion Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosImpuestosRetencion)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosImpuestosRetencion object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosImpuestosRetencion object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestosRetencion object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosImpuestosRetencion obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestosRetencion);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestosRetencion obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestosRetencion obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosImpuestosRetencion LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosImpuestosRetencion LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public enum PorCuentadeTercerosImpuestosRetencionImpuesto
    {
        
        /// <summary>
        /// Impuesto sobre la renta
        /// </summary>
        ISR,
        
        /// <summary>
        /// Impuesto al Valor Agregado
        /// </summary>
        IVA,
    }
    
    /// <summary>
    /// Nodo para la información detallada de un traslado de impuesto específico
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public partial class PorCuentadeTercerosImpuestosTraslado : System.ComponentModel.INotifyPropertyChanged
    {
        
        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private PorCuentadeTercerosImpuestosTrasladoImpuesto _impuesto;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tasa;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;
        
        private static XmlSerializer serializer;
        #endregion
        
        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto trasladado
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PorCuentadeTercerosImpuestosTrasladoImpuesto impuesto
        {
            get
            {
                return this._impuesto;
            }
            set
            {
                if ((_impuesto.Equals(value) != true))
                {
                    this._impuesto = value;
                    this.OnPropertyChanged("impuesto");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para señalar la tasa del impuesto que se traslada por cada concepto amparado en el comprobante
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tasa
        {
            get
            {
                return this._tasa;
            }
            set
            {
                if ((_tasa.Equals(value) != true))
                {
                    this._tasa = value;
                    this.OnPropertyChanged("tasa");
                }
            }
        }
        
        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto trasladado
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal importe
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
                    this.OnPropertyChanged("importe");
                }
            }
        }
        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PorCuentadeTercerosImpuestosTraslado));
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
        /// Serializes current PorCuentadeTercerosImpuestosTraslado object into an XML string
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
        /// Deserializes workflow markup into an PorCuentadeTercerosImpuestosTraslado object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestosTraslado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestosTraslado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestosTraslado);
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
        
        public static bool Deserialize(string input, out PorCuentadeTercerosImpuestosTraslado obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }
        
        public new static PorCuentadeTercerosImpuestosTraslado Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PorCuentadeTercerosImpuestosTraslado)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }
        
        public static PorCuentadeTercerosImpuestosTraslado Deserialize(System.IO.Stream s)
        {
            return ((PorCuentadeTercerosImpuestosTraslado)(Serializer.Deserialize(s)));
        }
        #endregion
        
        /// <summary>
        /// Serializes current PorCuentadeTercerosImpuestosTraslado object into file
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
        /// Deserializes xml markup from file into an PorCuentadeTercerosImpuestosTraslado object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PorCuentadeTercerosImpuestosTraslado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PorCuentadeTercerosImpuestosTraslado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PorCuentadeTercerosImpuestosTraslado);
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
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestosTraslado obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }
        
        public static bool LoadFromFile(string fileName, out PorCuentadeTercerosImpuestosTraslado obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PorCuentadeTercerosImpuestosTraslado LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }
        
        public new static PorCuentadeTercerosImpuestosTraslado LoadFromFile(string fileName, System.Text.Encoding encoding)
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
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/terceros")]
    public enum PorCuentadeTercerosImpuestosTrasladoImpuesto
    {
        
        /// <summary>
        /// Impuesto al Valor Agregado
        /// </summary>
        IVA,
        
        /// <summary>
        /// Impuesto especial sobre productos y servicios
        /// </summary>
        IEPS,
    }
}
#pragma warning restore
