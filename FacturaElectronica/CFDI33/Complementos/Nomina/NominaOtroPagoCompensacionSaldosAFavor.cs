
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
/// Nodo condicional para expresar la información referente a la compensación de saldos a favor de un trabajador.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaOtroPagoCompensacionSaldosAFavor : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _saldoAFavor;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private short _año;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _remanenteSalFav;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Atributo requerido para expresar el saldo a favor determinado por el patrón al trabajador en periodos o ejercicios anteriores.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SaldoAFavor
    {
        get
        {
            return this._saldoAFavor;
        }
        set
        {
            if ((_saldoAFavor.Equals(value) != true))
            {
                this._saldoAFavor = value;
                this.OnPropertyChanged("SaldoAFavor");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el año en que se determinó el saldo a favor del trabajador por el patrón que se incluye en el campo “RemanenteSalFav”.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short Año
    {
        get
        {
            return this._año;
        }
        set
        {
            if ((_año.Equals(value) != true))
            {
                this._año = value;
                this.OnPropertyChanged("Año");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el remanente del saldo a favor del trabajador.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal RemanenteSalFav
    {
        get
        {
            return this._remanenteSalFav;
        }
        set
        {
            if ((_remanenteSalFav.Equals(value) != true))
            {
                this._remanenteSalFav = value;
                this.OnPropertyChanged("RemanenteSalFav");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaOtroPagoCompensacionSaldosAFavor));
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
    /// Serializes current NominaOtroPagoCompensacionSaldosAFavor object into an XML string
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
    /// Deserializes workflow markup into an NominaOtroPagoCompensacionSaldosAFavor object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaOtroPagoCompensacionSaldosAFavor object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaOtroPagoCompensacionSaldosAFavor obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaOtroPagoCompensacionSaldosAFavor);
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
    
    public static bool Deserialize(string input, out NominaOtroPagoCompensacionSaldosAFavor obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaOtroPagoCompensacionSaldosAFavor Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaOtroPagoCompensacionSaldosAFavor)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaOtroPagoCompensacionSaldosAFavor Deserialize(System.IO.Stream s)
    {
        return ((NominaOtroPagoCompensacionSaldosAFavor)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaOtroPagoCompensacionSaldosAFavor object into file
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
    /// Deserializes xml markup from file into an NominaOtroPagoCompensacionSaldosAFavor object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaOtroPagoCompensacionSaldosAFavor object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaOtroPagoCompensacionSaldosAFavor obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaOtroPagoCompensacionSaldosAFavor);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaOtroPagoCompensacionSaldosAFavor obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaOtroPagoCompensacionSaldosAFavor obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaOtroPagoCompensacionSaldosAFavor LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaOtroPagoCompensacionSaldosAFavor LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

