using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace FacturaElectronica.CFDI33
{
    

    /// <summary>
    /// Estándar de Comprobante Fiscal Digital por Internet.
    /// </summary>
    [System.SerializableAttribute()] 
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = false, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    
    public partial class Comprobante : System.ComponentModel.INotifyPropertyChanged
    {

        [XmlAttribute(AttributeName = "schemaLocation" , Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";

        #region Private fields
        [EditorBrowsable(EditorBrowsableState.Never)]
        private ComprobanteCfdiRelacionados _cfdiRelacionados;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private ComprobanteEmisor _emisor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private ComprobanteReceptor _receptor;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<ComprobanteConcepto> _conceptos;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private ComprobanteImpuestos _impuestos;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<ComprobanteComplemento> _complemento;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private ComprobanteAddenda _addenda;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _serie;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _folio;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private System.DateTime _fecha;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _sello;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_FormaPago _formaPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _noCertificado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _certificado;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _condicionesDePago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _subTotal;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private t_Importe _descuento;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_Moneda _moneda;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _tipoCambio;
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _stipoCambio;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private decimal _total;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_TipoDeComprobante _tipoDeComprobante;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private c_MetodoPago _metodoPago;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _lugarExpedicion;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _confirmacion;

        private static XmlSerializer serializer;
        #endregion

        
        /// <summary>
        /// Comprobante class constructor
        /// </summary>
        public Comprobante()
        {
            init();
        }

        /// <summary>
        /// Nodo opcional para precisar la información de los comprobantes relacionados.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ComprobanteCfdiRelacionados CfdiRelacionados
        {
            get
            {
                return this._cfdiRelacionados;
            }
            set
            {
                if ((this._cfdiRelacionados == value))
                {
                    return;
                }
                if (((this._cfdiRelacionados == null)
                            || (_cfdiRelacionados.Equals(value) != true)))
                {
                    this._cfdiRelacionados = value;
                    this.OnPropertyChanged("CfdiRelacionados");
                }
            }
        }

        /// <summary>
        /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this._emisor;
            }
            set
            {
                if ((this._emisor == value))
                {
                    return;
                }
                if (((this._emisor == null)
                            || (_emisor.Equals(value) != true)))
                {
                    this._emisor = value;
                    this.OnPropertyChanged("Emisor");
                }
            }
        }

        /// <summary>
        /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this._receptor;
            }
            set
            {
                if ((this._receptor == value))
                {
                    return;
                }
                if (((this._receptor == null)
                            || (_receptor.Equals(value) != true)))
                {
                    this._receptor = value;
                    this.OnPropertyChanged("Receptor");
                }
            }
        }

        /// <summary>
        /// Nodo requerido para listar los conceptos cubiertos por el comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public List<ComprobanteConcepto> Conceptos
        {
            get
            {
                return this._conceptos;
            }
            set
            {
                if ((this._conceptos == value))
                {
                    return;
                }
                if (((this._conceptos == null)
                            || (_conceptos.Equals(value) != true)))
                {
                    this._conceptos = value;
                    this.OnPropertyChanged("Conceptos");
                }
            }
        }

        /// <summary>
        /// Nodo condicional para expresar el resumen de los impuestos aplicables.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ComprobanteImpuestos Impuestos
        {
            get
            {
                return this._impuestos;
            }
            set
            {
                if ((this._impuestos == value))
                {
                    return;
                }
                if (((this._impuestos == null)
                            || (_impuestos.Equals(value) != true)))
                {
                    this._impuestos = value;
                    this.OnPropertyChanged("Impuestos");
                }
            }
        }

        /// <summary>
        /// Nodo opcional donde se incluye el complemento Timbre Fiscal Digital de manera obligatoria y los nodos complementarios determinados por el SAT, de acuerdo con las disposiciones particulares para un sector o actividad específica.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Complemento", Order = 5)]
        public List<ComprobanteComplemento> Complemento
        {
            get
            {
                return this._complemento;
            }
            set
            {
                if ((this._complemento == value))
                {
                    return;
                }
                if (((this._complemento == null)
                            || (_complemento.Equals(value) != true)))
                {
                    this._complemento = value;
                    this.OnPropertyChanged("Complemento");
                }
            }
        }

        /// <summary>
        /// Nodo opcional para recibir las extensiones al presente formato que sean de utilidad al contribuyente. Para las reglas de uso del mismo, referirse al formato origen.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ComprobanteAddenda Addenda
        {
            get
            {
                return this._addenda;
            }
            set
            {
                if ((this._addenda == value))
                {
                    return;
                }
                if (((this._addenda == null)
                            || (_addenda.Equals(value) != true)))
                {
                    this._addenda = value;
                    this.OnPropertyChanged("Addenda");
                }
            }
        }

        /// <summary>
        /// Atributo requerido con valor prefijado a 3.3 que indica la versión del estándar bajo el que se encuentra expresado el comprobante.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                if ((this._version == value))
                {
                    return;
                }
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("Version");
                }
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la serie para control interno del contribuyente. Este atributo acepta una cadena de caracteres.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(25, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,25}")]
        public string Serie
        {
            get
            {
                return this._serie;
            }
            set
            {
                String Error = String.Empty;
                if(!Comprobante.VerificarLongitud(1,25,"Serie",value,out Error))
                    throw new Exception(Error);
                if (!VerificadorPatrones.VerificarPatronSinPunto(value))
                    throw new Exception("Caracteres no permitidos en campo Serie");


                if ((this._serie == value))
                {
                    return;
                }
                if (((this._serie == null) || (_serie.Equals(value) != true)))
                {
                    this._serie = value;
                    this.OnPropertyChanged("Serie");
                }
            }
        }

        /// <summary>
        /// Atributo opcional para control interno del contribuyente que expresa el folio del comprobante, acepta una cadena de caracteres.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(40, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,40}")]
        public string Folio
        {
            get
            {
                return this._folio;
            }
            set
            {
                String Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 40, "Folio", value, out Error))
                    throw new Exception(Error);

                if(!VerificadorPatrones.VerificarPatronSinPunto(value))
                    throw new Exception("Caracteres no permitidos en campo Folio");

                if ((this._folio == value))
                {
                    return;
                }
                if (((this._folio == null)
                            || (_folio.Equals(value) != true)))
                {
                    this._folio = value;
                    this.OnPropertyChanged("Folio");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "Fecha")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])T(([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9])")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String sFecha
        {
            get
            {
                return Fecha.ToString("yyyy-MM-ddThh:mm:ss");
            }
            set
            {
                
                if ((Fecha.ToString("yyyy-MM-ddThh:mm:ss").Equals(value) != true))
                {
                    Fecha = System.Convert.ToDateTime(value);
                    this.OnPropertyChanged("Fecha");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante fiscal, al que hacen referencia las reglas de resolución miscelánea vigente. El sello debe ser expresado como una cadena de texto en formato Base 64.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this._sello;
            }
            set
            {
                if ((this._sello == value))
                {
                    return;
                }
                if (((this._sello == null)
                            || (_sello.Equals(value) != true)))
                {
                    this._sello = value;
                    this.OnPropertyChanged("Sello");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar la clave de la forma de pago de los bienes o servicios amparados por el comprobante. Si no se conoce la forma de pago este atributo se debe omitir.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_FormaPago FormaPago
        {
            get
            {
                return this._formaPago;
            }
            set
            {
                FormaPagoSpecified = true;
                if ((_formaPago.Equals(value) != true))
                {
                    this._formaPago = value;
                    this.OnPropertyChanged("FormaPago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormaPagoSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para expresar el número de serie del certificado de sello digital que ampara al comprobante, de acuerdo con el acuse correspondiente a 20 posiciones otorgado por el sistema del SAT.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{20}")]
        public string NoCertificado
        {
            get
            {
                return this._noCertificado;
            }
            set
            {
                if ((this._noCertificado == value))
                {
                    return;
                }
                if (((this._noCertificado == null)
                            || (_noCertificado.Equals(value) != true)))
                {
                    this._noCertificado = value;
                    this.OnPropertyChanged("NoCertificado");
                }
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para incorporar el certificado de sello digital que ampara al comprobante, como texto en formato base 64.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this._certificado;
            }
            set
            {
                if ((this._certificado == value))
                {
                    return;
                }
                if (((this._certificado == null) || (_certificado.Equals(value) != true)))
                {
                    this._certificado = value;
                    ContenidoCertificado = new FacturaElectronica.Certificado(System.Convert.FromBase64String(value));
                    Emisor.Rfc = new t_RFC(ContenidoCertificado.RFCCertificado);
                    NoCertificado = ContenidoCertificado.NumeroSerie;
                    this.OnPropertyChanged("Certificado");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para expresar las condiciones comerciales aplicables para el pago del comprobante fiscal digital por Internet. Este atributo puede ser condicionado mediante atributos o complementos.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.StringLengthAttribute(1000, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[^|]{1,1000}")]
        public string CondicionesDePago
        {
            get
            {
                return this._condicionesDePago;
            }
            set
            {
                String Error = String.Empty;
                if (!Comprobante.VerificarLongitud(1, 1000, "CondicionesDePago", value, out Error))
                    throw new Exception(Error);
                if (!VerificadorPatrones.VerificarPatronSinPunto(value))
                    throw new Exception("Caracteres no permitidos en campo CondicionesDePago");

                if ((this._condicionesDePago == value))
                {
                    return;
                }
                CondicionesDePagoSpecified = true;
                if (((this._condicionesDePago == null) || (_condicionesDePago.Equals(value) != true)))
                {
                    this._condicionesDePago = value;
                    this.OnPropertyChanged("CondicionesDePago");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CondicionesDePagoSpecified { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName ="SubTotal")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String strSubTotal
        {
            get
            {
                if (Moneda == c_Moneda.XXX)
                    return "0";
                else
                    return SubTotal.strImporte;
            }
            set
            {
                if (SubTotal == null)
                    SubTotal = new t_Importe("0.000001");
                if ((SubTotal.strImporte.Equals(value) != true))
                {
                    SubTotal.strImporte = value;
                    this.OnPropertyChanged("SubTotal");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para representar el importe total de los descuentos aplicables antes de impuestos. No se permiten valores negativos. Se debe registrar cuando existan conceptos con descuento.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="Descuento")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strDescuento
        {
            get
            {
                if (Descuento != null)
                    return Descuento.strImporte;
                else
                    return String.Empty;
            }
            set
            {
                if (Descuento == null)
                    Descuento = new t_Importe(value);
                strDescuentoSpecified = true;
                if ((Descuento.strImporte.Equals(value) != true))
                {
                    this.Descuento.strImporte = value;
                    this.OnPropertyChanged("Descuento");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strDescuentoSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada para expresar los montos, cuando se usa moneda nacional se registra MXN. Conforme con la especificación ISO 4217.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "Moneda")]
        
        public c_Moneda Moneda
        {
            get
            {
                return this._moneda;
            }
            set
            {
                if ((_moneda.Equals(value) != true))
                {
                    this._moneda = value;
                    this.OnPropertyChanged("Moneda");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "TipoCambio")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string stipoCambio
        {
            get
            {
                if (Moneda != c_Moneda.XXX)
                {
                    if (TipoCambio == 0)
                        return null;
                    else
                        return _stipoCambio;
                }
                else
                    return null;
            }

            set
            {
                TipoCambio = System.Convert.ToDecimal(value);
                
            }

        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stipoCambioSpecified { get; set; }

        /// <summary>
        /// Atributo condicional para representar el tipo de cambio conforme con la moneda usada. Es requerido cuando la clave de moneda es distinta de MXN y de XXX. El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo moneda. Si el valor está fuera del porcentaje aplicable a la moneda tomado del catálogo c_Moneda, el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para ratificar que el valor es correcto e integrar dicha clave en el atributo Confirmacion.
        /// </summary>
        [XmlIgnore]
        public decimal TipoCambio
        {
            get
            {
                if (Moneda == c_Moneda.XXX)
                    return 0;
                else 
                    return this._tipoCambio;
            }
            set
            {
                if (value < System.Convert.ToDecimal(0.000001))
                    throw new ArgumentException("El valor minimo permitido es 0.000001 ");
                
                String[] partes = value.ToString().Split(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToCharArray(0,1));
                if(partes.Length>1)
                {
                    int Parte1 = System.Convert.ToInt32(partes[0]);
                    decimal valorprueba = (value - Parte1);
                    if(valorprueba< System.Convert.ToDecimal(0.000001) && valorprueba!=0)
                        throw new ArgumentException("El numero de decimales maximo es de 6");
                }
                stipoCambioSpecified = true;
                if ((_tipoCambio.Equals(value) != true))
                {
                    this._tipoCambio = value;
                    _stipoCambio = partes[0];
                    if (partes.Length > 1)
                    {
                        if (partes[1].Length > 6)
                            _stipoCambio +="."+ partes[1].Substring(0, 6);
                        else
                            _stipoCambio += "." + partes[1];
                    }
                    else
                        _stipoCambio +=".000000";

                    if (value == 1)
                        _stipoCambio = "1";
                    
                    this.OnPropertyChanged("TipoCambio");
                }
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="Total")]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,18}(.[0-9]{1,6})?")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string strTotal
        {
            get
            {
                if (Moneda == c_Moneda.XXX)
                    return "0";
                else
                    return Total.strImporte;
            }
            set
            {
                if (Total == null)
                    Total = new t_Importe("0.000001");

                if ((Total.strImporte.Equals(value) != true))
                {
                    this.Total.strImporte = value;
                    this.OnPropertyChanged("Total");
                }
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del efecto del comprobante fiscal para el contribuyente emisor.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoDeComprobante TipoDeComprobante
        {
            get
            {
                return this._tipoDeComprobante;
            }
            set
            {
                if ((_tipoDeComprobante.Equals(value) != true))
                {
                    this._tipoDeComprobante = value;
                    this.OnPropertyChanged("TipoDeComprobante");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para precisar la clave del método de pago que aplica para este comprobante fiscal digital por Internet, conforme al Artículo 29-A fracción VII incisos a y b del CFF.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_MetodoPago MetodoPago
        {
            get
            {
                return this._metodoPago;
            }
            set
            {
                MetodoPagoSpecified = true;
                if ((_metodoPago.Equals(value) != true))
                {
                    this._metodoPago = value;
                    
                    this.OnPropertyChanged("MetodoPago");
                }
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified { get; set; }

        /// <summary>
        /// Atributo requerido para incorporar el código postal del lugar de expedición del comprobante (domicilio de la matriz o de la sucursal).
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{5}")]
        public string LugarExpedicion
        {
            get
            {
                return this._lugarExpedicion;
            }
            set
            {
                if ((this._lugarExpedicion == value))
                {
                    return;
                }
                int val;
                if(!int.TryParse(value,out val))
                    throw new Exception("El codigo postal debe ser de 5 digitos");
                if(value.Length>5 || value.Length<5)
                    throw new Exception("El codigo postal debe ser de 5 digitos");
                if (((this._lugarExpedicion == null) || (_lugarExpedicion.Equals(value) != true)))
                {
                    this._lugarExpedicion = value;
                    this.OnPropertyChanged("LugarExpedicion");
                }
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave de confirmación que entregue el PAC para expedir el comprobante con importes grandes, con un tipo de cambio fuera del rango establecido o con ambos  casos. Es requerido cuando se registra un tipo de cambio o un total fuera del rango establecido.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9a-zA-Z]{5}")]
        public string Confirmacion
        {
            get
            {
                return this._confirmacion;
            }
            set
            {
                if ((this._confirmacion == value))
                {
                    return;
                }
                ConfirmacionSpecified = true;
                if (((this._confirmacion == null)
                            || (_confirmacion.Equals(value) != true)))
                {
                    this._confirmacion = value;
                    
                    this.OnPropertyChanged("Confirmacion");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfirmacionSpecified { get; set; }

        
        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    //serializer = XmlSerializer.FromTypes(new[] { typeof(FacturaElectronica.CFDI33.Comprobante) })[0];
                    /**/

                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(FacturaElectronica.CFDI33.Comprobante));

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

        [XmlIgnore]
        public bool UsarIdentado { set; get; }

        [XmlIgnore]
        public string CaracterIdentado { set; get; }

        /// <summary>
        /// Serializes current Comprobante object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                if (String.IsNullOrEmpty(CaracterIdentado))
                    CaracterIdentado = "\t";
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.CheckCharacters = true;
                xmlWriterSettings.Indent = UsarIdentado;
                xmlWriterSettings.IndentChars = CaracterIdentado;
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                Serializer.Serialize(xmlWriter, this, ns);
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
        /// Deserializes workflow markup into an Comprobante object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Comprobante object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Comprobante obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Comprobante);
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

        public static bool Deserialize(string input, out Comprobante obj)
        {
            System.Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public new static Comprobante Deserialize(string input)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(input);
                return ((Comprobante)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Comprobante Deserialize(System.IO.Stream s)
        {
            return ((Comprobante)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current Comprobante object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        private  bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
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

        public virtual bool GuardarEnArchivo(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
        }

        public virtual void GuardarEnArchivo(string fileName)
        {
            SaveToFile(fileName, System.Text.Encoding.UTF8);
        }

        private  void SaveToFile(string fileName, System.Text.Encoding encoding)
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
        /// Deserializes xml markup from file into an Comprobante object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Comprobante object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Comprobante obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Comprobante);
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

        public static bool LoadFromFile(string fileName, out Comprobante obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out Comprobante obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Comprobante LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, System.Text.Encoding.UTF8);
        }

        public new static Comprobante LoadFromFile(string fileName, System.Text.Encoding encoding)
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

        #region Convertidores enumerados
        public static c_Moneda toMoneda(String smoneda)
        {
            return (FacturaElectronica.CFDI33.c_Moneda) StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_Moneda), smoneda);
        }

        public static c_Pais toPais(String sPais)
        {
            return (FacturaElectronica.CFDI33.c_Pais)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_Pais), sPais);
        }

        public static c_RegimenFiscal ToRegimenFiscal(String sregimenfiscal)
        {
            return (FacturaElectronica.CFDI33.c_RegimenFiscal)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_RegimenFiscal), sregimenfiscal);
        }

        public static c_UsoCFDI toUsoCFDI(String sUsoCFDI)
        {
            return (FacturaElectronica.CFDI33.c_UsoCFDI)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_UsoCFDI), sUsoCFDI);
        }

        public static c_ClaveUnidad toClaveUnidad(String sclaveunidad)
        {
            return (FacturaElectronica.CFDI33.c_ClaveUnidad)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_ClaveUnidad), sclaveunidad);
        }

        public static c_ClaveProdServ toClaveProdServ(String sClaveProdServ)
        {
            return (FacturaElectronica.CFDI33.c_ClaveProdServ)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_ClaveProdServ), sClaveProdServ);
        }

        public static c_Impuesto toImpuesto(String sImpuesto)
        {
            return (FacturaElectronica.CFDI33.c_Impuesto)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_Impuesto), sImpuesto);
        }

        public static c_TipoFactor toTipoFactor(String sTipoFactor)
        {
            return (FacturaElectronica.CFDI33.c_TipoFactor)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_TipoFactor), sTipoFactor);
        }

        public static c_TasaOCuota toTasaOCuota(String sTasaOCuota)
        {
            return (FacturaElectronica.CFDI33.c_TasaOCuota)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_TasaOCuota), sTasaOCuota);
        }

        public static c_FormaPago toFormaPago(String sFormaPago)
        {
            return (FacturaElectronica.CFDI33.c_FormaPago)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_FormaPago), sFormaPago);
        }

        public static c_MetodoPago toMetodoPago(String sMetodoPago)
        {
            return (FacturaElectronica.CFDI33.c_MetodoPago)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_MetodoPago), sMetodoPago);
        }

        public static c_TipoDeComprobante toTipoDeComprobante(String sTipoDeComprobante)
        {
            return (FacturaElectronica.CFDI33.c_TipoDeComprobante)StringEnum.Parse(typeof(FacturaElectronica.CFDI33.c_TipoDeComprobante), sTipoDeComprobante);
        }

        public static bool ExisteRegimenFiscal(String sRegimenFiscal)
        {
            return StringEnum.IsStringDefined(typeof(FacturaElectronica.CFDI33.c_RegimenFiscal), sRegimenFiscal);
        }

        #endregion

    }
    
}
