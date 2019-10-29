
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
public enum c_TipoContrato
{
    
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    TipoContrato01=1,
    
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    TipoContrato02,
    
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    TipoContrato03,
    
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    TipoContrato04,
    
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    TipoContrato05,
    
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    TipoContrato06,
    
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    TipoContrato07,
    
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    TipoContrato08,
    
    [System.Xml.Serialization.XmlEnumAttribute("09")]
    TipoContrato09,
    
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    TipoContrato10,
    
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    TipoContrato99=99,
}
}

