
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
public enum c_TipoJornada
{
    
    [System.Xml.Serialization.XmlEnumAttribute("02")]
        TipoJornada02=2,
    
    [System.Xml.Serialization.XmlEnumAttribute("03")]
        TipoJornada03=3,
    
    [System.Xml.Serialization.XmlEnumAttribute("01")]
        TipoJornada01=1,
    
    [System.Xml.Serialization.XmlEnumAttribute("04")]
        TipoJornada04=4,
    
    [System.Xml.Serialization.XmlEnumAttribute("05")]
        TipoJornada05=5,
    
    [System.Xml.Serialization.XmlEnumAttribute("06")]
        TipoJornada06=6,
    
    [System.Xml.Serialization.XmlEnumAttribute("07")]
        TipoJornada07=7,
    
    [System.Xml.Serialization.XmlEnumAttribute("08")]
        TipoJornada08=8,
    
    [System.Xml.Serialization.XmlEnumAttribute("99")]
        TipoJornada99=99,
}
}

