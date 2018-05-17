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
    /// Nodo opcional para expresar las partes o componentes que integran la totalidad del concepto expresado en el comprobante fiscal digital por Internet.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoParte : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<ComprobanteConceptoParteInformacionAduanera> _informacionAduanera;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _claveProdServ;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noIdentificacion;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _cantidad;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _unidad;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _descripcion;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _valorUnitario;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas o se trate de operaciones de comercio exterior con bienes o servicios.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", Order = 0)]
        public List<ComprobanteConceptoParteInformacionAduanera> InformacionAduanera
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
        /// Atributo requerido para expresar la clave del producto o del servicio amparado por la presente parte. Es requerido y deben utilizar las claves del catálogo de productos y servicios, cuando los conceptos que registren por sus actividades correspondan con dichos conceptos.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{8}")]
        public string ClaveProdServ
        {
            get
            {
                return this._claveProdServ;
            }
            set
            {
                if ((this._claveProdServ == value))
                {
                    return;
                }
                if (((this._claveProdServ == null)
                            || (_claveProdServ.Equals(value) != true)))
                {
                    this._claveProdServ = value;
                    this.OnPropertyChanged("ClaveProdServ");
                }
            }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de serie, número de parte del bien o identificador del producto o del servicio amparado por la presente parte. Opcionalmente se puede utilizar claves del estándar GTIN.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(100, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,100}")]
        public string NoIdentificacion
        {
            get
            {
                return this._noIdentificacion;
            }
            set
            {
                string Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 100, "NoIdentificacion", value, out Error))
                    throw new Exception(Error);

                if ((this._noIdentificacion == value))
                {
                    return;
                }
                if (((this._noIdentificacion == null)
                            || (_noIdentificacion.Equals(value) != true)))
                {
                    this._noIdentificacion = value;
                    this.OnPropertyChanged("NoIdentificacion");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        public decimal Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                if (value < System.Convert.ToDecimal(0.000001))
                    throw new ArgumentException("El valor minimo permitido es 0.000001 ");
                String[] partes = value.ToString().Split('.');
                if (partes.Length > 1)
                {
                    int Parte1 = System.Convert.ToInt32(partes[0]);
                    decimal valorprueba = (value - Parte1);
                    if (valorprueba < System.Convert.ToDecimal(0.000001) && valorprueba != 0)
                        throw new ArgumentException("El numero de decimales maximo es de 6");
                }

                if ((_cantidad.Equals(value) != true))
                {
                    this._cantidad = value;
                    this.OnPropertyChanged("Cantidad");
                }
            }

        }

        /// <summary>
        /// Atributo opcional para precisar la unidad de medida propia de la operación del emisor, aplicable para la cantidad expresada en la parte. La unidad debe corresponder con la descripción de la parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(20, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,20}")]
        public string Unidad
        {
            get
            {
                return this._unidad;
            }
            set
            {
                String Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 20, "Unidad", value, out Error))
                    throw new Exception(Error);

                if ((this._unidad == value))
                {
                    return;
                }
                if (((this._unidad == null)
                            || (_unidad.Equals(value) != true)))
                {
                    this._unidad = value;
                    this.OnPropertyChanged("Unidad");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por la presente parte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(1000, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,1000}")]
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                String Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 1000, "Descripcion", value, out Error))
                    throw new Exception(Error);

                if ((this._descripcion == value))
                {
                    return;
                }
                if (((this._descripcion == null)
                            || (_descripcion.Equals(value) != true)))
                {
                    this._descripcion = value;
                    this.OnPropertyChanged("Descripcion");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName= "ValorUnitario")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string sValorUnitario
        {
            get
            {
                return ValorUnitario.strImporte;
            }
            set
            {
                if (ValorUnitario == null)
                    ValorUnitario = new t_Importe("0.000001");

                if ((ValorUnitario.strImporte.Equals(value) != true))
                {
                    this.ValorUnitario.strImporte = value;
                    this.OnPropertyChanged("ValorUnitario");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="Importe")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string sImporte
        {
            get
            {
                return Importe.strImporte;
            }
            set
            {
                if (Importe == null)
                    Importe = new t_Importe("0.000001");

                if ((Importe.strImporte.Equals(value) != true))
                {
                    this.Importe.strImporte = value;
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
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(FacturaElectronica.CFDI33.ComprobanteConceptoParte));
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
        /// Serializes current ComprobanteConceptoParte object into an XML string
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
        /// Deserializes workflow markup into an ComprobanteConceptoParte object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ComprobanteConceptoParte object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ComprobanteConceptoParte obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteConceptoParte);
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

        public static bool Deserialize(string input, out ComprobanteConceptoParte obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static ComprobanteConceptoParte Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ComprobanteConceptoParte)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ComprobanteConceptoParte Deserialize(System.IO.Stream s)
        {
            return ((ComprobanteConceptoParte)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current ComprobanteConceptoParte object into file
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
        /// Deserializes xml markup from file into an ComprobanteConceptoParte object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ComprobanteConceptoParte object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ComprobanteConceptoParte obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteConceptoParte);
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

        public static bool LoadFromFile(string fileName, out ComprobanteConceptoParte obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out ComprobanteConceptoParte obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ComprobanteConceptoParte LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static ComprobanteConceptoParte LoadFromFile(string fileName, System.Text.Encoding encoding)
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
