using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33.Complementos
{
    public partial class PagosPagoDoctoRelacionado
    {
        private t_Importe _ImpSaldoAnt;
        private t_Importe _ImpPagado;
        private t_Importe _ImpSaldoInsoluto;

        /// <summary>
        /// Atributo condicional para expresar el monto del saldo insoluto de la parcialidad anterior. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.En el caso de que sea la primer parcialidad este campo debe contener el importe total del documento relacionado.
        /// </summary>
        [XmlIgnore]
        public t_Importe ImpSaldoAnt {
            set
            {
                strImpSaldoAntSpecified = true;
                _ImpSaldoAnt = value;
            }
            get { return _ImpSaldoAnt; } }
        /// <summary>
        /// Atributo condicional para expresar el importe pagado para el documento relacionado. Es obligatorio cuando exista más de un documento relacionado o cuando existe un documento relacionado y el TipoCambioDR tiene un valor.
        /// </summary>
        [XmlIgnore]
        public t_Importe ImpPagado {
            set
            {
                strImpPagadoSpecified = true;
                _ImpPagado = value;
            }
            get { return _ImpPagado; }
        }

        /// <summary>
        /// Atributo condicional para expresar la diferencia entre el importe del saldo anterior y el monto del pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        /// </summary>
        [XmlIgnore]
        public t_Importe ImpSaldoInsoluto {
            set
            {
                strImpSaldoInsolutoSpecified = true;
                _ImpSaldoInsoluto = value;
            }
            get { return _ImpSaldoInsoluto; }
        }
    }
}
