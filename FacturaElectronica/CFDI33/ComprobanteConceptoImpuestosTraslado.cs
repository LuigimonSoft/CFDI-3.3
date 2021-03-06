﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaElectronica.CFDI33
{
    public partial class ComprobanteConceptoImpuestosTraslado
    {
        /// <summary>
        /// Atributo condicional para señalar el importe del impuesto trasladado que aplica al concepto. No se permiten valores negativos. Es requerido cuando TipoFactor sea Tasa o Cuota
        /// </summary>
        [XmlIgnore]
        public t_Importe Importe {
            set
            {
                _importe = value;
                sImporteSpecified = true;
            }
            get { return _importe; } }

        /// <summary>
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada para el presente concepto. Es requerido cuando el atributo TipoFactor tenga una clave que corresponda a Tasa o Cuota.
        /// </summary>
        [XmlIgnore]
        public decimal TasaOCuota
        {
            get { return this._tasaOCuota; }
            set
            {
                if (value < System.Convert.ToDecimal(0.000000))
                    throw new ArgumentException("El valor minimo permitido es 0.000000 ");
                String[] partes = value.ToString().Split('.');
                if (partes.Length > 1)
                {
                    int Parte1 = System.Convert.ToInt32(partes[0]);
                    decimal valorprueba = (value - Parte1);
                    if (valorprueba < System.Convert.ToDecimal(0.000000) && valorprueba != 0)
                        throw new ArgumentException("El numero de decimales maximo es de 6");
                }
                TasaOCuotaSpecified = true;
                if ((_base.Equals(value) != true))
                {
                    this._tasaOCuota = value;
                    this.OnPropertyChanged("TasaOCuota");
                }
            }
        }
    }
}
