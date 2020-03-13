using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProbadorCFDI33
{
    public partial class Form1 : Form
    {

        //Datos Certificado
        private String PosicionCertificado = @"E:\CSDAAA010101AAA\Cert_Sellos\CSD_Pruebas_CFDI_LAN7008173R5\";  // carpeta en la que se encuentra el certificado y su archivo key
        private String ArchivoKey = "CSD_Pruebas_CFDI_LAN7008173R5.key"; // Archivo key

        private String ArchivoCertificado = "CSD_Pruebas_CFDI_LAN7008173R5.cer"; // Archivo cer
        private String ContraseñaCertificado = "12345678a"; // contrasena del certificado

        
        private string RFC = "aaa010101aaa"; //No es necesario ya que se toma del certificado


        private FacturaElectronica.CFDI33.Comprobante ComprobanteT; // Nuestro comprobante a generar

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCFDI_Click(object sender, EventArgs e)
        {
            
            //crear un nuevo comprobante CFDI para la version 3.3
            FacturaElectronica.CFDI33.Comprobante Comprobante = new FacturaElectronica.CFDI33.Comprobante(new FacturaElectronica.Certificado(PosicionCertificado + ArchivoCertificado, PosicionCertificado + ArchivoKey, ContraseñaCertificado));
            Comprobante.Serie = "MER";
            Comprobante.Folio = "8223"; //dato no obligatorio
            Comprobante.Fecha = System.DateTime.Now;
            
            Comprobante.SubTotal = new FacturaElectronica.CFDI33.t_Importe(32700);
            Comprobante.Total = new FacturaElectronica.CFDI33.t_Importe(58860);
            Comprobante.TipoDeComprobante = FacturaElectronica.CFDI33.c_TipoDeComprobante.I;

            Comprobante.TipoCambio = 1; // Solo porque PAX lo solicita a fuerzas

            Comprobante.Moneda = FacturaElectronica.CFDI33.c_Moneda.MXN;
            Comprobante.Moneda = FacturaElectronica.CFDI33.Comprobante.toMoneda("MXN");
            Comprobante.FormaPago = FacturaElectronica.CFDI33.Comprobante.toFormaPago("01");




            Comprobante.LugarExpedicion = "08500"; //solo Codigo postal



            //Campo nuevo en Emisor
            Comprobante.Emisor.RegimenFiscal = FacturaElectronica.CFDI33.c_RegimenFiscal.RegimenFiscal601;
            Comprobante.Emisor.RegimenFiscal = (FacturaElectronica.CFDI33.c_RegimenFiscal)601;
            Comprobante.Emisor.RegimenFiscal = FacturaElectronica.CFDI33.Comprobante.ToRegimenFiscal("601");

            //Llenado de datos del emisor
            //Comprobante.Emisor.Rfc = new t_RFC(RFC); // El RFC fue llenado directamente desde el certificado
            Comprobante.Emisor.Nombre = "Emisor de prueba SA de CV";


            //Llenado de datos del receptor
            Comprobante.Receptor.Rfc = new FacturaElectronica.CFDI33.t_RFC("LFB230312S22");
            Comprobante.Receptor.Nombre = "Receptor de prueba SA de CV";


            /* solo para extranjeros
            Comprobante.Receptor.ResidenciaFiscal = c_Pais.USA;
            Comprobante.Receptor.ResidenciaFiscal = LFFacturaElectronica.CFDI33.Comprobante.toPais("USA");
            */


            Comprobante.Receptor.UsoCFDI = FacturaElectronica.CFDI33.c_UsoCFDI.G01;
            Comprobante.Receptor.UsoCFDI = FacturaElectronica.CFDI33.Comprobante.toUsoCFDI("G01");
            //Comprobante.Receptor.Domicilio.codigoPostal = "03810";


            //Crear un nuevo concepto
            FacturaElectronica.CFDI33.ComprobanteConcepto Concepto1 = new FacturaElectronica.CFDI33.ComprobanteConcepto();
            Concepto1.Cantidad = 1;
            Concepto1.Descripcion = "Software";
            Concepto1.ValorUnitario = new FacturaElectronica.CFDI33.t_Importe(1000);
            Concepto1.Importe = new FacturaElectronica.CFDI33.t_Importe(1000);

            Concepto1.ClaveUnidad = FacturaElectronica.CFDI33.c_ClaveUnidad.ClaveUnidad_KGM; // Kilogramos
            Concepto1.ClaveUnidad = FacturaElectronica.CFDI33.Comprobante.toClaveUnidad("KGM");
            //Concepto1.Unidad = "Servicio"; // Especificamos unidad manualmente


            Concepto1.ClaveProdServ = FacturaElectronica.CFDI33.c_ClaveProdServ.ClaveProdServ_43231500;
            Concepto1.ClaveProdServ = (FacturaElectronica.CFDI33.c_ClaveProdServ)43231500;
            Concepto1.ClaveProdServ = FacturaElectronica.CFDI33.Comprobante.toClaveProdServ("43231500");

            Concepto1.Impuestos = new FacturaElectronica.CFDI33.ComprobanteConceptoImpuestos();
            Concepto1.Impuestos.Traslados = new List<FacturaElectronica.CFDI33.ComprobanteConceptoImpuestosTraslado>();

            FacturaElectronica.CFDI33.ComprobanteConceptoImpuestosTraslado TrasladoConcepto = new FacturaElectronica.CFDI33.ComprobanteConceptoImpuestosTraslado();
            TrasladoConcepto.Base = 1000;

            TrasladoConcepto.Impuesto = FacturaElectronica.CFDI33.c_Impuesto.IVA;
            //TrasladoConcepto.Impuesto = FacturaElectronica.CFDI33.Comprobante.toImpuesto("IVA"); // mediante texto

            TrasladoConcepto.TipoFactor = FacturaElectronica.CFDI33.c_TipoFactor.Tasa;
            //TrasladoConcepto.TipoFactor = FacturaElectronica.CFDI33.Comprobante.toTipoFactor("Tasa"); // mediante texto

            /*----------------- Tasa o cuota -----------------*/
            TrasladoConcepto.TasaOCuota = 16;
            /*TrasladoConcepto.TasaOCuota = LFFacturaElectronica.CFDI33.Comprobante.toTasaOCuota("0.160000");
            TrasladoConcepto.TasaOCuota = (c_TasaOCuota) 16;*/


            TrasladoConcepto.Importe = new FacturaElectronica.CFDI33.t_Importe(160);

            Concepto1.Impuestos.Traslados.Add(TrasladoConcepto);

            Comprobante.Impuestos = new FacturaElectronica.CFDI33.ComprobanteImpuestos();
            Comprobante.Impuestos.Traslados = new List<FacturaElectronica.CFDI33.ComprobanteImpuestosTraslado>();

            Comprobante.Impuestos.TotalImpuestosTrasladados = new FacturaElectronica.CFDI33.t_Importe(160);

            Comprobante.Conceptos.Add(Concepto1);

            FacturaElectronica.CFDI33.ComprobanteImpuestosTraslado Traslado = new FacturaElectronica.CFDI33.ComprobanteImpuestosTraslado();
            Traslado.Impuesto = FacturaElectronica.CFDI33.c_Impuesto.IVA;
            //Traslado.Impuesto = FacturaElectronica.CFDI33.Comprobante.toImpuesto("IVA"); // mediante texto

            Traslado.TipoFactor = FacturaElectronica.CFDI33.c_TipoFactor.Tasa;
            //Traslado.TipoFactor = FacturaElectronica.CFDI33.Comprobante.toTipoFactor("Tasa"); // mediante texto

            /*----------------- Tasa o cuota -----------------*/
            Traslado.TasaOCuota = FacturaElectronica.CFDI33.c_TasaOCuota.TasaOCuota_16;
            /*Traslado.TasaOCuota = FacturaElectronica.CFDI33.Comprobante.toTasaOCuota("0.160000"); // mediante valores 
            Traslado.TasaOCuota = (FacturaElectronica.CFDI33.c_TasaOCuota)16;*/


            Traslado.Importe = new FacturaElectronica.CFDI33.t_Importe(160);

            Comprobante.Impuestos.Traslados.Add(Traslado);

            List<String> Errores;
            String XML;

            txtXML.Text = String.Empty;
            /*
            LFFacturaElectronica.CFDI33.Complementos.Pagos Pagos = new LFFacturaElectronica.CFDI33.Complementos.Pagos();

            LFFacturaElectronica.CFDI33.Complementos.PagosPago Pago = new LFFacturaElectronica.CFDI33.Complementos.PagosPago();
            Pago.FechaPago=System.DateTime.Now;
            Pago.FormaDePagoP = (c_FormaPago) 6;
            Pago.MonedaP = c_Moneda.MXN;
            Pago.Monto = new t_Importe(10000);
            Pago.RfcEmisorCtaOrd = Comprobante.Receptor.Rfc;
            Pago.CtaOrdenante = "1234567890";
            
            Pagos.Pago.Add(Pago);

            Comprobante.Pagos = Pagos;*/

            Comprobante.Nomina = new FacturaElectronica.CFDI33.Complementos.Nomina12.Nomina();
            Comprobante.Nomina.FechaFinalPago = new DateTime(2020 , 1, 15, 0, 0, 0);
            Comprobante.Nomina.FechaInicialPago = new DateTime(2020, 01, 01, 0, 0,0);
            Comprobante.Nomina.FechaPago = new DateTime(2020, 01, 15, 0, 0, 0);
            Comprobante.Nomina.NumDiasPagados = new decimal(15.208);
            Comprobante.Nomina.TipoNomina = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoNomina.O;
            Comprobante.Nomina.TotalDeducciones = new decimal(1151.13);
            Comprobante.Nomina.TotalOtrosPagos = new decimal(84.37);
            Comprobante.Nomina.TotalPercepciones = new decimal(1873.97);

            Comprobante.Nomina.Emisor = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaEmisor();
            Comprobante.Nomina.Emisor.RegistroPatronal = "Y6653628104";

            Comprobante.Nomina.Receptor = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaReceptor();
            Comprobante.Nomina.Receptor.Antigüedad = "P15W";
            Comprobante.Nomina.Receptor.Banco = FacturaElectronica.CFDI33.Complementos.Nomina12.c_Banco.Banco014;
            Comprobante.Nomina.Receptor.ClaveEntFed = FacturaElectronica.CFDI33.Complementos.Nomina12.c_Estado.DIF;
            Comprobante.Nomina.Receptor.Curp = "HEPN701115MDFRRR06";
            Comprobante.Nomina.Receptor.Departamento = "ADMINISTRACION";
            Comprobante.Nomina.Receptor.FechaInicioRelLaboral = new DateTime(2019, 10, 01, 0, 0, 0);
            Comprobante.Nomina.Receptor.NumEmpleado = "8";
            Comprobante.Nomina.Receptor.NumSeguridadSocial = "39907010506";
            Comprobante.Nomina.Receptor.PeriodicidadPago = FacturaElectronica.CFDI33.Complementos.Nomina12.c_PeriodicidadPago.Periodo04;
            Comprobante.Nomina.Receptor.Puesto = "AUXILIAR";
            Comprobante.Nomina.Receptor.RiesgoPuesto = FacturaElectronica.CFDI33.Complementos.Nomina12.c_RiesgoPuesto.Riesgo1;
            Comprobante.Nomina.Receptor.SalarioBaseCotApor = new decimal(128.79);
            Comprobante.Nomina.Receptor.SalarioDiarioIntegrado = new decimal(128.79);
            Comprobante.Nomina.Receptor.Sindicalizado = FacturaElectronica.CFDI33.Complementos.Nomina12.NominaReceptorSindicalizado.No;
            Comprobante.Nomina.Receptor.TipoContrato = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoContrato.TipoContrato01;
            Comprobante.Nomina.Receptor.TipoJornada = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoJornada.TipoJornada01;
            Comprobante.Nomina.Receptor.TipoRegimen = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoRegimen.TipoRegimen02;

            Comprobante.Nomina.Percepciones = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaPercepciones();
            Comprobante.Nomina.Percepciones.TotalExento = 0;
            Comprobante.Nomina.Percepciones.TotalGravado = new decimal(1873.97);
            Comprobante.Nomina.Percepciones.TotalSueldos = new decimal(1873.97);

            FacturaElectronica.CFDI33.Complementos.Nomina12.NominaPercepcionesPercepcion percepcion = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaPercepcionesPercepcion();
            percepcion.Clave = "P001";
            percepcion.Concepto = "SUELDO";
            percepcion.ImporteExento = 0;
            percepcion.ImporteGravado = new decimal(1873.97);
            percepcion.TipoPercepcion = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoPercepcion.TipoPercepcion001;
            Comprobante.Nomina.Percepciones.Percepcion.Add(percepcion);

            Comprobante.Nomina.Deducciones = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaDeducciones();
            Comprobante.Nomina.Deducciones.TotalOtrasDeducciones = new decimal(1151.13);
            FacturaElectronica.CFDI33.Complementos.Nomina12.NominaDeduccionesDeduccion deduccion = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaDeduccionesDeduccion();
            deduccion.Clave = "D094";
            deduccion.Concepto = "CREDITO INFONAVIT";
            deduccion.Importe = new decimal(1151.13);
            deduccion.TipoDeduccion = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoDeduccion.TipoDeduccion010;
            Comprobante.Nomina.Deducciones.Deduccion.Add(deduccion);

            FacturaElectronica.CFDI33.Complementos.Nomina12.NominaOtroPago otropago = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaOtroPago();
            otropago.Clave = "D100";
            otropago.Concepto = "SUBSIDIO PARA EL EMPLEO";
            otropago.Importe = new decimal(84.37);
            otropago.TipoOtroPago = FacturaElectronica.CFDI33.Complementos.Nomina12.c_TipoOtroPago.TipoOtroPago002;
            otropago.SubsidioAlEmpleo = new FacturaElectronica.CFDI33.Complementos.Nomina12.NominaOtroPagoSubsidioAlEmpleo();
            otropago.SubsidioAlEmpleo.SubsidioCausado = new decimal(191.33);
            Comprobante.Nomina.OtrosPagos = new List<FacturaElectronica.CFDI33.Complementos.Nomina12.NominaOtroPago>();
            Comprobante.Nomina.OtrosPagos.Add(otropago);

            string Error;
            Comprobante.Nomina.GenerarXML(out XML, out Error);

           if (Comprobante.GenerarPreCFDI(out XML, out Errores, true))
            {
                txtXML.Text = XML;
                ComprobanteT = Comprobante;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<string> Errores;
            FacturaElectronica.CFDI33.Comprobante Comprobante = FacturaElectronica.CFDI33.Comprobante.CargarXMLCFDI(txtXML.Text, out Errores, true);
        }
    }
}
