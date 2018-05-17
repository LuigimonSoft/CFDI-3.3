using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_UsoCFDI
    {
        /// <summary>
        /// Adquisición de mercancias
        /// </summary>
        [StringValue("G01")]
        G01,

        /// <summary>
        /// Devoluciones, descuentos o bonificaciones
        /// </summary>
        [StringValue("G02")]
        G02,

        /// <summary>
        /// Gastos en general
        /// </summary>
        [StringValue("G03")]
        G03,

        /// <summary>
        /// Construcciones
        /// </summary>
        [StringValue("I01")]
        I01,

        /// <summary>
        /// Mobilario y equipo de oficina por inversiones
        /// </summary>
        [StringValue("I02")]
        I02,

        /// <summary>
        /// Equipo de transporte
        /// </summary>
        [StringValue("I03")]
        I03,

        /// <summary>
        /// Equipo de computo y accesorios
        /// </summary>
        [StringValue("I04")]
        I04,

        /// <summary>
        /// Dados, troqueles, moldes, matrices y herramental
        /// </summary>
        [StringValue("I05")]
        I05,

        /// <summary>
        /// Comunicaciones telefónicas
        /// </summary>
        [StringValue("I06")]
        I06,

        /// <summary>
        /// Comunicaciones satelitales
        /// </summary>
        [StringValue("I07")]
        I07,

        /// <summary>
        /// Otra maquinaria y equipo
        /// </summary>
        [StringValue("I08")]
        I08,

        /// <summary>
        /// Honorarios médicos, dentales y gastos hospitalarios.
        /// </summary>
        [StringValue("D01")]
        D01,

        /// <summary>
        /// Gastos médicos por incapacidad o discapacidad
        /// </summary>
        [StringValue("D02")]
        D02,

        /// <summary>
        /// Gastos funerales.
        /// </summary>
        [StringValue("D03")]
        D03,

        /// <summary>
        /// Donativos.
        /// </summary>
        [StringValue("D04")]
        D04,

        /// <summary>
        /// Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).
        /// </summary>
        [StringValue("D05")]
        D05,

        /// <summary>
        /// Aportaciones voluntarias al SAR.
        /// </summary>
        [StringValue("D06")]
        D06,

        /// <summary>
        /// Primas por seguros de gastos médicos.
        /// </summary>
        [StringValue("D07")]
        D07,

        /// <summary>
        /// Gastos de transportación escolar obligatoria.
        /// </summary>
        [StringValue("D08")]
        D08,

        /// <summary>
        /// Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.
        /// </summary>
        [StringValue("D09")]
        D09,

        /// <summary>
        /// Pagos por servicios educativos (colegiaturas)
        /// </summary>
        [StringValue("D10")]
        D10,

        /// <summary>
        /// Por definir
        /// </summary>
        [StringValue("P01")]
        P01,

    }

}
