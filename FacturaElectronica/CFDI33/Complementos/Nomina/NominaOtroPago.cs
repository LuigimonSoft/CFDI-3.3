
namespace FacturaElectronica.CFDI33.Complementos.Nomina12
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
/// Nodo requerido para expresar la información detallada del otro pago.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaOtroPago : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaOtroPagoSubsidioAlEmpleo _subsidioAlEmpleo;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaOtroPagoCompensacionSaldosAFavor _compensacionSaldosAFavor;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoOtroPago _tipoOtroPago;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _clave;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _concepto;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _importe;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Nodo requerido para expresar la información referente al subsidio al empleo del trabajador.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public NominaOtroPagoSubsidioAlEmpleo SubsidioAlEmpleo
    {
        get
        {
            return this._subsidioAlEmpleo;
        }
        set
        {
            if ((this._subsidioAlEmpleo == value))
            {
                return;
            }
            if (((this._subsidioAlEmpleo == null) 
                        || (_subsidioAlEmpleo.Equals(value) != true)))
            {
                this._subsidioAlEmpleo = value;
                this.OnPropertyChanged("SubsidioAlEmpleo");
            }
        }
    }
    
    /// <summary>
    /// Nodo condicional para expresar la información referente a la compensación de saldos a favor de un trabajador.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NominaOtroPagoCompensacionSaldosAFavor CompensacionSaldosAFavor
    {
        get
        {
            return this._compensacionSaldosAFavor;
        }
        set
        {
            if ((this._compensacionSaldosAFavor == value))
            {
                return;
            }
            if (((this._compensacionSaldosAFavor == null) 
                        || (_compensacionSaldosAFavor.Equals(value) != true)))
            {
                this._compensacionSaldosAFavor = value;
                this.OnPropertyChanged("CompensacionSaldosAFavor");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la clave agrupadora bajo la cual se clasifica el otro pago.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoOtroPago TipoOtroPago
    {
        get
        {
            return this._tipoOtroPago;
        }
        set
        {
            if ((_tipoOtroPago.Equals(value) != true))
            {
                this._tipoOtroPago = value;
                this.OnPropertyChanged("TipoOtroPago");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido, representa la clave de otro pago de nómina propia de la contabilidad de cada patrón, puede conformarse desde 3 hasta 15 caracteres.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(15, MinimumLength=3)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{3,15}")]
    public string Clave
    {
        get
        {
            return this._clave;
        }
        set
        {
            if ((this._clave == value))
            {
                return;
            }
            if (((this._clave == null) 
                        || (_clave.Equals(value) != true)))
            {
                this._clave = value;
                this.OnPropertyChanged("Clave");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para la descripción del concepto de otro pago.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(100, MinimumLength=1)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,100}")]
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
    
    /// <summary>
    /// Atributo requerido para expresar el importe del concepto de otro pago.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe
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
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaOtroPago));
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
    /// Serializes current NominaOtroPago object into an XML string
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
    /// Deserializes workflow markup into an NominaOtroPago object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaOtroPago object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaOtroPago obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaOtroPago);
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
    
    public static bool Deserialize(string input, out NominaOtroPago obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaOtroPago Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaOtroPago)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaOtroPago Deserialize(System.IO.Stream s)
    {
        return ((NominaOtroPago)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaOtroPago object into file
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
    /// Deserializes xml markup from file into an NominaOtroPago object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaOtroPago object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaOtroPago obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaOtroPago);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaOtroPago obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaOtroPago obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaOtroPago LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaOtroPago LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

