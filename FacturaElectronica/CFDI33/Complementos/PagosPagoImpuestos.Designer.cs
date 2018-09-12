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
    /// Nodo condicional para expresar el resumen de los impuestos aplicables cuando este documento sea un anticipo.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoImpuestos : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PagosPagoImpuestosRetencion> _retenciones;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PagosPagoImpuestosTraslado> _traslados;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totalImpuestosRetenidos;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _totalImpuestosTrasladados;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Nodo condicional para capturar los impuestos retenidos aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public List<PagosPagoImpuestosRetencion> Retenciones
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
        /// Nodo condicional para capturar los impuestos trasladados aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public List<PagosPagoImpuestosTraslado> Traslados
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "TotalImpuestosRetenidos")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strTotalImpuestosRetenidos
        {
            get
            {
                if (TotalImpuestosRetenidos != null)
                    return TotalImpuestosRetenidos.strImporte;
                else
                    return String.Empty;
            }
            set
            {
                if (TotalImpuestosRetenidos == null)
                    TotalImpuestosRetenidos = new t_Importe(value);
                strTotalImpuestosRetenidosSpecified = true;
                if ((TotalImpuestosRetenidos.strImporte.Equals(value) != true))
                {
                    this.TotalImpuestosRetenidos.strImporte = value;
                    this.OnPropertyChanged("TotalImpuestosRetenidos");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strTotalImpuestosRetenidosSpecified { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "TotalImpuestosTrasladados")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strTotalImpuestosTrasladados
        {
            get
            {
                if (TotalImpuestosTrasladados != null)
                    return TotalImpuestosTrasladados.strImporte;
                else
                    return String.Empty;
            }
            set
            {
                if (TotalImpuestosTrasladados == null)
                    TotalImpuestosTrasladados = new t_Importe(value);
                strTotalImpuestosTrasladadosSpecified = true;
                if ((TotalImpuestosTrasladados.strImporte.Equals(value) != true))
                {
                    this.TotalImpuestosTrasladados.strImporte = value;
                    this.OnPropertyChanged("TotalImpuestosTrasladados");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strTotalImpuestosTrasladadosSpecified { get; set; }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(PagosPagoImpuestos));
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
        /// Serializes current PagosPagoImpuestos object into an XML string
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
        /// Deserializes workflow markup into an PagosPagoImpuestos object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output PagosPagoImpuestos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out PagosPagoImpuestos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPagoImpuestos);
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

        public static bool Deserialize(string input, out PagosPagoImpuestos obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static PagosPagoImpuestos Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((PagosPagoImpuestos)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static PagosPagoImpuestos Deserialize(System.IO.Stream s)
        {
            return ((PagosPagoImpuestos)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current PagosPagoImpuestos object into file
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
        /// Deserializes xml markup from file into an PagosPagoImpuestos object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PagosPagoImpuestos object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out PagosPagoImpuestos obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PagosPagoImpuestos);
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

        public static bool LoadFromFile(string fileName, out PagosPagoImpuestos obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out PagosPagoImpuestos obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PagosPagoImpuestos LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static PagosPagoImpuestos LoadFromFile(string fileName, System.Text.Encoding encoding)
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
