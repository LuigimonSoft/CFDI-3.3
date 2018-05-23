using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;
using Encoder = System.Text.Encoder;

namespace FacturaElectronica.CFDI33.Complementos
{
    public partial class TimbreFiscalDigital
    {
        [XmlIgnore]
        public String PosicionEsquema { set; get; }
        public bool GenerarQR(String RFCEmisor,String RFCReceptor,String Total)
        {
            bool Resultado = false;
            QRTexto = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?&" + "id=" + UUID + "&fe=" + SelloCFD.Substring(SelloCFD.Length-8,8) + "&re="+RFCEmisor+"&rr="+RFCReceptor+"&tt="+Total;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRTexto, QRCodeGenerator.ECCLevel.M);
            QRCode qrCode = new QRCode(qrCodeData);
            System.IO.MemoryStream mem = new System.IO.MemoryStream();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 75L);
            qrCode.GetGraphic(20).Save(mem, GetEncoder(ImageFormat.Jpeg),encoderParameters);
            QR = mem.ToArray();
            Resultado = true;
            mem.Close();
            mem.Dispose();
            qrCode.Dispose();
            GC.WaitForFullGCComplete();
            return Resultado;
        }

        public static bool GenerarQRManualmente(String RFCEmisor, String RFCReceptor, String Total,String UUID,String  SelloCFD, out byte[] QRRes)
        {
            bool Resultado = false;
             String QRTexto = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?&" + "id=" + UUID + "&fe=" + SelloCFD.Substring(SelloCFD.Length - 8, 8) + "&re=" + RFCEmisor + "&rr=" + RFCReceptor + "&tt=" + Total;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRTexto, QRCodeGenerator.ECCLevel.M);
            QRCode qrCode = new QRCode(qrCodeData);
            System.IO.MemoryStream mem = new System.IO.MemoryStream();
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 75L);
            qrCode.GetGraphic(5).Save(mem, GetEncoder(ImageFormat.Jpeg), encoderParameters);
            QRRes = mem.ToArray();
            Resultado = true;
            mem.Close();
            mem.Dispose();
            qrCode.Dispose();
            GC.WaitForFullGCComplete();
            return Resultado;
        }

        [XmlIgnore]
        public String QRTexto { set; get; }

        [XmlIgnore]
        public byte[] QR { set; get; }
        
        [XmlIgnore]
        public String CadenaOriginalTimbre { set; get; }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        public Boolean GenerarCadenaOriginal(String XML, out List<String> Errores, bool Local = false)
        {
            Boolean Resultado = false;
            CadenaOriginalTimbre = String.Empty;
            Errores = new List<string>();
            try
            {
                String ArchivoXSLT = "\\cadenaoriginal_TFD_1_1.xslt";

                if (System.IO.File.Exists(PosicionEsquema + ArchivoXSLT))
                {
                    System.IO.StringReader XmlSR = new System.IO.StringReader(XML);
                    System.Xml.XPath.XPathDocument DocXml = new System.Xml.XPath.XPathDocument(XmlSR);
                    System.Xml.Xsl.XslTransform elXSLt = new System.Xml.Xsl.XslTransform();

                    elXSLt.Load(PosicionEsquema + ArchivoXSLT);
                    System.IO.Stream str = new System.IO.MemoryStream();
                    elXSLt.Transform(DocXml, null, str);
                    str.Position = 0;
                    System.IO.StreamReader reader = new System.IO.StreamReader(str);
                    CadenaOriginalTimbre = reader.ReadToEnd();
                    Resultado = true;
                    reader.Close();
                }
                else
                {
                    //cErrores ErrT = new cErrores(1061);
                    Errores.Add("No se encontro el archivo " + PosicionEsquema + ArchivoXSLT);

                }
            }
            catch (Exception e)
            {
                Errores.Add(e.Message);
            }

            return Resultado;
        }

        
    }
}
