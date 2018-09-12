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
    /// Nodo condicional para expresar la lista de documentos relacionados con los pagos diferentes de anticipos. Por cada documento que se relacione se debe generar un nodo DoctoRelacionado.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoDoctoRelacionado : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _idDocumento;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _serie;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _folio;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Moneda _monedaDR;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tipoCambioDR;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_MetodoPago _metodoDePagoDR;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _numParcialidad;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _impSaldoAnt;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _impPagado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _impSaldoInsoluto;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Atributo requerido para expresar el identificador del documento relacionado con el pago. Este dato puede ser un Folio Fiscal de la Factura Electrónica o bien el número de operación de un documento digital.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(36, MinimumLength = 16)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([a-f0-9A-F]{8}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{12})|([0-9]{3}-[0-9]{2}-[0-9]{9})")]
        public string IdDocumento
        {
            get
            {
                return this._idDocumento;
            }
            set
            {
                if ((this._idDocumento == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(16, 36, "IdDocumento", value, out Error))
                    throw new Exception(Error);
                if (((this._idDocumento == null)
                     || (_idDocumento.Equals(value) != true)))
                {
                    this._idDocumento = value;
                    this.OnPropertyChanged("IdDocumento");
                }
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la serie del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(25, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,25}")]
        public string Serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                if ((this._serie == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 25, "Serie", value, out Error))
                    throw new Exception(Error);
                if (((this._serie == null)
                     || (_serie.Equals(value) != true)))
                {
                    this._serie = value;
                    this.OnPropertyChanged("Serie");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerieSpecified { get; set; }

        /// <summary>
        /// Atributo opcional para precisar el folio del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(40, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,40}")]
        public string Folio
        {
            get
            {
                return this._folio;
            }
            set
            {
                if ((this._folio == value))
                {
                    return;
                }
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 40, "Folio", value, out Error))
                    throw new Exception(Error);
                FolioSpecified = true;
                if (((this._folio == null)
                     || (_folio.Equals(value) != true)))
                {
                    this._folio = value;
                    this.OnPropertyChanged("Folio");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolioSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada en los importes del documento relacionado, cuando se usa moneda nacional o el documento relacionado no especifica la moneda se registra MXN. Los importes registrados en los atributos “ImpSaldoAnt”, “ImpPagado” e “ImpSaldoInsoluto” de éste nodo, deben corresponder a esta moneda. Conforme con la especificación ISO 4217.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Moneda MonedaDR
        {
            get
            {
                return this._monedaDR;
            }
            set
            {
                if ((_monedaDR.Equals(value) != true))
                {
                    this._monedaDR = value;
                    this.OnPropertyChanged("MonedaDR");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el tipo de cambio conforme con la moneda registrada en el documento relacionado. Es requerido cuando la moneda del documento relacionado es distinta de la moneda de pago. Se debe registrar el número de unidades de la moneda señalada en el documento relacionado que equivalen a una unidad de la moneda del pago. Por ejemplo: El documento relacionado se registra en USD El pago se realiza por 100 EUR. Este atributo se registra como 1.114700 USD/EUR. El importe pagado equivale a 100 EUR * 1.114700 USD/EUR = 111.47 USD.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambioDR
        {
            get
            {
                return this._tipoCambioDR;
            }
            set
            {
                TipoCambioDRSpecified = true;
                if ((_tipoCambioDR.Equals(value) != true))
                {
                    this._tipoCambioDR = value;
                    this.OnPropertyChanged("TipoCambioDR");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioDRSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para expresar la clave del método de pago que se registró en el documento relacionado.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_MetodoPago MetodoDePagoDR
        {
            get
            {
                return this._metodoDePagoDR;
            }
            set
            {
                if ((_metodoDePagoDR.Equals(value) != true))
                {
                    this._metodoDePagoDR = value;
                    this.OnPropertyChanged("MetodoDePagoDR");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de parcialidad que corresponde al pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[1-9][0-9]{0,2}")]
        public string NumParcialidad
        {
            get
            {
                return this._numParcialidad;
            }
            set
            {
                if ((this._numParcialidad == value))
                {
                    return;
                }
                NumParcialidadSpecified = true;
                if (((this._numParcialidad == null)
                     || (_numParcialidad.Equals(value) != true)))
                {
                    this._numParcialidad = value;
                    this.OnPropertyChanged("NumParcialidad");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumParcialidadSpecified { get; set; }

        
        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "ImpSaldoAnt")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strImpSaldoAnt
        {
            get
            {
                if (ImpSaldoAnt != null)
                {
                    strImpSaldoAntSpecified = true;
                    return ImpSaldoAnt.strImporte;
                }
                else
                    return String.Empty;
            }
            set
            {
                if (ImpSaldoAnt == null)
                    ImpSaldoAnt = new t_Importe(value);
                strImpSaldoAntSpecified = true;
                if ((ImpSaldoAnt.strImporte.Equals(value) != true))
                {
                    this.ImpSaldoAnt.strImporte = value;
                    this.OnPropertyChanged("ImpSaldoAnt");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strImpSaldoAntSpecified { get; set; }
        

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "ImpPagado")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strImpPagado
        {
            get
            {
                if (ImpPagado != null)
                {
                    strImpPagadoSpecified = true;
                    return ImpPagado.strImporte;
                }
                else
                    return String.Empty;
            }
            set
            {
                if (ImpPagado == null)
                    ImpPagado = new t_Importe(value);
                strImpPagadoSpecified = true;
                if ((ImpPagado.strImporte.Equals(value) != true))
                {
                    this.ImpPagado.strImporte = value;
                    this.OnPropertyChanged("ImpPagado");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strImpPagadoSpecified { get; set; }

        

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "ImpSaldoInsoluto")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strImpSaldoInsoluto
        {
            get
            {
                if (ImpSaldoInsoluto != null)
                {
                    strImpSaldoInsolutoSpecified = true;
                    return ImpSaldoInsoluto.strImporte;
                }
                else
                    return String.Empty;
            }
            set
            {
                if (ImpSaldoInsoluto == null)
                    ImpSaldoInsoluto = new t_Importe(value);
                strImpSaldoInsolutoSpecified = true;
                if ((ImpSaldoInsoluto.strImporte.Equals(value) != true))
                {
                    this.ImpSaldoInsoluto.strImporte = value;
                    this.OnPropertyChanged("ImpSaldoInsoluto");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strImpSaldoInsolutoSpecified { get; set; }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PagosPagoDoctoRelacionado));
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
        /// Serializes current PagosPagoDoctoRelacionado object into an XML string
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
        /// Deserializes workflow markup into an PagosPagoDoctoRelacionado object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PagosPagoDoctoRelacionado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PagosPagoDoctoRelacionado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPagoDoctoRelacionado);
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

        public static bool Deserialize(string input, out PagosPagoDoctoRelacionado obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static PagosPagoDoctoRelacionado Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PagosPagoDoctoRelacionado)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static PagosPagoDoctoRelacionado Deserialize(System.IO.Stream s)
        {
            return ((PagosPagoDoctoRelacionado)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current PagosPagoDoctoRelacionado object into file
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
        /// Deserializes xml markup from file into an PagosPagoDoctoRelacionado object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PagosPagoDoctoRelacionado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PagosPagoDoctoRelacionado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPagoDoctoRelacionado);
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

        public static bool LoadFromFile(string fileName, out PagosPagoDoctoRelacionado obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out PagosPagoDoctoRelacionado obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PagosPagoDoctoRelacionado LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static PagosPagoDoctoRelacionado LoadFromFile(string fileName, System.Text.Encoding encoding)
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
