
namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Collections.Generic;

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
    public enum c_TipoHoras
    {

        [System.Xml.Serialization.XmlEnumAttribute("01")]
        TipoHoras01 = 1,

        [System.Xml.Serialization.XmlEnumAttribute("02")]
        TipoHoras02 = 2,

        [System.Xml.Serialization.XmlEnumAttribute("03")]
        TipoHoras03 = 3,
    }
}

