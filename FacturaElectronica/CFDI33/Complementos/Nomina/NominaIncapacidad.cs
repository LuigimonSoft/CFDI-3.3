
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
/// Nodo requerido para expresar información de las incapacidades.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaIncapacidad : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private int _diasIncapacidad;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoIncapacidad _tipoIncapacidad;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _importeMonetario;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Atributo requerido para expresar el número de días enteros que el trabajador se incapacitó en el periodo.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int DiasIncapacidad
    {
        get
        {
            return this._diasIncapacidad;
        }
        set
        {
            if ((_diasIncapacidad.Equals(value) != true))
            {
                this._diasIncapacidad = value;
                this.OnPropertyChanged("DiasIncapacidad");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la razón de la incapacidad.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoIncapacidad TipoIncapacidad
    {
        get
        {
            return this._tipoIncapacidad;
        }
        set
        {
            if ((_tipoIncapacidad.Equals(value) != true))
            {
                this._tipoIncapacidad = value;
                this.OnPropertyChanged("TipoIncapacidad");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el monto del importe monetario de la incapacidad.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteMonetario
    {
        get
        {
            return this._importeMonetario;
        }
        set
        {
            if ((_importeMonetario.Equals(value) != true))
            {
                this._importeMonetario = value;
                this.OnPropertyChanged("ImporteMonetario");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaIncapacidad));
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
    /// Serializes current NominaIncapacidad object into an XML string
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
    /// Deserializes workflow markup into an NominaIncapacidad object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaIncapacidad object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaIncapacidad obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaIncapacidad);
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
    
    public static bool Deserialize(string input, out NominaIncapacidad obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaIncapacidad Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaIncapacidad)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaIncapacidad Deserialize(System.IO.Stream s)
    {
        return ((NominaIncapacidad)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaIncapacidad object into file
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
    /// Deserializes xml markup from file into an NominaIncapacidad object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaIncapacidad object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaIncapacidad obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaIncapacidad);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaIncapacidad obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaIncapacidad obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaIncapacidad LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaIncapacidad LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

