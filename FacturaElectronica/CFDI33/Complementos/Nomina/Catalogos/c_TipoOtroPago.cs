
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
    public enum c_TipoOtroPago
    {

        [System.Xml.Serialization.XmlEnumAttribute("001")]
        TipoOtroPago001 = 1,

        [System.Xml.Serialization.XmlEnumAttribute("002")]
        TipoOtroPago002 = 2,

        [System.Xml.Serialization.XmlEnumAttribute("003")]
        TipoOtroPago003 = 3,

        [System.Xml.Serialization.XmlEnumAttribute("004")]
        TipoOtroPago004 = 4,

        [System.Xml.Serialization.XmlEnumAttribute("005")]
        TipoOtroPago005 = 5,

        [System.Xml.Serialization.XmlEnumAttribute("999")]
        TipoOtroPago999 = 999,
    }
}

