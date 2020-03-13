using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaElectronica.CFDI33;

namespace FacturaElectronica.CFDI33
{
    public class t_Importe
    {
        private decimal valor;
        private String strvalor;
        private c_Moneda _moneda=c_Moneda.MXN;

        /// <summary>
        /// Especifica el metodo que se utilizar para los decimales
        /// </summary>
        /*public enum TipoDecimales
        {
            Truncar,
            Redondear
        }*/
        public t_Importe() { }
        public t_Importe(decimal dValor)
        {
            Valor = dValor;
        }

        public t_Importe(decimal dValor,c_Moneda moneda)
        {
            Valor = dValor;
            Moneda = moneda;
        }

        public t_Importe(decimal dValor, String moneda)
        {
            Valor = dValor;
            Moneda = Comprobante.toMoneda(moneda);
        }

        public c_Moneda Moneda { set { _moneda = value; } get { return _moneda; } }

       /* public t_Importe(decimal dValor,TipoDecimales ModificadorDecimales)
        {
            switch(ModificadorDecimales)
            {
                case TipoDecimales.Truncar:
                    String[] sValor = dValor.ToString().Replace(",", ".").Split('.');
                    String ValorFinal = sValor[0];
                    if (sValor.Length > 1)
                    {
                        if (sValor[1].Length > 2)
                            ValorFinal += "." + sValor[1].Substring(0, 2);
                        else
                            ValorFinal += "." + sValor[1];
                    }
                    else
                        ValorFinal += ".00";
                    strImporte = ValorFinal;
                    Valor = System.Convert.ToDecimal(ValorFinal);
                    break;
                case TipoDecimales.Redondear:
                    Valor = System.Math.Round(dValor, 2);
                    break;
            }
            
        }*/

        public t_Importe(String svalor)
        {
            strImporte = svalor;
        }
        public string strImporte
        {
            set
            {
                if(value.Trim().Length>0)
                    Valor = System.Convert.ToDecimal(value);
            }
            get
            {
                return strvalor;
            }
        }

        public decimal Valor
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("El valor minimo permitido es cero ");
                String[] sValor = value.ToString().Replace(",", ".").Split('.');
                if(sValor.Length>1)
                {
                    if (sValor[1].Length > c_Moneda_Decimales.Decimales(Moneda))
                        throw new ArgumentException("El maximo de decimales permitidos es "+ c_Moneda_Decimales.Decimales(Moneda).ToString());
                }
                
                valor = value;
                strvalor = sValor[0];
                if (sValor.Length > 1)
                {
                    if(sValor[1].Length== c_Moneda_Decimales.Decimales(Moneda))
                        strvalor += "." + sValor[1];
                    else
                        strvalor += "." + sValor[1]+ "000000".Substring(0, c_Moneda_Decimales.Decimales(Moneda)- sValor[1].Length);
                }
                else
                    strvalor +=  ".000000".Substring(0, c_Moneda_Decimales.Decimales(Moneda)+1);
            }

            get
            {
                return valor;
            }
        }
    }
    
}
