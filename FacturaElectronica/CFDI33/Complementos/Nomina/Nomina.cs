using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    public partial class Nomina
    {
        private void init()
        {

        }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha efectiva de erogación del gasto. Se expresa en la forma aaaa-mm-dd, de acuerdo con la especificación ISO 8601.
        /// </summary>
        [XmlIgnore]
        public System.DateTime FechaPago { set; get; }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha inicial del período de pago. Se expresa en la forma aaaa-mm-dd, de acuerdo con la especificación ISO 8601.
        /// </summary>
        [XmlIgnore]
        public System.DateTime FechaInicialPago { set; get; }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha final del período de pago. Se expresa en la forma aaaa-mm-dd, de acuerdo con la especificación ISO 8601.
        /// </summary>
        [XmlIgnore]
        public System.DateTime FechaFinalPago { set; get; }


        public bool GenerarXML(out String XML, out String Errores)
        {
            XML = String.Empty;
            Errores = String.Empty;
            bool Resultado = false;

            try
            {

                if (String.IsNullOrEmpty(Errores))
                {
                    XML = Serialize(System.Text.Encoding.UTF8);
                    XML = XML.Replace("&amp;apos;", "&apos;").Replace("&amp;quot;", "&quot;").Replace("&amp;lt;", "&lt;").Replace("&amp;gt;", "&gt;").Replace("&amp;amp;", "&amp;");
                    return (!String.IsNullOrEmpty(XML));
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    Errores += ex.Message + " innerex: " + ex.InnerException.Message;
                else
                    Errores += ex.Message;
            }


            return Resultado;
        }
    }
}
