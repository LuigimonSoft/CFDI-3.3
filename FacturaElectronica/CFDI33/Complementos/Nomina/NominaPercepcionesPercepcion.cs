
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
/// Nodo requerido para expresar la información detallada de una percepción
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaPercepcionesPercepcion : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaPercepcionesPercepcionAccionesOTitulos _accionesOTitulos;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<NominaPercepcionesPercepcionHorasExtra> _horasExtra;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoPercepcion _tipoPercepcion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _clave;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _concepto;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _importeGravado;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _importeExento;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Nodo condicional para expresar ingresos por acciones o títulos valor que representan bienes. Se vuelve requerido cuando existan ingresos por sueldos derivados de adquisición de acciones o títulos (Art. 94, fracción VII LISR).
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public NominaPercepcionesPercepcionAccionesOTitulos AccionesOTitulos
    {
        get
        {
            return this._accionesOTitulos;
        }
        set
        {
            if ((this._accionesOTitulos == value))
            {
                return;
            }
            if (((this._accionesOTitulos == null) 
                        || (_accionesOTitulos.Equals(value) != true)))
            {
                this._accionesOTitulos = value;
                this.OnPropertyChanged("AccionesOTitulos");
            }
        }
    }
    
    /// <summary>
    /// Nodo condicional para expresar las horas extra aplicables.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("HorasExtra", Order=1)]
    public List<NominaPercepcionesPercepcionHorasExtra> HorasExtra
    {
        get
        {
            return this._horasExtra;
        }
        set
        {
            if ((this._horasExtra == value))
            {
                return;
            }
            if (((this._horasExtra == null) 
                        || (_horasExtra.Equals(value) != true)))
            {
                this._horasExtra = value;
                this.OnPropertyChanged("HorasExtra");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la Clave agrupadora bajo la cual se clasifica la percepción.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoPercepcion TipoPercepcion
    {
        get
        {
            return this._tipoPercepcion;
        }
        set
        {
            if ((_tipoPercepcion.Equals(value) != true))
            {
                this._tipoPercepcion = value;
                this.OnPropertyChanged("TipoPercepcion");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la clave de percepción de nómina propia de la contabilidad de cada patrón, puede conformarse desde 3 hasta 15 caracteres.
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
    /// Atributo requerido para la descripción del concepto de percepción
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
    /// Atributo requerido, representa el importe gravado de un concepto de percepción.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteGravado
    {
        get
        {
            return this._importeGravado;
        }
        set
        {
            if ((_importeGravado.Equals(value) != true))
            {
                this._importeGravado = value;
                this.OnPropertyChanged("ImporteGravado");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido, representa el importe exento de un concepto de percepción.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ImporteExento
    {
        get
        {
            return this._importeExento;
        }
        set
        {
            if ((_importeExento.Equals(value) != true))
            {
                this._importeExento = value;
                this.OnPropertyChanged("ImporteExento");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaPercepcionesPercepcion));
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
    /// Serializes current NominaPercepcionesPercepcion object into an XML string
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
    /// Deserializes workflow markup into an NominaPercepcionesPercepcion object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaPercepcionesPercepcion object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaPercepcionesPercepcion obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesPercepcion);
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
    
    public static bool Deserialize(string input, out NominaPercepcionesPercepcion obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaPercepcionesPercepcion Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaPercepcionesPercepcion)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaPercepcionesPercepcion Deserialize(System.IO.Stream s)
    {
        return ((NominaPercepcionesPercepcion)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaPercepcionesPercepcion object into file
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
    /// Deserializes xml markup from file into an NominaPercepcionesPercepcion object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaPercepcionesPercepcion object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaPercepcionesPercepcion obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaPercepcionesPercepcion);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesPercepcion obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaPercepcionesPercepcion obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaPercepcionesPercepcion LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaPercepcionesPercepcion LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

