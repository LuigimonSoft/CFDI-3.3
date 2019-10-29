
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
/// Nodo requerido para precisar la información del contribuyente receptor del comprobante de nómina.
/// </summary>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/Nomina12")]
public partial class NominaReceptor : System.ComponentModel.INotifyPropertyChanged
{
    
    #region Propiedades Privadas
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<NominaReceptorSubContratacion> _subContratacion;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _curp;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _numSeguridadSocial;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.DateTime _fechaInicioRelLaboral;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _antigüedad;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoContrato _tipoContrato;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private NominaReceptorSindicalizado _sindicalizado;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoJornada _tipoJornada;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_TipoRegimen _tipoRegimen;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _numEmpleado;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _departamento;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _puesto;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_RiesgoPuesto _riesgoPuesto;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_PeriodicidadPago _periodicidadPago;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_Banco _banco;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _cuentaBancaria;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _salarioBaseCotApor;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private decimal _salarioDiarioIntegrado;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private c_Estado _claveEntFed;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Nodo condicional para expresar la lista de las personas que los subcontrataron.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("SubContratacion", Order=0)]
    public List<NominaReceptorSubContratacion> SubContratacion
    {
        get
        {
            return this._subContratacion;
        }
        set
        {
            if ((this._subContratacion == value))
            {
                return;
            }
            if (((this._subContratacion == null) 
                        || (_subContratacion.Equals(value) != true)))
            {
                this._subContratacion = value;
                this.OnPropertyChanged("SubContratacion");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la CURP del receptor del comprobante de nómina.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Curp
    {
        get
        {
            return this._curp;
        }
        set
        {
            if ((this._curp == value))
            {
                return;
            }
            if (((this._curp == null) 
                        || (_curp.Equals(value) != true)))
            {
                this._curp = value;
                this.OnPropertyChanged("Curp");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el número de seguridad social del trabajador. Se debe ingresar cuando se cuente con él, o se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(15, MinimumLength=1)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,15}")]
    public string NumSeguridadSocial
    {
        get
        {
            return this._numSeguridadSocial;
        }
        set
        {
            if ((this._numSeguridadSocial == value))
            {
                return;
            }
            if (((this._numSeguridadSocial == null) || (_numSeguridadSocial.Equals(value) != true)))
            {
                this._numSeguridadSocial = value;
                this.OnPropertyChanged("NumSeguridadSocial");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar la fecha de inicio de la relación laboral entre el empleador y el empleado. Se expresa en la forma aaaa-mm-dd, de acuerdo con la especificación ISO 8601. Se debe ingresar cuando se cuente con él, o se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime FechaInicioRelLaboral
    {
        get
        {
            return this._fechaInicioRelLaboral;
        }
        set
        {
            if ((_fechaInicioRelLaboral.Equals(value) != true))
            {
                this._fechaInicioRelLaboral = value;
                this.OnPropertyChanged("FechaInicioRelLaboral");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el número de semanas o el periodo de años, meses y días que el empleado ha mantenido relación laboral con el empleador. Se debe ingresar cuando se cuente con él, o se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("P(([1-9][0-9]{0,3})|0)W|P([1-9][0-9]?Y)?(([1-9]|1[012])M)?(0|[1-9]|[12][0-9]|3[01])D")]
    public string Antigüedad
    {
        get
        {
            return this._antigüedad;
        }
        set
        {
            if ((this._antigüedad == value))
            {
                return;
            }
            if (((this._antigüedad == null) 
                        || (_antigüedad.Equals(value) != true)))
            {
                this._antigüedad = value;
                this.OnPropertyChanged("Antigüedad");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el tipo de contrato que tiene el trabajador.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoContrato TipoContrato
    {
        get
        {
            return this._tipoContrato;
        }
        set
        {
            if ((_tipoContrato.Equals(value) != true))
            {
                this._tipoContrato = value;
                this.OnPropertyChanged("TipoContrato");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para indicar si el trabajador está asociado a un sindicato. Si se omite se asume que no está asociado a algún sindicato.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NominaReceptorSindicalizado Sindicalizado
    {
        get
        {
            return this._sindicalizado;
        }
        set
        {
            if ((_sindicalizado.Equals(value) != true))
            {
                this._sindicalizado = value;
                this.OnPropertyChanged("Sindicalizado");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para expresar el tipo de jornada que cubre el trabajador. Se debe ingresar cuando se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoJornada TipoJornada
        {
            get
            {
                return this._tipoJornada;
            }
            set
            {
                if ((_tipoJornada.Equals(value) != true))
                {
                    this._tipoJornada = value;
                    TipoJornadaSpecified = true;
                    this.OnPropertyChanged("TipoJornada");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoJornadaSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para la expresión de la clave del régimen por el cual se tiene contratado al trabajador.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoRegimen TipoRegimen
    {
        get
        {
            return this._tipoRegimen;
        }
        set
        {
            if ((_tipoRegimen.Equals(value) != true))
            {
                this._tipoRegimen = value;
                this.OnPropertyChanged("TipoRegimen");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar el número de empleado de 1 a 15 posiciones.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(15, MinimumLength=1)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,15}")]
    public string NumEmpleado
    {
        get
        {
            return this._numEmpleado;
        }
        set
        {
            if ((this._numEmpleado == value))
            {
                return;
            }
            if (((this._numEmpleado == null) 
                        || (_numEmpleado.Equals(value) != true)))
            {
                this._numEmpleado = value;
                this.OnPropertyChanged("NumEmpleado");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para la expresión del departamento o área a la que pertenece el trabajador.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(100, MinimumLength=1)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,100}")]
    public string Departamento
    {
        get
        {
            return this._departamento;
        }
        set
        {
            if ((this._departamento == value))
            {
                return;
            }
            if (((this._departamento == null) 
                        || (_departamento.Equals(value) != true)))
            {
                this._departamento = value;
                this.OnPropertyChanged("Departamento");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para la expresión del puesto asignado al empleado o actividad que realiza.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DataAnnotations.StringLengthAttribute(100, MinimumLength=1)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,100}")]
    public string Puesto
    {
        get
        {
            return this._puesto;
        }
        set
        {
            if ((this._puesto == value))
            {
                return;
            }
            if (((this._puesto == null) 
                        || (_puesto.Equals(value) != true)))
            {
                this._puesto = value;
                this.OnPropertyChanged("Puesto");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para expresar la clave conforme a la Clase en que deben inscribirse los patrones, de acuerdo con las actividades que desempeñan sus trabajadores, según lo previsto en el artículo 196 del Reglamento en Materia de Afiliación Clasificación de Empresas, Recaudación y Fiscalización, o conforme con la normatividad del Instituto de Seguridad Social del trabajador.  Se debe ingresar cuando se cuente con él, o se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_RiesgoPuesto RiesgoPuesto
        {
            get
            {
                return this._riesgoPuesto;
            }
            set
            {
                if ((_riesgoPuesto.Equals(value) != true))
                {
                    this._riesgoPuesto = value;
                    RiesgoPuestoSpecified = true;
                    this.OnPropertyChanged("RiesgoPuesto");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RiesgoPuestoSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para la forma en que se establece el pago del salario.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_PeriodicidadPago PeriodicidadPago
    {
        get
        {
            return this._periodicidadPago;
        }
        set
        {
            if ((_periodicidadPago.Equals(value) != true))
            {
                this._periodicidadPago = value;
                this.OnPropertyChanged("PeriodicidadPago");
            }
        }
    }
    
    /// <summary>
    /// Atributo condicional para la expresión de la clave del Banco conforme al catálogo, donde se realiza el depósito de nómina.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]

        public c_Banco Banco
        {
            get
            {
                return this._banco;
            }
            set
            {
                if ((_banco.Equals(value) != true))
                {
                    this._banco = value;
                    BancoSpecified = true;
                    this.OnPropertyChanged("Banco");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BancoSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para la expresión de la cuenta bancaria a 11 posiciones o número de teléfono celular a 10 posiciones o número de tarjeta de crédito, débito o servicios a 15 ó 16 posiciones o la CLABE a 18 posiciones o número de monedero electrónico, donde se realiza el depósito de nómina.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CuentaBancaria
    {
        get
        {
            return this._cuentaBancaria;
        }
        set
        {
            if ((this._cuentaBancaria == value))
            {
                return;
            }
            if (((this._cuentaBancaria == null) 
                        || (_cuentaBancaria.Equals(value) != true)))
            {
                this._cuentaBancaria = value;
                this.OnPropertyChanged("CuentaBancaria");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para expresar la retribución otorgada al trabajador, que se integra por los pagos hechos en efectivo por cuota diaria, gratificaciones, percepciones, alimentación, habitación, primas, comisiones, prestaciones en especie y cualquiera otra cantidad o prestación que se entregue al trabajador por su trabajo, sin considerar los conceptos que se excluyen de conformidad con el Artículo 27 de la Ley del Seguro Social, o la integración de los pagos conforme la normatividad del Instituto de Seguridad Social del trabajador. (Se emplea para pagar las cuotas y aportaciones de Seguridad Social). Se debe ingresar cuando se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SalarioBaseCotApor
    {
        get
        {
            return this._salarioBaseCotApor;
        }
        set
        {
            if ((_salarioBaseCotApor.Equals(value) != true))
            {
                this._salarioBaseCotApor = value;
                this.OnPropertyChanged("SalarioBaseCotApor");
            }
        }
    }
    
    /// <summary>
    /// Atributo opcional para expresar el salario que se integra con los pagos hechos en efectivo por cuota diaria, gratificaciones, percepciones, habitación, primas, comisiones, prestaciones en especie y cualquier otra cantidad o prestación que se entregue al trabajador por su trabajo, de conformidad con el Art. 84 de la Ley Federal del Trabajo. (Se utiliza para el cálculo de las indemnizaciones). Se debe ingresar cuando se esté obligado conforme a otras disposiciones distintas a las fiscales.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SalarioDiarioIntegrado
    {
        get
        {
            return this._salarioDiarioIntegrado;
        }
        set
        {
            if ((_salarioDiarioIntegrado.Equals(value) != true))
            {
                this._salarioDiarioIntegrado = value;
                this.OnPropertyChanged("SalarioDiarioIntegrado");
            }
        }
    }
    
    /// <summary>
    /// Atributo requerido para expresar la clave de la entidad federativa en donde el receptor del recibo prestó el servicio.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_Estado ClaveEntFed
    {
        get
        {
            return this._claveEntFed;
        }
        set
        {
            if ((_claveEntFed.Equals(value) != true))
            {
                this._claveEntFed = value;
                this.OnPropertyChanged("ClaveEntFed");
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(NominaReceptor));
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
    /// Serializes current NominaReceptor object into an XML string
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
    /// Deserializes workflow markup into an NominaReceptor object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output NominaReceptor object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out NominaReceptor obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaReceptor);
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
    
    public static bool Deserialize(string input, out NominaReceptor obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static NominaReceptor Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((NominaReceptor)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static NominaReceptor Deserialize(System.IO.Stream s)
    {
        return ((NominaReceptor)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current NominaReceptor object into file
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
    /// Deserializes xml markup from file into an NominaReceptor object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NominaReceptor object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LeerDesdeArchivo(string fileName, System.Text.Encoding encoding, out NominaReceptor obj, out System.Exception exception)
    {
        exception = null;
        obj = default(NominaReceptor);
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
    
    public static bool LeerDesdeArchivo(string fileName, out NominaReceptor obj, out System.Exception exception)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LeerDesdeArchivo(string fileName, out NominaReceptor obj)
    {
        System.Exception exception = null;
        return LeerDesdeArchivo(fileName, out obj, out exception);
    }
    
    public static NominaReceptor LeerDesdeArchivo(string fileName)
    {
        return LeerDesdeArchivo(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static NominaReceptor LeerDesdeArchivo(string fileName, System.Text.Encoding encoding)
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

