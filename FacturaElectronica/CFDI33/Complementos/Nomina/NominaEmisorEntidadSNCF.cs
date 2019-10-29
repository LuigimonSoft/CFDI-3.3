
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
/// Nodo condicional para que las entidades adheridas al Sistema Nacional de Coordinación Fiscal realicen la identificación del origen de los recursos utilizados en el pago de nómina del personal que presta o desempeña un servicio personal subordinado en las dependencias de la entidad federativa, del municipio o demarcación territorial de la Ciudad de México, así como en sus respectivos organismos autónomos y entidades paraestatales y paramunicipales
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaEmisorEntidadSNCF : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_OrigenRecurso _origenRecurso;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _montoRecursoPropio;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Atributo requerido para identificar el origen del recurso utilizado para el pago de nómina del personal que presta o desempeña un servicio personal subordinado o asimilado a salarios en las dependencias.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_OrigenRecurso OrigenRecurso
    {
        get
        {
            return this._origenRecurso;
        }
        set
        {
            if ((_origenRecurso.Equals(value) != true))
            {
                this._origenRecurso = value;
                this.OnPropertyChanged("OrigenRecurso");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el monto del recurso pagado con cargo a sus participaciones u otros ingresos locales (importe bruto de los ingresos propios, es decir total de gravados y exentos), cuando el origen es mixto.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal MontoRecursoPropio
    {
        get
        {
            return this._montoRecursoPropio;
        }
        set
        {
            if ((_montoRecursoPropio.Equals(value) != true))
            {
                this._montoRecursoPropio = value;
                this.OnPropertyChanged("MontoRecursoPropio");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaEmisorEntidadSNCF));
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
    /// Serializes current NominaEmisorEntidadSNCF object into an XML string
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
    /// Deserializes workflow markup into an NominaEmisorEntidadSNCF object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaEmisorEntidadSNCF object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaEmisorEntidadSNCF obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaEmisorEntidadSNCF);
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
    
    public static bool Deserialize(string input, out NominaEmisorEntidadSNCF obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaEmisorEntidadSNCF Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaEmisorEntidadSNCF)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaEmisorEntidadSNCF Deserialize(System.IO.Stream s)
    {
        return ((NominaEmisorEntidadSNCF)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaEmisorEntidadSNCF object into file
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
    /// Deserializes xml markup from file into an NominaEmisorEntidadSNCF object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaEmisorEntidadSNCF object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaEmisorEntidadSNCF obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaEmisorEntidadSNCF);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaEmisorEntidadSNCF obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaEmisorEntidadSNCF obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaEmisorEntidadSNCF LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaEmisorEntidadSNCF LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

