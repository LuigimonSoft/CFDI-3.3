# CFDI-3.3
Libreria para la generacion y lectura de un Comprobante de factura electronica SAT CFDI 3.3 Mexico

Tambien es posible la generacion y lectura del Comprobante de recibo de pago SAT 

### Ejemplo

```cs

private String PosicionCertificado = @"C:\CSDAAA010101AAA\Cert_Sellos\CSD_Pruebas_CFDI_LAN7008173R5\";  // carpeta en la que se encuentra el certificado y su archivo key
private String ArchivoKey = "CSD_Pruebas_CFDI_LAN7008173R5.key"; // Archivo key

private String ArchivoCertificado = "CSD_Pruebas_CFDI_LAN7008173R5.cer"; // Archivo cer
private String ContraseñaCertificado = "12345678a"; // contrasena del certificado
private string RFC = "aaa010101aaa"; //No es necesario ya que se toma del certificado

//crear un nuevo comprobante CFDI para la version 3.3
            FacturaElectronica.CFDI33.Comprobante Comprobante = new FacturaElectronica.CFDI33.Comprobante(new FacturaElectronica.Certificado(PosicionCertificado + ArchivoCertificado, PosicionCertificado + ArchivoKey, ContraseñaCertificado));
            Comprobante.Serie = "MER";
            Comprobante.Folio = "8223"; //dato no obligatorio
            Comprobante.Fecha = System.DateTime.Now;
            
            Comprobante.SubTotal = new FacturaElectronica.CFDI33.t_Importe(32700);
            Comprobante.Total = new FacturaElectronica.CFDI33.t_Importe(58860);
            Comprobante.TipoDeComprobante = FacturaElectronica.CFDI33.c_TipoDeComprobante.I;

            Comprobante.TipoCambio = 1; 

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
            String XML=String.Empty;

            txtXML.Text = String.Empty;
            
            if (Comprobante.GenerarPreCFDI(out XML, out Errores, true))
            {
                txtXML.Text = XML;
                ComprobanteT = Comprobante;
            }

```
