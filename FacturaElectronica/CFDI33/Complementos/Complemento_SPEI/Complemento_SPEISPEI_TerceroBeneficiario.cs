
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
    public partial class Complemento_SPEISPEI_TerceroBeneficiario : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _bancoReceptor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _nombre;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tipoCuenta;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _cuenta;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rFC;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _concepto;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _iVA;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _montoPago;

        private static XmlSerializer serializer;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BancoReceptor
        {
            get
            {
                return this._bancoReceptor;
            }
            set
            {
                if ((this._bancoReceptor == value))
                {
                    return;
                }
                if (((this._bancoReceptor == null)
                            || (_bancoReceptor.Equals(value) != true)))
                {
                    this._bancoReceptor = value;
                    this.OnPropertyChanged("BancoReceptor");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
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
                    this.OnPropertyChanged("Nombre");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCuenta
        {
            get
            {
                return this._tipoCuenta;
            }
            set
            {
                if ((_tipoCuenta.Equals(value) != true))
                {
                    this._tipoCuenta = value;
                    this.OnPropertyChanged("TipoCuenta");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cuenta
        {
            get
            {
                return this._cuenta;
            }
            set
            {
                if ((_cuenta.Equals(value) != true))
                {
                    this._cuenta = value;
                    this.OnPropertyChanged("Cuenta");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFC
        {
            get
            {
                return this._rFC;
            }
            set
            {
                if ((this._rFC == value))
                {
                    return;
                }
                if (((this._rFC == null)
                            || (_rFC.Equals(value) != true)))
                {
                    this._rFC = value;
                    this.OnPropertyChanged("RFC");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto
        {
            get
            {
                return this._concepto;
            }
            set
            {
                if ((this._concepto == value))
                {
                    return;
                }
                if (((this._concepto == null)
                            || (_concepto.Equals(value) != true)))
                {
                    this._concepto = value;
                    this.OnPropertyChanged("Concepto");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IVA
        {
            get
            {
                return this._iVA;
            }
            set
            {
                if ((_iVA.Equals(value) != true))
                {
                    this._iVA = value;
                    this.OnPropertyChanged("IVA");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MontoPago
        {
            get
            {
                return this._montoPago;
            }
            set
            {
                if ((_montoPago.Equals(value) != true))
                {
                    this._montoPago = value;
                    this.OnPropertyChanged("MontoPago");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(Complemento_SPEISPEI_TerceroBeneficiario));
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
        /// Serializes current Complemento_SPEISPEI_TerceroBeneficiario object into an XML string
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
        /// Deserializes workflow markup into an Complemento_SPEISPEI_TerceroBeneficiario object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Complemento_SPEISPEI_TerceroBeneficiario object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Complemento_SPEISPEI_TerceroBeneficiario obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Complemento_SPEISPEI_TerceroBeneficiario);
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

        public static bool Deserialize(string input, out Complemento_SPEISPEI_TerceroBeneficiario obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static Complemento_SPEISPEI_TerceroBeneficiario Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((Complemento_SPEISPEI_TerceroBeneficiario)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Complemento_SPEISPEI_TerceroBeneficiario Deserialize(System.IO.Stream s)
        {
            return ((Complemento_SPEISPEI_TerceroBeneficiario)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current Complemento_SPEISPEI_TerceroBeneficiario object into file
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
        /// Deserializes xml markup from file into an Complemento_SPEISPEI_TerceroBeneficiario object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Complemento_SPEISPEI_TerceroBeneficiario object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out Complemento_SPEISPEI_TerceroBeneficiario obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Complemento_SPEISPEI_TerceroBeneficiario);
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

        public static bool LeerDesdeArchivo(string fileName, out Complemento_SPEISPEI_TerceroBeneficiario obj, out System.Exception exception)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LeerDesdeArchivo(string fileName, out Complemento_SPEISPEI_TerceroBeneficiario obj)
        {
            System.Exception exception = null;
            return LeerDesdeArchivo(fileName, out obj, out exception);
        }

        public static Complemento_SPEISPEI_TerceroBeneficiario LeerDesdeArchivo(string fileName)
        {
            return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
        }

        public new static Complemento_SPEISPEI_TerceroBeneficiario LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

