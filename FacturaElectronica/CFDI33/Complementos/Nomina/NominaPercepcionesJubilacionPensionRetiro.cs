
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
/// Nodo condicional para expresar la información detallada de pagos por jubilación, pensiones o haberes de retiro.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaPercepcionesJubilacionPensionRetiro : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalUnaExhibicion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalParcialidad;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _montoDiario;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _ingresoAcumulable;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _ingresoNoAcumulable;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Atributo condicional que indica el monto total del pago cuando se realiza en una sola exhibición.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalUnaExhibicion
    {
        get
        {
            return this._totalUnaExhibicion;
        }
        set
        {
            if ((_totalUnaExhibicion.Equals(value) != true))
            {
                this._totalUnaExhibicion = value;
                this.OnPropertyChanged("TotalUnaExhibicion");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar los ingresos totales por pago cuando se hace en parcialidades.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalParcialidad
    {
        get
        {
            return this._totalParcialidad;
        }
        set
        {
            if ((_totalParcialidad.Equals(value) != true))
            {
                this._totalParcialidad = value;
                this.OnPropertyChanged("TotalParcialidad");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el monto diario percibido por jubilación, pensiones o haberes de retiro cuando se realiza en parcialidades.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal MontoDiario
    {
        get
        {
            return this._montoDiario;
        }
        set
        {
            if ((_montoDiario.Equals(value) != true))
            {
                this._montoDiario = value;
                this.OnPropertyChanged("MontoDiario");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar los ingresos acumulables.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal IngresoAcumulable
    {
        get
        {
            return this._ingresoAcumulable;
        }
        set
        {
            if ((_ingresoAcumulable.Equals(value) != true))
            {
                this._ingresoAcumulable = value;
                this.OnPropertyChanged("IngresoAcumulable");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar los ingresos no acumulables.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal IngresoNoAcumulable
    {
        get
        {
            return this._ingresoNoAcumulable;
        }
        set
        {
            if ((_ingresoNoAcumulable.Equals(value) != true))
            {
                this._ingresoNoAcumulable = value;
                this.OnPropertyChanged("IngresoNoAcumulable");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaPercepcionesJubilacionPensionRetiro));
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
    /// Serializes current NominaPercepcionesJubilacionPensionRetiro object into an XML string
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
    /// Deserializes workflow markup into an NominaPercepcionesJubilacionPensionRetiro object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaPercepcionesJubilacionPensionRetiro object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaPercepcionesJubilacionPensionRetiro obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesJubilacionPensionRetiro);
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
    
    public static bool Deserialize(string input, out NominaPercepcionesJubilacionPensionRetiro obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaPercepcionesJubilacionPensionRetiro Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaPercepcionesJubilacionPensionRetiro)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaPercepcionesJubilacionPensionRetiro Deserialize(System.IO.Stream s)
    {
        return ((NominaPercepcionesJubilacionPensionRetiro)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaPercepcionesJubilacionPensionRetiro object into file
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
    /// Deserializes xml markup from file into an NominaPercepcionesJubilacionPensionRetiro object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaPercepcionesJubilacionPensionRetiro object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaPercepcionesJubilacionPensionRetiro obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesJubilacionPensionRetiro);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesJubilacionPensionRetiro obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesJubilacionPensionRetiro obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaPercepcionesJubilacionPensionRetiro LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaPercepcionesJubilacionPensionRetiro LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

