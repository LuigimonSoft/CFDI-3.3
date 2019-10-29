
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
/// Nodo condicional para expresar las horas extra aplicables.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaPercepcionesPercepcionHorasExtra : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private int _dias;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoHoras _tipoHoras;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private int _horasExtra;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _importePagado;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Atributo requerido para expresar el número de días en que el trabajador realizó horas extra en el periodo.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int Dias
    {
        get
        {
            return this._dias;
        }
        set
        {
            if ((_dias.Equals(value) != true))
            {
                this._dias = value;
                this.OnPropertyChanged("Dias");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el tipo de pago de las horas extra.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoHoras TipoHoras
    {
        get
        {
            return this._tipoHoras;
        }
        set
        {
            if ((_tipoHoras.Equals(value) != true))
            {
                this._tipoHoras = value;
                this.OnPropertyChanged("TipoHoras");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el número de horas extra trabajadas en el periodo.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int HorasExtra
    {
        get
        {
            return this._horasExtra;
        }
        set
        {
            if ((_horasExtra.Equals(value) != true))
            {
                this._horasExtra = value;
                this.OnPropertyChanged("HorasExtra");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el importe pagado por las horas extra.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImportePagado
    {
        get
        {
            return this._importePagado;
        }
        set
        {
            if ((_importePagado.Equals(value) != true))
            {
                this._importePagado = value;
                this.OnPropertyChanged("ImportePagado");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaPercepcionesPercepcionHorasExtra));
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
    /// Serializes current NominaPercepcionesPercepcionHorasExtra object into an XML string
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
    /// Deserializes workflow markup into an NominaPercepcionesPercepcionHorasExtra object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaPercepcionesPercepcionHorasExtra object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaPercepcionesPercepcionHorasExtra obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesPercepcionHorasExtra);
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
    
    public static bool Deserialize(string input, out NominaPercepcionesPercepcionHorasExtra obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaPercepcionesPercepcionHorasExtra Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaPercepcionesPercepcionHorasExtra)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaPercepcionesPercepcionHorasExtra Deserialize(System.IO.Stream s)
    {
        return ((NominaPercepcionesPercepcionHorasExtra)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaPercepcionesPercepcionHorasExtra object into file
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
    /// Deserializes xml markup from file into an NominaPercepcionesPercepcionHorasExtra object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaPercepcionesPercepcionHorasExtra object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaPercepcionesPercepcionHorasExtra obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesPercepcionHorasExtra);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesPercepcionHorasExtra obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesPercepcionHorasExtra obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaPercepcionesPercepcionHorasExtra LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaPercepcionesPercepcionHorasExtra LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

