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

namespace FacturaElectronica.CFDI33
{
    /// <summary>
    /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteReceptor : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _rfc;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _nombre;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Pais _residenciaFiscal;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numRegIdTrib;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_UsoCFDI _usoCFDI;

        private static XmlSerializer serializer;
        #endregion

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "Rfc")]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(13, MinimumLength = 12)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z&amp;Ñ]{3,4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strRfc
        {
            get
            {
                return VerificadorPatrones.RemplazarCaracteresEspeciales(Rfc.Rfc);
            }
            set
            {
                String Valor = VerificadorPatrones.LimpiarCaracteresEspeciales(value);
                if (Rfc == null)
                    Rfc = new t_RFC(Valor);

                if ((Rfc.Rfc == Valor))
                {
                    return;
                }
                if (((Rfc.Rfc == null) || (Rfc.Rfc.Equals(Valor) != true)))
                {
                    Rfc.Rfc = Valor;
                    this.OnPropertyChanged("Rfc");
                }
            }
        }

        /// <summary>
        /// Atributo opcional para precisar el nombre, denominación o razón social del contribuyente receptor del comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(254, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,254}")]
        public string Nombre
        {
            get
            {
                return VerificadorPatrones.RemplazarCaracteresEspeciales(this._nombre);
            }
            set
            {
                String Error = String.Empty;
                String Valor = VerificadorPatrones.LimpiarCaracteresEspeciales(value);
                if (!Comprobante.VerificarLongitud(1, 254, "Nombre", Valor, out Error))
                    throw new Exception(Error);
               if(!VerificadorPatrones.VerificarPatronSinPunto(VerificadorPatrones.RemplazarCaracteresEspeciales(Valor)))
                    throw new Exception("El patron del nombre del receptor es incorrecto");

                if ((this._nombre == Valor))
                {
                    return;
                }
                if (((this._nombre == null) || (_nombre.Equals(Valor) != true)))
                {
                    this._nombre = Valor;
                    NombreSpecified = true;
                    this.OnPropertyChanged("Nombre");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreSpecified { get; set; }
        /// <summary>
        /// Atributo condicional para registrar la clave del país de residencia para efectos fiscales del receptor del comprobante, cuando se trate de un extranjero, y que es conforme con la especificación ISO 3166-1 alpha-3. Es requerido cuando se incluya el complemento de comercio exterior o se registre el atributo NumRegIdTrib.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Pais ResidenciaFiscal
        {
            get
            {
                return  this._residenciaFiscal;
            }
            set
            {
                if ((_residenciaFiscal.Equals(value) != true))
                {
                    this._residenciaFiscal = value;
                    ResidenciaFiscalSpecified = true;
                    this.OnPropertyChanged("ResidenciaFiscal");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para expresar el número de registro de identidad fiscal del receptor cuando sea residente en el  extranjero. Es requerido cuando se incluya el complemento de comercio exterior.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(40, MinimumLength = 1)]
        public string NumRegIdTrib
        {
            get
            {
                return this._numRegIdTrib;
            }
            set
            {
                String Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 40, "NumRegIdTrib", value, out Error))
                    throw new Exception(Error);

                if ((this._numRegIdTrib == value))
                {
                    return;
                }
                if (((this._numRegIdTrib == null) || (_numRegIdTrib.Equals(value) != true)))
                {
                    this._numRegIdTrib = value;
                    NumRegIdTribSpecified = true;
                    this.OnPropertyChanged("NumRegIdTrib");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumRegIdTribSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para expresar la clave del uso que dará a esta factura el receptor del CFDI.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_UsoCFDI UsoCFDI
        {
            get
            {
                return this._usoCFDI;
            }
            set
            {
                if ((_usoCFDI.Equals(value) != true))
                {
                    this._usoCFDI = value;
                    this.OnPropertyChanged("UsoCFDI");
                }
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(FacturaElectronica.CFDI33.ComprobanteReceptor));
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
        /// Serializes current ComprobanteReceptor object into an XML string
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
        /// Deserializes workflow markup into an ComprobanteReceptor object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ComprobanteReceptor object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ComprobanteReceptor obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteReceptor);
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

        public static bool Deserialize(string input, out ComprobanteReceptor obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static ComprobanteReceptor Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ComprobanteReceptor)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ComprobanteReceptor Deserialize(System.IO.Stream s)
        {
            return ((ComprobanteReceptor)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current ComprobanteReceptor object into file
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
        /// Deserializes xml markup from file into an ComprobanteReceptor object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ComprobanteReceptor object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ComprobanteReceptor obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteReceptor);
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

        public static bool LoadFromFile(string fileName, out ComprobanteReceptor obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out ComprobanteReceptor obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ComprobanteReceptor LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static ComprobanteReceptor LoadFromFile(string fileName, System.Text.Encoding encoding)
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
