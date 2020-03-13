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
    /// Nodo requerido para asentar la información detallada de una retención de impuestos aplicable al presente concepto.
    /// </summary>
    [System.SerializableAttribute()]
    
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoImpuestosRetencion : System.ComponentModel.INotifyPropertyChanged
    {

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _base;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Impuesto _impuesto;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TipoFactor _tipoFactor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tasaOCuota;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _importe;

        private static XmlSerializer serializer;
        #endregion

        /// <summary>
        /// Atributo requerido para señalar la base para el cálculo de la retención, la determinación de la base se realiza de acuerdo con las disposiciones fiscales vigentes. No se permiten valores negativos.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        public decimal Base
        {
            get
            {
                return this._base;
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

                if ((_base.Equals(value) != true))
                {
                    this._base = value;
                    this.OnPropertyChanged("TipoCambio");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto retenido aplicable al concepto.
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
        /// Atributo requerido para señalar la tasa o cuota del impuesto que se retiene para el presente concepto.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "TasaOCuota")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        public String sTasaOCuota
        {
            get
            {
                string decimales = "000000";
                string[] val = _tasaOCuota.ToString().Split('.');
                if (val.Length == 2)
                {
                    if (val[1].Length < 6)
                    {
                        decimales = val[1] + "000000".Substring(0, 6 - val[1].Length);
                    }
                    else
                    {
                        if (val[1].Length == 6)
                            decimales = val[1];
                        else
                            decimales = val[1].Substring(0, 6);
                    }
                }

                return val[0] + "." + decimales;

            }
            set
            {
                _tasaOCuota = System.Convert.ToDecimal(value);
            }
        }


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
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(FacturaElectronica.CFDI33.ComprobanteConceptoImpuestosRetencion));
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
        /// Serializes current ComprobanteConceptoImpuestosRetencion object into an XML string
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
        /// Deserializes workflow markup into an ComprobanteConceptoImpuestosRetencion object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output ComprobanteConceptoImpuestosRetencion object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out ComprobanteConceptoImpuestosRetencion obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteConceptoImpuestosRetencion);
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

        public static bool Deserialize(string input, out ComprobanteConceptoImpuestosRetencion obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static ComprobanteConceptoImpuestosRetencion Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((ComprobanteConceptoImpuestosRetencion)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static ComprobanteConceptoImpuestosRetencion Deserialize(System.IO.Stream s)
        {
            return ((ComprobanteConceptoImpuestosRetencion)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current ComprobanteConceptoImpuestosRetencion object into file
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
        /// Deserializes xml markup from file into an ComprobanteConceptoImpuestosRetencion object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ComprobanteConceptoImpuestosRetencion object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ComprobanteConceptoImpuestosRetencion obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ComprobanteConceptoImpuestosRetencion);
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

        public static bool LoadFromFile(string fileName, out ComprobanteConceptoImpuestosRetencion obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out ComprobanteConceptoImpuestosRetencion obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ComprobanteConceptoImpuestosRetencion LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static ComprobanteConceptoImpuestosRetencion LoadFromFile(string fileName, System.Text.Encoding encoding)
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
