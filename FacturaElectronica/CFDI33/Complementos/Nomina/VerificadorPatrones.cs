using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    public class VerificadorPatrones
    {
        public static Boolean VerificarPatronSinPunto(String Valor)
        {
            Boolean Resultado = true;
            String Patron = @"([A-Z]|[a-z]|[0-9]| |Ñ|ñ|!|&quot;|%|&amp;|&apos;|´|-|:|;|&gt;|=|&lt;|@|_|,|\{|\}|`|~|á|é|í|ó|ú|Á|É|Í|Ó|Ú|ü|Ü)";
            int Y = 0;
            Valor.ToList().ForEach(X =>
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(X.ToString(), Patron))
                {
                    if (X == '&')
                    {
                        String ValorAmp3 = Valor.Substring(Y, 3);
                        String ValorAmp = Valor.Substring(Y, 5);
                        String ValorAmp6 = Valor.Substring(Y, 6);
                        if (ValorAmp != "&amp;")
                        {
                            if (ValorAmp6 != "&quot;")
                            {
                                if (ValorAmp6 != "&apos;")
                                {
                                    if (ValorAmp3 != "&lt;")
                                    {
                                        if (ValorAmp3 != "&gt;")
                                            Resultado = false;
                                    }
                                }
                            }
                        }

                    }
                    
                    else 
                        Resultado = false;
                }
                Y++;
            });

            return Resultado;
        }

        public static String RemplazarCaracteresEspeciales(string Cadena)
        {
            return System.Security.SecurityElement.Escape(Cadena);
        }

        public static String LimpiarCaracteresEspeciales(string Cadena)
        {
            return Cadena.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"").Replace("&apos;", "'").Replace("&amp;", "&");
          
        }
    }
}
