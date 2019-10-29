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

namespace FacturaElectronica.CFDI33.Complementos.Nomina12
{
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
    public enum c_OrigenRecurso
    {
        [System.Xml.Serialization.XmlEnumAttribute("IP")]
        [StringValue("IP")]
        IP,
        [System.Xml.Serialization.XmlEnumAttribute("IF")]
        [StringValue("IF")]
        IF,
        [System.Xml.Serialization.XmlEnumAttribute("IM")]
        [StringValue("IM")]
        IM,
    }
}

