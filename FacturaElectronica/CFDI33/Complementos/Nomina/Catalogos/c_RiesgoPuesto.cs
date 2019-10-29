
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
public enum c_RiesgoPuesto
{
    
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Riesgo1=1,
    
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Riesgo2,
    
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Riesgo3,
    
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Riesgo4,
    
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Riesgo5,
    
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Riesgo99=99,
}
}

