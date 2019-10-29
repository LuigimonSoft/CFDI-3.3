
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
/// Nodo condicional para expresar las percepciones aplicables.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaPercepciones : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<NominaPercepcionesPercepcion> _percepcion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaPercepcionesJubilacionPensionRetiro _jubilacionPensionRetiro;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaPercepcionesSeparacionIndemnizacion _separacionIndemnizacion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalSueldos;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalSeparacionIndemnizacion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalJubilacionPensionRetiro;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalGravado;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _totalExento;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// NominaPercepciones class constructor
    /// </summary>
    public NominaPercepciones()
    {
        this._percepcion = new List<NominaPercepcionesPercepcion>();
    }
    
    /// <summary>
    /// Nodo requerido para expresar la información detallada de una percepción
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("Percepcion", Order=0)]
    public List<NominaPercepcionesPercepcion> Percepcion
    {
        get
        {
            return this._percepcion;
        }
        set
        {
            if ((this._percepcion == value))
            {
                return;
            }
            if (((this._percepcion == null) 
                        || (_percepcion.Equals(value) != true)))
            {
                this._percepcion = value;
                this.OnPropertyChanged("Percepcion");
            }
        }
    }
    
    /// <summary>
    /// Nodo condicional para expresar la información detallada de pagos por jubilación, pensiones o haberes de retiro.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NominaPercepcionesJubilacionPensionRetiro JubilacionPensionRetiro
    {
        get
        {
            return this._jubilacionPensionRetiro;
        }
        set
        {
            if ((this._jubilacionPensionRetiro == value))
            {
                return;
            }
            if (((this._jubilacionPensionRetiro == null) 
                        || (_jubilacionPensionRetiro.Equals(value) != true)))
            {
                this._jubilacionPensionRetiro = value;
                this.OnPropertyChanged("JubilacionPensionRetiro");
            }
        }
    }
    
    /// <summary>
    /// Nodo condicional para expresar la información detallada de otros pagos por separación.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public NominaPercepcionesSeparacionIndemnizacion SeparacionIndemnizacion
    {
        get
        {
            return this._separacionIndemnizacion;
        }
        set
        {
            if ((this._separacionIndemnizacion == value))
            {
                return;
            }
            if (((this._separacionIndemnizacion == null) 
                        || (_separacionIndemnizacion.Equals(value) != true)))
            {
                this._separacionIndemnizacion = value;
                this.OnPropertyChanged("SeparacionIndemnizacion");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el total de percepciones brutas (gravadas y exentas) por sueldos y salarios y conceptos asimilados a salarios.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalSueldos
    {
        get
        {
            return this._totalSueldos;
        }
        set
        {
            if ((_totalSueldos.Equals(value) != true))
            {
                this._totalSueldos = value;
                this.OnPropertyChanged("TotalSueldos");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el importe exento y gravado de las claves tipo percepción 022 Prima por Antigüedad, 023 Pagos por separación y 025 Indemnizaciones.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalSeparacionIndemnizacion
    {
        get
        {
            return this._totalSeparacionIndemnizacion;
        }
        set
        {
            if ((_totalSeparacionIndemnizacion.Equals(value) != true))
            {
                this._totalSeparacionIndemnizacion = value;
                this.OnPropertyChanged("TotalSeparacionIndemnizacion");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el importe exento y gravado de las claves tipo percepción 039 Jubilaciones, pensiones o haberes de retiro en una exhibición y 044 Jubilaciones, pensiones o haberes de retiro en parcialidades.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalJubilacionPensionRetiro
    {
        get
        {
            return this._totalJubilacionPensionRetiro;
        }
        set
        {
            if ((_totalJubilacionPensionRetiro.Equals(value) != true))
            {
                this._totalJubilacionPensionRetiro = value;
                this.OnPropertyChanged("TotalJubilacionPensionRetiro");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el total de percepciones gravadas que se relacionan en el comprobante.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalGravado
    {
        get
        {
            return this._totalGravado;
        }
        set
        {
            if ((_totalGravado.Equals(value) != true))
            {
                this._totalGravado = value;
                this.OnPropertyChanged("TotalGravado");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el total de percepciones exentas que se relacionan en el comprobante.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalExento
    {
        get
        {
            return this._totalExento;
        }
        set
        {
            if ((_totalExento.Equals(value) != true))
            {
                this._totalExento = value;
                this.OnPropertyChanged("TotalExento");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaPercepciones));
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
    /// Serializes current NominaPercepciones object into an XML string
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
    /// Deserializes workflow markup into an NominaPercepciones object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaPercepciones object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaPercepciones obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepciones);
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
    
    public static bool Deserialize(string input, out NominaPercepciones obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaPercepciones Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaPercepciones)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaPercepciones Deserialize(System.IO.Stream s)
    {
        return ((NominaPercepciones)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaPercepciones object into file
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
    /// Deserializes xml markup from file into an NominaPercepciones object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaPercepciones object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaPercepciones obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepciones);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepciones obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepciones obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaPercepciones LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaPercepciones LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

