
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


namespace FacturaElectronica.CFDI33.Complementos.spei
{
    /// <summary>
    /// Estándar aplicable a operaciones de SPEI a terceros
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    public partial class SPEI_Tercero : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private Complemento_SPEISPEI_TerceroOrdenante _ordenante;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private Complemento_SPEISPEI_TerceroBeneficiario _beneficiario;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fechaOperacion;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _hora;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _claveSPEI;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _sello;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numeroCertificado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _cadenaCDA;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _claveRastreo;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Complemento_SPEISPEI_Tercero class constructor
        /// </summary>
        public SPEI_Tercero()
        {
            this._beneficiario = new Complemento_SPEISPEI_TerceroBeneficiario();
            this._ordenante = new Complemento_SPEISPEI_TerceroOrdenante();
        }

        public Complemento_SPEISPEI_TerceroOrdenante Ordenante
        {
            get
            {
                return this._ordenante;
            }
            set
            {
                if ((this._ordenante == value))
                {
                    return;
                }
                if (((this._ordenante == null)
                            || (_ordenante.Equals(value) != true)))
                {
                    this._ordenante = value;
                    this.OnPropertyChanged("Ordenante");
                }
            }
        }

        public Complemento_SPEISPEI_TerceroBeneficiario Beneficiario
        {
            get
            {
                return this._beneficiario;
            }
            set
            {
                if ((this._beneficiario == value))
                {
                    return;
                }
                if (((this._beneficiario == null)
                            || (_beneficiario.Equals(value) != true)))
                {
                    this._beneficiario = value;
                    this.OnPropertyChanged("Beneficiario");
                }
            }
        }

        /// <summary>
        /// Fecha de operación con formato. Debe ser la misma que la fecha de operación del sistema.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((000[1-9])|(00[1-9][0-9])|(0[1-9][0-9]{2})|([1-9][0-9]{3}))-((0[1-9])|(1[012]))-" +
            "((0[1-9])|([12][0-9])|(3[01]))")]
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(DateTime), "01/01/0001", "31/12/9999")]
        public System.DateTime FechaOperacion
        {
            get
            {
                return this._fechaOperacion;
            }
            set
            {
                if ((_fechaOperacion.Equals(value) != true))
                {
                    this._fechaOperacion = value;
                    this.OnPropertyChanged("FechaOperacion");
                }
            }
        }

        /// <summary>
        /// hora del acreditamiento
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(([01][0-9])|(2[0-3]))(:[0-5][0-9]){2}(\\.[0-9]+)?")]
        public System.DateTime Hora
        {
            get
            {
                return this._hora;
            }
            set
            {
                if ((_hora.Equals(value) != true))
                {
                    this._hora = value;
                    this.OnPropertyChanged("Hora");
                }
            }
        }

        /// <summary>
        /// Clave SPEI del Participante Emisor.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ClaveSPEI
        {
            get
            {
                return this._claveSPEI;
            }
            set
            {
                if ((this._claveSPEI == value))
                {
                    return;
                }
                if (((this._claveSPEI == null)
                            || (_claveSPEI.Equals(value) != true)))
                {
                    this._claveSPEI = value;
                    this.OnPropertyChanged("ClaveSPEI");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante de pago. El sello deberá ser expresado cómo una cadena de texto en formato Base 64.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sello
        {
            get
            {
                return this._sello;
            }
            set
            {
                if ((this._sello == value))
                {
                    return;
                }
                if (((this._sello == null)
                            || (_sello.Equals(value) != true)))
                {
                    this._sello = value;
                    this.OnPropertyChanged("sello");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para la identificación del certificado de seguridad utilizado para el sello digital.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(20)]
        public string numeroCertificado
        {
            get
            {
                return this._numeroCertificado;
            }
            set
            {
                if ((this._numeroCertificado == value))
                {
                    return;
                }
                if (((this._numeroCertificado == null)
                            || (_numeroCertificado.Equals(value) != true)))
                {
                    this._numeroCertificado = value;
                    this.OnPropertyChanged("numeroCertificado");
                }
            }
        }

        /// <summary>
        /// Atributo que contiene la información del CDA fidedigna que la institución ha enviado a Banco de México.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(841)]
        public string cadenaCDA
        {
            get
            {
                return this._cadenaCDA;
            }
            set
            {
                if ((this._cadenaCDA == value))
                {
                    return;
                }
                if (((this._cadenaCDA == null)
                            || (_cadenaCDA.Equals(value) != true)))
                {
                    this._cadenaCDA = value;
                    this.OnPropertyChanged("cadenaCDA");
                }
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string claveRastreo
        {
            set
            {
                _claveRastreo = value;
                claveRastreoSpecified = true;
            }

            get
            {
                return _claveRastreo;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool claveRastreoSpecified { get; set; }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(SPEI_Tercero));
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
        /// Serializes current Complemento_SPEISPEI_Tercero object into an XML string
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
        /// Deserializes workflow markup into an Complemento_SPEISPEI_Tercero object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Complemento_SPEISPEI_Tercero object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out SPEI_Tercero obj, out System.Exception exception)
        {
            exception = null;
            obj = default(SPEI_Tercero);
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

        public static bool Deserialize(string input, out SPEI_Tercero obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static SPEI_Tercero Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((SPEI_Tercero)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static SPEI_Tercero Deserialize(System.IO.Stream s)
        {
            return ((SPEI_Tercero)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current Complemento_SPEISPEI_Tercero object into file
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
        /// Deserializes xml markup from file into an Complemento_SPEISPEI_Tercero object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Complemento_SPEISPEI_Tercero object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out SPEI_Tercero obj, out System.Exception exception)
        {
            exception = null;
            obj = default(SPEI_Tercero);
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

        public static bool LeerDesdeArchivo(string fileName, out SPEI_Tercero obj, out System.Exception exception)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LeerDesdeArchivo(string fileName, out SPEI_Tercero obj)
        {
            System.Exception exception = null;
            return LeerDesdeArchivo(fileName, out obj, out exception);
        }

        public static SPEI_Tercero LeerDesdeArchivo(string fileName)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
        }

        public new static SPEI_Tercero LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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
                if (!xmlString.Contains("xmlns="))
                {
                    if(!xmlString.Contains("<spei:"))
                        xmlString = xmlString.Replace("<SPEI_Tercero ", "<SPEI_Tercero xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" ").Replace("<Ordenante", "<Ordenante xmlns=\"http://www.sat.gob.mx/spei\"").Replace("<Beneficiario", "<Beneficiario xmlns=\"http://www.sat.gob.mx/spei\"");
                    else
                        xmlString = xmlString.Replace("<spei:SPEI_Tercero ", "<spei:SPEI_Tercero xmlns=\"\" ");
                }
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

