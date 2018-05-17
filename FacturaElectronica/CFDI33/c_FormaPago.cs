using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_FormaPago
    {
        /// <summary>
        /// Efectivo
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        [StringValue("01")]
        FormaPago_1 = 1,

        /// <summary>
        /// Cheque nominativo
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        [StringValue("02")]
        FormaPago_2 = 2,

        /// <summary>
        /// Transferencia electrónica de fondos
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        [StringValue("03")]
        FormaPago_3 = 3,

        /// <summary>
        /// Tarjeta de crédito
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        [StringValue("04")]
        FormaPago_4 = 4,

        /// <summary>
        /// Monedero electrónico
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        [StringValue("05")]
        FormaPago_5 = 5,

        /// <summary>
        /// Dinero electrónico
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        [StringValue("06")]
        FormaPago_6 = 6,

        /// <summary>
        /// Vales de despensa
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        [StringValue("08")]
        FormaPago_8 = 8,

        /// <summary>
        /// Dación en pago
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        [StringValue("12")]
        FormaPago_12 = 12,

        /// <summary>
        /// Pago por subrogación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        [StringValue("13")]
        FormaPago_13 = 13,

        /// <summary>
        /// Pago por consignación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        [StringValue("14")]
        FormaPago_14 = 14,

        /// <summary>
        /// Condonación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        [StringValue("15")]
        FormaPago_15 = 15,

        /// <summary>
        /// Compensación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        [StringValue("17")]
        FormaPago_17 = 17,

        /// <summary>
        /// Novación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        [StringValue("23")]
        FormaPago_23 = 23,

        /// <summary>
        /// Confusión
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        [StringValue("24")]
        FormaPago_24,

        /// <summary>
        /// Remisión de deuda
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        [StringValue("25")]
        FormaPago_25 = 25,

        /// <summary>
        /// Prescripción o caducidad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        [StringValue("26")]
        FormaPago_26 = 26,

        /// <summary>
        /// A satisfacción del acreedor
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        [StringValue("27")]
        FormaPago_27 = 27,

        /// <summary>
        /// Tarjeta de débito
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        [StringValue("28")]
        FormaPago_28 = 28,

        /// <summary>
        /// Tarjeta de servicios
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        [StringValue("29")]
        FormaPago_29 = 29,

        /// <summary>
        /// Por definir
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        [StringValue("99")]
        FormaPago_99 = 99,

    }

}
