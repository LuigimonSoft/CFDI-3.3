using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica
{
    public class Sellador
    {
        private String keyFile = String.Empty;
        private String Password = String.Empty;
        private String certFile = String.Empty;

        /// <summary>
        /// Certificado con el que se va a sellar
        /// </summary>
        public Certificado Cert { set; get; }

        public Sellador(String ArchivoKey, String ArchivoCert, String Contraseña, bool sha256=true)
        {
            try
            {
                keyFile = ArchivoKey;
                certFile = ArchivoCert;
                Password = Contraseña;
                if (!String.IsNullOrEmpty(certFile))
                {
                    if (System.IO.File.Exists(certFile))
                        Cert = new Certificado(certFile);
                    else
                        throw new Exception("No se puede encontrar el certificado", new Exception(certFile));
                }
                else
                    throw new Exception("Error debe especificarse el certificado");
            }
            catch (Exception e)
            {
                throw new Exception("Error en constructor sellador", new Exception(e.Message));
            }
        }

        public Sellador(Certificado cert)
        {
            Cert = cert;
        }

        public Boolean SellarXML( String CadenaOriginal, String SerieCertificado, out String Sello, out List<String> Error, bool sha256 = true)
        {
            Boolean Resultado = false;
            Sello = String.Empty;
            Error = null;


            if (SerieCertificado == Cert.NumeroSerie)
            {
                if (!Cert.esFIEL && Cert.esCSD)
                {
                    if (System.DateTime.Now >= Cert.FechaInicioCertificado &&
                        System.DateTime.Now <= Cert.FechaFinCertificado)
                    {
                        if (!String.IsNullOrEmpty(keyFile))
                        {
                            if (System.IO.File.Exists(keyFile))
                            {
                                if (sha256)
                                {
                                    if (GenerarSelloSHA256(CadenaOriginal, keyFile, Password, out Sello, out Error))
                                        Resultado = true;
                                }
                                else
                                {
                                    if (GenerarSelloSHA1(CadenaOriginal, keyFile, Password, out Sello, out Error))
                                        Resultado = true;
                                }
                            }
                            else
                                Error.Add("No se puede encontrar el archivo key "+ keyFile);
                        }
                        else
                            Error.Add("Debe especificar el archivo KEY");

                    }
                    else
                        Error.Add("El certificado ha caducado");
                }
                else
                    Error.Add("El certificado utilizado es un certificado tipo FIEL");
            }
            else
                Error.Add("El certificado no corresponde al numero de serie");

            return Resultado;
        }

        public Boolean SellarXML(String CadenaOriginal, out String Sello, out List<String> Error, bool sha256 = true)
        {
            Boolean Resultado = false;
            Sello = String.Empty;
            Error = new List<string>();

            if (!Cert.esFIEL && Cert.esCSD)
            {
                if (System.DateTime.Now >= Cert.FechaInicioCertificado &&
                    System.DateTime.Now <= Cert.FechaFinCertificado)
                {
                    if (Cert.bKey!=null)
                    {
                        if (Cert.bKey.Length>1)
                        {
                            if (sha256)
                            {
                                if (GenerarSelloSHA256(CadenaOriginal, Cert , out Sello, out Error))
                                    Resultado = true;
                            }
                            else
                            {
                                if (GenerarSelloSHA1(CadenaOriginal, Cert,  out Sello, out Error))
                                    Resultado = true;
                            }
                        }
                        else
                            Error.Add("No se puede encontrar el archivo key " + keyFile);
                    }
                    else
                        Error.Add("Debe especificar el archivo KEY");

                }
                else
                    Error.Add("El certificado ha caducado");
            }
            else
                Error.Add("El certificado utilizado es un certificado tipo FIEL");

            return Resultado;
        }

        private Boolean GenerarSelloSHA1(String CadenaOriginal, String ArchivoKey, String Clave, out String Resultado, out List<String> ErrorSellado)
        {
            Boolean Devolver = false;
            Resultado = String.Empty;
            String SelloDigital = String.Empty;
            String ErrorSellador = String.Empty;
            ErrorSellado = null;
            System.Security.Cryptography.SHA1CryptoServiceProvider EncriptaSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            Byte[] CadenaOriginalEnBytes = EncriptaSHA1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(CadenaOriginal));

            System.Security.Cryptography.RSACryptoServiceProvider RSA = null;
            byte[] keyblob = SSLKey.opensslkey.GetFileBytes(ArchivoKey);
            if (keyblob != null)
            {
                if (SSLKey.opensslkey.DecodeEncryptedPrivateKeyInfo(keyblob, ConvertToSecureString(Clave), out RSA, out ErrorSellador))
                {
                    //RSA.FromXmlString(LLavePrivada);
                    System.Security.Cryptography.RSAPKCS1SignatureFormatter RSAFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(RSA);
                    RSAFormatter.SetHashAlgorithm("SHA1");
                    CadenaOriginalEnBytes = RSAFormatter.CreateSignature(CadenaOriginalEnBytes);
                    SelloDigital = Convert.ToBase64String(CadenaOriginalEnBytes);
                    Resultado = SelloDigital;
                    Devolver = true;
                }
                else
                    ErrorSellado.Add(ErrorSellador);
            }

            return Devolver;
        }

        private Boolean GenerarSelloSHA1(String CadenaOriginal, Certificado cert,  out String Resultado, out List<String> ErrorSellado)
        {
            Boolean Devolver = false;
            Resultado = String.Empty;
            String SelloDigital = String.Empty;
            String ErrorSellador = String.Empty;
            ErrorSellado = null;
            System.Security.Cryptography.SHA1CryptoServiceProvider EncriptaSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            Byte[] CadenaOriginalEnBytes = EncriptaSHA1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(CadenaOriginal));

            System.Security.Cryptography.RSACryptoServiceProvider RSA = null;
            byte[] keyblob = cert.bKey;
            if (keyblob != null)
            {
                if (SSLKey.opensslkey.DecodeEncryptedPrivateKeyInfo(keyblob, cert.ContrasenaSegura, out RSA, out ErrorSellador))
                {
                    //RSA.FromXmlString(LLavePrivada);
                    System.Security.Cryptography.RSAPKCS1SignatureFormatter RSAFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(RSA);
                    RSAFormatter.SetHashAlgorithm("SHA1");
                    CadenaOriginalEnBytes = RSAFormatter.CreateSignature(CadenaOriginalEnBytes);
                    SelloDigital = Convert.ToBase64String(CadenaOriginalEnBytes);
                    Resultado = SelloDigital;
                    Devolver = true;
                }
                else
                    ErrorSellado.Add(ErrorSellador);
            }

            return Devolver;
        }


        private Boolean GenerarSelloSHA256(String CadenaOriginal, String ArchivoKey, String Clave, out String Resultado, out List<String> ErrorSellado)
        {
            Boolean Devolver = false;
            Resultado = String.Empty;
            String SelloDigital = String.Empty;
            String ErrorSellador = String.Empty;
            ErrorSellado = null;
            System.Security.Cryptography.SHA256CryptoServiceProvider EncriptaSHA256 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            Byte[] CadenaOriginalEnBytes = EncriptaSHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(CadenaOriginal));

            System.Security.Cryptography.RSACryptoServiceProvider RSA = null;
            byte[] keyblob = SSLKey.opensslkey.GetFileBytes(ArchivoKey);
            if (keyblob != null)
            {
                if (SSLKey.opensslkey.DecodeEncryptedPrivateKeyInfo(keyblob, ConvertToSecureString(Clave), out RSA, out ErrorSellador))
                {
                    //RSA.FromXmlString(LLavePrivada);
                    System.Security.Cryptography.RSAPKCS1SignatureFormatter RSAFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(RSA);
                    RSAFormatter.SetHashAlgorithm("SHA256");
                    CadenaOriginalEnBytes = RSAFormatter.CreateSignature(CadenaOriginalEnBytes);
                    SelloDigital = Convert.ToBase64String(CadenaOriginalEnBytes);
                    Resultado = SelloDigital;
                    Devolver = true;
                }
                else
                    ErrorSellado.Add(ErrorSellador);
            }

            return Devolver;
        }

        private Boolean GenerarSelloSHA256(String CadenaOriginal, Certificado cert,  out String Resultado, out List<String> ErrorSellado)
        {
            Boolean Devolver = false;
            Resultado = String.Empty;
            String SelloDigital = String.Empty;
            String ErrorSellador = String.Empty;
            ErrorSellado = new List<string>();
            System.Security.Cryptography.SHA256CryptoServiceProvider EncriptaSHA256 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            Byte[] CadenaOriginalEnBytes = EncriptaSHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(CadenaOriginal));

            System.Security.Cryptography.RSACryptoServiceProvider RSA = null;
            byte[] keyblob = cert.bKey;
            if (keyblob != null)
            {
                if (SSLKey.opensslkey.DecodeEncryptedPrivateKeyInfo(keyblob, cert.ContrasenaSegura, out RSA, out ErrorSellador))
                {
                    //RSA.FromXmlString(LLavePrivada);
                    System.Security.Cryptography.RSAPKCS1SignatureFormatter RSAFormatter = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(RSA);
                    RSAFormatter.SetHashAlgorithm("SHA256");
                    CadenaOriginalEnBytes = RSAFormatter.CreateSignature(CadenaOriginalEnBytes);
                    SelloDigital = Convert.ToBase64String(CadenaOriginalEnBytes);
                    Resultado = SelloDigital;
                    Devolver = true;
                }
                else
                    ErrorSellado.Add(ErrorSellador);
            }

            return Devolver;
        }

        private static System.Security.SecureString ConvertToSecureString(string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            System.Security.SecureString ClaveSec = new System.Security.SecureString();
            password.ToList().ForEach(Letra=>ClaveSec.AppendChar(Letra));
            /*for (int Y = 0; password.Length > Y; Y++)
                ClaveSec.AppendChar(password[Y]);*/
            return ClaveSec;
        }
    }
}
