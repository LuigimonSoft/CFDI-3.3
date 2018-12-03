
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
    /// Complemento para el uso de SPEI Tercero a Tercero
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/spei", IsNullable = false)]
    public partial class Complemento_SPEI : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<SPEI_Tercero> _sPEI_Tercero;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Complemento_SPEI class constructor
        /// </summary>
        public Complemento_SPEI()
        {
            this._sPEI_Tercero = new List<SPEI_Tercero>();
        }

        /// <summary>
        /// Estándar aplicable a operaciones de SPEI a terceros
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SPEI_Tercero", Order = 0)]
        public List<SPEI_Tercero> SPEI_Tercero
        {
            get
            {
                return this._sPEI_Tercero;
            }
            set
            {
                if ((this._sPEI_Tercero == value))
                {
                    return;
                }
                if (((this._sPEI_Tercero == null)
                            || (_sPEI_Tercero.Equals(value) != true)))
                {
                    this._sPEI_Tercero = value;
                    this.OnPropertyChanged("SPEI_Tercero");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(Complemento_SPEI));
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
        /// Serializes current Complemento_SPEI object into an XML string
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
        /// Deserializes workflow markup into an Complemento_SPEI object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Complemento_SPEI object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Complemento_SPEI obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Complemento_SPEI);
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

        public static bool Deserialize(string input, out Complemento_SPEI obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static Complemento_SPEI Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((Complemento_SPEI)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Complemento_SPEI Deserialize(System.IO.Stream s)
        {
            return ((Complemento_SPEI)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current Complemento_SPEI object into file
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
        /// Deserializes xml markup from file into an Complemento_SPEI object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Complemento_SPEI object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out Complemento_SPEI obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Complemento_SPEI);
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

        public static bool LeerDesdeArchivo(string fileName, out Complemento_SPEI obj, out System.Exception exception)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LeerDesdeArchivo(string fileName, out Complemento_SPEI obj)
        {
            System.Exception exception = null;
            return LeerDesdeArchivo(fileName, out obj, out exception);
        }

        public static Complemento_SPEI LeerDesdeArchivo(string fileName)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
        }

        public new static Complemento_SPEI LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

        public static bool LeerXML(String XML,out Complemento_SPEI obj,out String Error)
        {
            Error = String.Empty;
            obj = null;
            bool Resultado = false;

            try
            {
                obj = Deserialize(XML);
                Resultado = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return Resultado;
        }
    }
}
