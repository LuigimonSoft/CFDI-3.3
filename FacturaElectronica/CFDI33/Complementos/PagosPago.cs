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

namespace FacturaElectronica.CFDI33.Complementos
{
    public partial class PagosPago 
    {
        /// <summary>
        /// Atributo requerido para expresar la fecha y hora en la que el beneficiario recibe el pago. Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.En caso de no contar con la hora se debe registrar 12:00:00.
        /// </summary>
        [XmlIgnore]
        public System.DateTime FechaPago { set; get; }

        /// <summary>
        /// Atributo requerido para expresar el importe del pago.
        /// </summary>
        [XmlIgnore]
        public t_Importe Monto { set; get; }


        /// <summary>
        /// Atributo condicional para expresar la clave RFC de la entidad emisora de la cuenta origen, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc., en caso de ser extranjero colocar XEXX010101000, considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlIgnore]
        public t_RFC RfcEmisorCtaOrd { set; get; }

        /// <summary>
        /// Atributo condicional para expresar la clave RFC de la entidad operadora de la cuenta destino, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlIgnore]
        public t_RFC_PM RfcEmisorCtaBen { set; get; }
    }
}
