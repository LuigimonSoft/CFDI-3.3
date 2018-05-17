using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Security;

namespace FacturaElectronica
{
    public class Certificado
    {
        private System.Data.DataTable CA;
        private String sArchivoKey;
        private String sContraseña;
        public SecureString ContrasenaSegura { set; get; }

        public byte[] bCertificado { set; get; }
        public byte[] bKey { set; get; }
        
        public String CertificadoBase64 { set; get; }

        public String EmisorCertificado { set; get; }

        public Boolean EmitidoAutoridadCertificadora { set; get; }

        public Boolean esKeyCertificado { set; get; }

        public String RFCCertificado { set; get; }

        public Certificado() { }
        public Certificado(byte[] ContenidoCertificado)
        {
            try
            {
                if (ContenidoCertificado != null)
                {
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error constructor sellador byte Error:" + e.Message);
            }

        }

        public Certificado(String ArchivoCertificado)
        {
            Byte[] ContenidoCertificado = new Byte[0];
            try
            {
                System.IO.FileStream ArchCertificado = new FileStream(ArchivoCertificado, System.IO.FileMode.Open, FileAccess.Read);
                ContenidoCertificado = new Byte[ArchCertificado.Length];
                ArchCertificado.Read(ContenidoCertificado, 0, System.Convert.ToInt32(ArchCertificado.Length));
                ArchCertificado.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            try
            {
                if (ContenidoCertificado.Length > 1)
                {
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);
                }
                else
                    throw new Exception("No se pudo leer el contenido del certificado");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Certificado(String ArchivoCertificado, String ArchivoKey, String Contraseña, String ArchivoListaCA)
        {
            Byte[] ContenidoCertificado = new Byte[0];
            try
            {
                System.IO.FileStream ArchCertificado = new FileStream(ArchivoCertificado, System.IO.FileMode.Open, FileAccess.Read);
                ContenidoCertificado = new Byte[ArchCertificado.Length];
                ArchCertificado.Read(ContenidoCertificado, 0, System.Convert.ToInt32(ArchCertificado.Length));
                ArchCertificado.Close();
                if (System.IO.File.Exists(ArchivoKey))
                    sArchivoKey = ArchivoKey;
                else
                    throw new Exception("No se pudo encontrar el archivo .key");
                sContraseña = Contraseña;
            }
            catch (Exception e)
            {
                throw;
            }
            try
            {
                if (ContenidoCertificado.Length > 1)
                {
                    CargarListaCA(ArchivoListaCA);
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);

                }
                else
                    throw new Exception("No se pudo leer el contenido del certificado");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Certificado(String ArchivoCertificado, String ArchivoKey, String Contraseña)
        {
            Byte[] ContenidoCertificado = new Byte[0];
            try
            {
                System.IO.FileStream ArchCertificado = new FileStream(ArchivoCertificado, System.IO.FileMode.Open, FileAccess.Read);
                ContenidoCertificado = new Byte[ArchCertificado.Length];
                ArchCertificado.Read(ContenidoCertificado, 0, System.Convert.ToInt32(ArchCertificado.Length));
                ArchCertificado.Close();
                if (System.IO.File.Exists(ArchivoKey))
                {
                    sArchivoKey = ArchivoKey;
                    bKey = SSLKey.opensslkey.GetFileBytes(ArchivoKey);
                    ContrasenaSegura = ConvertToSecureString(Contraseña);
                }
                else
                    throw new Exception("No se pudo encontrar el archivo .key");
                sContraseña = Contraseña;
            }
            catch (Exception e)
            {
                throw;
            }
            try
            {
                if (ContenidoCertificado.Length > 1)
                {
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);
                    bCertificado = ContenidoCertificado;
                }
                else
                    throw new Exception("No se pudo leer el contenido del certificado");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Certificado(byte[] ContenidoCertificado, String ArchivoKey, String Contraseña, String ArchivoListaCA)
        {
            try
            {
                if (ContenidoCertificado != null)
                {
                    CargarListaCA(ArchivoListaCA);
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);
                    if (System.IO.File.Exists(ArchivoKey))
                        sArchivoKey = ArchivoKey;
                    else
                        throw new Exception("No se pudo encontrar el archivo .key");
                    sContraseña = Contraseña;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error constructor sellador byte Error:" + e.Message);
            }

        }

        public Certificado(byte[] ContenidoCertificado, String ContenidoArchivoKey, String Contraseña)
        {
            try
            {
                if (ContenidoCertificado != null)
                {
                    Analizar(ContenidoCertificado);
                    CertificadoBase64 = System.Convert.ToBase64String(ContenidoCertificado);
                    bKey = System.Convert.FromBase64String(ContenidoArchivoKey);
                    sContraseña = Contraseña;
                    ContrasenaSegura = ConvertToSecureString(Contraseña);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error constructor sellador byte Error:" + e.Message);
            }

        }

        public void CargarListaCA(String ArchivoListaCA)
        {
            if (System.IO.File.Exists(ArchivoListaCA))
            {
                System.Data.DataSet DS = new System.Data.DataSet();
                DS.ReadXml(ArchivoListaCA);
                if (DS.Tables.Count > 0)
                {
                    CA = DS.Tables["Authority"];
                }
            }
            else
                throw new Exception("No se puede encontrar el archivo " + ArchivoListaCA);
        }

        private bool GetCertPublicKey(X509Certificate cert, out Byte[] CerModulus, out Byte[] CerExponent)
        {
            byte[] publickeyblob;
            byte[] encodedpubkey = cert.GetPublicKey(); //ASN.1 encoded public key
            bool verbose = false;

            uint blobbytes = 0;
            if (verbose)
            {
                Console.WriteLine();
                //showBytes("Encoded publickey", encodedpubkey);
                Console.WriteLine();
            }
            if (SSLKey.Win32.CryptDecodeObject(SSLKey.Win32.ENCODING_TYPE, SSLKey.Win32.RSA_CSP_PUBLICKEYBLOB, encodedpubkey, (uint)encodedpubkey.Length, 0, null, ref blobbytes))
            {
                publickeyblob = new byte[blobbytes];
                if (SSLKey.Win32.CryptDecodeObject(SSLKey.Win32.ENCODING_TYPE, SSLKey.Win32.RSA_CSP_PUBLICKEYBLOB,
                                            encodedpubkey, (uint)encodedpubkey.Length, 0, publickeyblob,
                                            ref blobbytes)) ;
                /*if (verbose)
                    showBytes("CryptoAPI publickeyblob", publickeyblob);*/
            }
            else
            {
                Console.WriteLine("Couldn't decode publickeyblob from certificate publickey");
                CerModulus = new byte[0];
                CerExponent = new byte[0];
                return false;
            }

            SSLKey.Win32.PUBKEYBLOBHEADERS pkheaders = new SSLKey.Win32.PUBKEYBLOBHEADERS();
            int headerslength = Marshal.SizeOf(pkheaders);
            IntPtr buffer = Marshal.AllocHGlobal(headerslength);
            Marshal.Copy(publickeyblob, 0, buffer, headerslength);
            pkheaders = (SSLKey.Win32.PUBKEYBLOBHEADERS)Marshal.PtrToStructure(buffer, typeof(SSLKey.Win32.PUBKEYBLOBHEADERS));
            Marshal.FreeHGlobal(buffer);

            if (verbose)
            {
                Console.WriteLine("\n ---- PUBLICKEYBLOB headers ------");
                Console.WriteLine("  btype     {0}", pkheaders.bType);
                Console.WriteLine("  bversion  {0}", pkheaders.bVersion);
                Console.WriteLine("  reserved  {0}", pkheaders.reserved);
                Console.WriteLine("  aiKeyAlg  0x{0:x8}", pkheaders.aiKeyAlg);
                String magicstring = (new
                    ASCIIEncoding()).GetString(BitConverter.GetBytes
                                                   (pkheaders.magic));
                Console.WriteLine("  magic     0x{0:x8}     '{1}'",
                                  pkheaders.magic, magicstring);
                Console.WriteLine("  bitlen    {0}", pkheaders.bitlen);
                Console.WriteLine("  pubexp    {0}", pkheaders.pubexp);
                Console.WriteLine(" --------------------------------");
            }
            //-----  Get public key size in bits -------------
            //this.certkeysize = pkheaders.bitlen;

            //-----  Get public exponent -------------
            byte[] exponent = BitConverter.GetBytes(pkheaders.pubexp); //little-endian ordered 
            Array.Reverse(exponent); //convert to big-endian order
            CerExponent = exponent;
            /*if (verbose)
                showBytes("\nPublic key exponent (big-endian order):", exponent);*/

            //-----  Get modulus  -------------
            int modulusbytes = (int)pkheaders.bitlen / 8;
            byte[] modulus = new byte[modulusbytes];
            try
            {
                Array.Copy(publickeyblob, headerslength, modulus, 0,
                           modulusbytes);
                Array.Reverse(modulus); //convert from little to big-endian ordering.
                CerModulus = modulus;
                /*if (verbose)
                    showBytes("\nPublic key modulus  (big-endian order):", modulus);*/
            }
            catch (Exception)
            {
                Console.WriteLine("Problem getting modulus from publickeyblob");
                CerModulus = new byte[0];
                CerExponent = new byte[0];
                return false;
            }
            return true;
        }


        private void Analizar(Byte[] ContenidoCertificado)
        {
            try
            {
                System.Security.Cryptography.X509Certificates.X509Certificate2 cer = new System.Security.Cryptography.X509Certificates.X509Certificate2(ContenidoCertificado);
                NumeroSerie = InvertirStr(System.Text.Encoding.ASCII.GetString(cer.GetSerialNumber()));
                FechaFinCertificado = System.Convert.ToDateTime(cer.GetExpirationDateString());
                FechaInicioCertificado = System.Convert.ToDateTime(cer.GetEffectiveDateString());
                EmisorCertificado = cer.GetNameInfo(X509NameType.SimpleName, true);

                if (CA != null)
                {
                    foreach (System.Data.DataRow FilaCA in CA.Rows)
                    {
                        System.Security.Cryptography.X509Certificates.X509Certificate2 cerSAT = new System.Security.Cryptography.X509Certificates.X509Certificate2(System.Convert.FromBase64String(FilaCA["base64"].ToString()));
                        if (System.Convert.ToBase64String(cer.IssuerName.RawData) == System.Convert.ToBase64String(cerSAT.SubjectName.RawData))
                            EmitidoAutoridadCertificadora = true;
                    }



                }




                if (!String.IsNullOrEmpty(sArchivoKey) && !String.IsNullOrEmpty(sContraseña))
                {
                    byte[] CertModulus = new byte[0];
                    byte[] CertExponent = new byte[0];

                    if (GetCertPublicKey(cer, out CertModulus, out CertExponent))
                    {
                        System.Security.Cryptography.RSACryptoServiceProvider RSA = null;
                        byte[] keyblob = SSLKey.opensslkey.GetFileBytes(sArchivoKey);
                        if (keyblob != null)
                        {
                            byte[] keyModulus = new byte[0];
                            byte[] keyExponent = new byte[0];
                            if (SSLKey.opensslkey.getModulusExponentPrivateKeyInfo(keyblob, ConvertToSecureString(sContraseña), out keyModulus, out keyExponent))
                            {
                                if (CertExponent.Length == 3)
                                    CertExponent = IngresarByte(CertExponent, 4);
                                if (keyExponent.Length == 3)
                                    keyExponent = IngresarByte(keyExponent, 4);
                                if (CertModulus.Length < 128)
                                    CertModulus = IngresarByte(CertModulus, 128);
                                if (keyModulus.Length < 128)
                                    keyModulus = IngresarByte(keyModulus, 128);

                                if (CompareBytearrays(CertExponent, keyExponent) && CompareBytearrays(CertModulus, keyModulus))
                                    esKeyCertificado = true;
                            }
                        }

                    }

                }

                try
                {
                    String DatCert = cer.Subject;
                    int posrfc = DatCert.IndexOf("OID.2.5.4.45=") + ("OID.2.5.4.45=").Length;
                    RFCCertificado = DatCert.Substring(posrfc, DatCert.IndexOf(" ", posrfc) - posrfc).Trim().Replace(",", "");
                }
                catch (Exception ei)
                {


                }



                if (cer.Extensions["Uso de la clave"] != null)
                {
                    if (cer.Extensions["Uso de la clave"].RawData[3] == 192)
                    {
                        esCSD = true;
                        esFIEL = false;
                    }

                    if (cer.Extensions["Uso de la clave"].RawData[3] == 232 || cer.Extensions["Uso de la clave"].RawData[3] == 216)
                    {
                        esFIEL = true;
                        esCSD = false;
                    }
                }
                else if (cer.Extensions["Key Usage"] != null)
                {
                    if (cer.Extensions["Key Usage"].RawData[3] == 192)
                    {
                        esCSD = true;
                        esFIEL = false;
                    }

                    if (cer.Extensions["Key Usage"].RawData[3] == 232 || cer.Extensions["Key Usage"].RawData[3] == 216)
                    {
                        esFIEL = true;
                        esCSD = false;
                    }
                }
            }
            catch (Exception ex)
            {
                String Inner = "";
                String Source = "";
                String Target = "";

                /* if (ex.InnerException != null)
                     Inner = " InnerException: " + ex.InnerException.Message;
                 if (ex.Source != null)
                     Source = " Source: " + ex.Source;
                 if (ex.TargetSite != null)
                     Target = " TargetSite: " + ex.TargetSite;
                 throw new Exception("error analizando el certificado error: " + ex.Message + Inner + Source + Target );*/

                throw new Exception(ex.Message);
            }
        }

        public String NumeroSerie
        {
            set;
            get;
        }

        public DateTime FechaInicioCertificado
        {
            set;
            get;
        }

        public DateTime FechaFinCertificado
        {
            set;
            get;
        }

        public Boolean esCSD
        {
            set;
            get;
        }

        public Boolean esFIEL
        {
            set;
            get;
        }

        private String InvertirStr(String Valor)
        {
            Char[] Arreglo = Valor.ToCharArray();
            String Resultado = "";
            for (int X = Arreglo.Length - 1; X > -1; X--)
                Resultado += Arreglo[X];
            return Resultado;
        }

        private static bool CompareBytearrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            int i = 0;
            foreach (byte c in a)
            {
                if (c != b[i])
                    return false;
                i++;
            }
            return true;
        }

        private static System.Security.SecureString ConvertToSecureString(string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            System.Security.SecureString ClaveSec = new System.Security.SecureString();
            for (int Y = 0; password.Length > Y; Y++)
                ClaveSec.AppendChar(password[Y]);
            return ClaveSec;
        }

        private static Byte[] IngresarByte(Byte[] Original, int Total)
        {
            byte[] Resultado = new byte[Total];
            int Faltan = Total - Original.Length;
            for (int Y = 0; Y < Faltan; Y++)
                Resultado[Y] = 0;
            for (int X = 0; X < Original.Length; X++)
                Resultado[X + Faltan] = Original[X];
            return Resultado;
        }
    }

}
