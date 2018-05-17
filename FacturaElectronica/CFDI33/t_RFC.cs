using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    public class t_RFC
    {
        private String rfc = String.Empty;
        public t_RFC(String RFC)
        {
            String Errores=String.Empty;
            if (VerificarRFC(RFC, out Errores))
                rfc = RFC;
            else
                throw new Exception(Errores);
        }

        public t_RFC( )
        {
        }

        public static Boolean VerificarRFC(String RFC, out String Errores)
        {
            Errores = String.Empty;
            Boolean Resultado = false;

            if (RFC.Trim().Length < 12 || RFC.Trim().Length > 13)
                throw new ArgumentException("El rfc del emisor debe tener entre 12 y 13 caracteres");

            String RFCTemp = RFC.Trim().ToUpper();

            if (System.Text.RegularExpressions.Regex.IsMatch(RFCTemp, @"[A-Z&amp;Ñ]{3,4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]?"))
                Resultado = true;
            else
            {
                Char[] RFCArr = RFCTemp.ToCharArray();
                String[] Exp;

                if (RFCArr.Length == 13)
                    Exp = new String[]
                              {
                                  "[A-Z,Ñ,&amp;]", "[A-Z,Ñ,&amp;]", "[A-Z,Ñ,&amp;]", "[A-Z,Ñ,&amp;]", "[0-9]", "[0-9]",
                                  "[0-1]", "[0-9]", "[0-3]", "[0-9]", "[A-Z,0-9]?", "[A-Z,0-9]?", "[0-9,A-Z]?"
                              };

                else
                    Exp = new String[]
                              {
                                  "[A-Z,Ñ,&amp;]", "[A-Z,Ñ,&amp;]", "[A-Z,Ñ,&amp;]", "[0-9]", "[0-9]", "[0-1]", "[0-9]"
                                  , "[0-3]", "[0-9]", "[A-Z,0-9]?", "[A-Z,0-9]?", "[0-9,A-Z]?"
                              };


                for (int X = 0; X < RFCArr.Length; X++)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(RFCArr[X].ToString(), Exp[X]))
                        Errores += "RFC invalido error en el caracter numero " + X.ToString() + " con valor: " + RFCArr[X].ToString() +
                                   " los valores posibles deben ser " + Exp[X].Replace("[", "").Replace("]", "") + " ";

                }

            }
            return Resultado;
        }

        public String Rfc
        {
            set
            {
                String Errores = String.Empty;
                if (VerificarRFC(value.ToUpper(), out Errores))
                    rfc = value.ToUpper();
                else
                    throw new Exception(Errores);
            }

            get
            {
                return rfc.ToUpper();
            }
        }

    }
}
