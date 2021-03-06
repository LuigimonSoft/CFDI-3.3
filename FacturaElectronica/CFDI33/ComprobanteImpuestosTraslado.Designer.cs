﻿using System;
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
    /// Nodo requerido para asentar la información detallada de un traslado de impuestos aplicable al presente concepto.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteImpuestosTraslado : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Impuesto _impuesto;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TipoFactor _tipoFactor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TasaOCuota _tasaOCuota;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private t_Importe _importe;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto trasladado aplicable al concepto.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Impuesto Impuesto
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
                    this.OnPropertyChanged("Impuesto");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoFactor TipoFactor
        {
            get
            {
                return this._tipoFactor;
            }
            set
            {
                if ((_tipoFactor.Equals(value) != true))
                {
                    this._tipoFactor = value;
                    this.OnPropertyChanged("TipoFactor");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada para el presente concepto. Es requerido cuando el atributo TipoFactor tenga una clave que corresponda a Tasa o Cuota.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TasaOCuota TasaOCuota
        {
            get
            {
                return this._tasaOCuota;
            }
            set
            {
                if ((_tasaOCuota.Equals(value) != true))
                {
                    this._tasaOCuota = value;
                    if (TipoFactor != c_TipoFactor.Exento)
                    {
                        sTasaOCuotaSpecified = true;
                        TasaOCuotaSpecified = true;
                    }
                    this.OnPropertyChanged("TasaOCuota");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sTasaOCuotaSpecified { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "Importe")]
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
                    Importe = new t_Importe("0.01");

                if ((Importe.strImporte.Equals(value) != true))
                {
                    this.Importe.strImporte = value;
                    if (TipoFactor != c_TipoFactor.Exento)
                    {
                        sImporteSpecified = true;
                        ImporteSpecified = true;
                    }
                    this.OnPropertyChanged("Importe");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sImporteSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified { get; set; }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(FacturaElectronica.CFDI33.ComprobanteImpuestosTraslado));
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
        /// Serializes current ComprobanteImpuestosTraslado object into an XML string
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
        /// Deserializes workflow markup into an ComprobanteImpuestosTraslado object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ComprobanteImpuestosTraslado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ComprobanteImpuestosTraslado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteImpuestosTraslado);
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

        public static bool Deserialize(string input, out ComprobanteImpuestosTraslado obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static ComprobanteImpuestosTraslado Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ComprobanteImpuestosTraslado)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ComprobanteImpuestosTraslado Deserialize(System.IO.Stream s)
        {
            return ((ComprobanteImpuestosTraslado)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current ComprobanteImpuestosTraslado object into file
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
        /// Deserializes xml markup from file into an ComprobanteImpuestosTraslado object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ComprobanteImpuestosTraslado object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ComprobanteImpuestosTraslado obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteImpuestosTraslado);
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

        public static bool LoadFromFile(string fileName, out ComprobanteImpuestosTraslado obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out ComprobanteImpuestosTraslado obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ComprobanteImpuestosTraslado LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static ComprobanteImpuestosTraslado LoadFromFile(string fileName, System.Text.Encoding encoding)
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
