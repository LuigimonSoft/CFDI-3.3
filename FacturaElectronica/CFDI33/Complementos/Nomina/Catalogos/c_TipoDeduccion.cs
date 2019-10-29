
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
    public enum c_TipoDeduccion
    {

        [System.Xml.Serialization.XmlEnumAttribute("001")]
        TipoDeduccion001 = 001,
        [System.Xml.Serialization.XmlEnumAttribute("002")]
        TipoDeduccion002 = 002,
        [System.Xml.Serialization.XmlEnumAttribute("003")]
        TipoDeduccion003 = 003,
        [System.Xml.Serialization.XmlEnumAttribute("004")]
        TipoDeduccion004 = 004,
        [System.Xml.Serialization.XmlEnumAttribute("005")]
        TipoDeduccion005 = 005,
        [System.Xml.Serialization.XmlEnumAttribute("006")]
        TipoDeduccion006 = 006,
        [System.Xml.Serialization.XmlEnumAttribute("007")]
        TipoDeduccion007 = 007,
        [System.Xml.Serialization.XmlEnumAttribute("008")]
        TipoDeduccion008 = 008,
        [System.Xml.Serialization.XmlEnumAttribute("009")]
        TipoDeduccion009 = 009,
        [System.Xml.Serialization.XmlEnumAttribute("010")]
        TipoDeduccion010 = 010,
        [System.Xml.Serialization.XmlEnumAttribute("011")]
        TipoDeduccion011 = 011,
        [System.Xml.Serialization.XmlEnumAttribute("012")]
        TipoDeduccion012 = 012,
        [System.Xml.Serialization.XmlEnumAttribute("013")]
        TipoDeduccion013 = 013,
        [System.Xml.Serialization.XmlEnumAttribute("014")]
        TipoDeduccion014 = 014,
        [System.Xml.Serialization.XmlEnumAttribute("015")]
        TipoDeduccion015 = 015,
        [System.Xml.Serialization.XmlEnumAttribute("016")]
        TipoDeduccion016 = 016,
        [System.Xml.Serialization.XmlEnumAttribute("017")]
        TipoDeduccion017 = 017,
        [System.Xml.Serialization.XmlEnumAttribute("018")]
        TipoDeduccion018 = 018,
        [System.Xml.Serialization.XmlEnumAttribute("019")]
        TipoDeduccion019 = 019,
        [System.Xml.Serialization.XmlEnumAttribute("020")]
        TipoDeduccion020 = 020,
        [System.Xml.Serialization.XmlEnumAttribute("021")]
        TipoDeduccion021 = 021,
        [System.Xml.Serialization.XmlEnumAttribute("022")]
        TipoDeduccion022 = 022,
        [System.Xml.Serialization.XmlEnumAttribute("023")]
        TipoDeduccion023 = 023,
        [System.Xml.Serialization.XmlEnumAttribute("024")]
        TipoDeduccion024 = 024,
        [System.Xml.Serialization.XmlEnumAttribute("025")]
        TipoDeduccion025 = 025,
        [System.Xml.Serialization.XmlEnumAttribute("026")]
        TipoDeduccion026 = 026,
        [System.Xml.Serialization.XmlEnumAttribute("027")]
        TipoDeduccion027 = 027,
        [System.Xml.Serialization.XmlEnumAttribute("028")]
        TipoDeduccion028 = 028,
        [System.Xml.Serialization.XmlEnumAttribute("029")]
        TipoDeduccion029 = 029,
        [System.Xml.Serialization.XmlEnumAttribute("030")]
        TipoDeduccion030 = 030,
        [System.Xml.Serialization.XmlEnumAttribute("031")]
        TipoDeduccion031 = 031,
        [System.Xml.Serialization.XmlEnumAttribute("032")]
        TipoDeduccion032 = 032,
        [System.Xml.Serialization.XmlEnumAttribute("033")]
        TipoDeduccion033 = 033,
        [System.Xml.Serialization.XmlEnumAttribute("034")]
        TipoDeduccion034 = 034,
        [System.Xml.Serialization.XmlEnumAttribute("035")]
        TipoDeduccion035 = 035,
        [System.Xml.Serialization.XmlEnumAttribute("036")]
        TipoDeduccion036 = 036,
        [System.Xml.Serialization.XmlEnumAttribute("037")]
        TipoDeduccion037 = 037,
        [System.Xml.Serialization.XmlEnumAttribute("038")]
        TipoDeduccion038 = 038,
        [System.Xml.Serialization.XmlEnumAttribute("039")]
        TipoDeduccion039 = 039,
        [System.Xml.Serialization.XmlEnumAttribute("040")]
        TipoDeduccion040 = 040,
        [System.Xml.Serialization.XmlEnumAttribute("041")]
        TipoDeduccion041 = 041,
        [System.Xml.Serialization.XmlEnumAttribute("042")]
        TipoDeduccion042 = 042,
        [System.Xml.Serialization.XmlEnumAttribute("043")]
        TipoDeduccion043 = 043,
        [System.Xml.Serialization.XmlEnumAttribute("044")]
        TipoDeduccion044 = 044,
        [System.Xml.Serialization.XmlEnumAttribute("045")]
        TipoDeduccion045 = 045,
        [System.Xml.Serialization.XmlEnumAttribute("046")]
        TipoDeduccion046 = 046,
        [System.Xml.Serialization.XmlEnumAttribute("047")]
        TipoDeduccion047 = 047,
        [System.Xml.Serialization.XmlEnumAttribute("048")]
        TipoDeduccion048 = 048,
        [System.Xml.Serialization.XmlEnumAttribute("049")]
        TipoDeduccion049 = 049,
        [System.Xml.Serialization.XmlEnumAttribute("050")]
        TipoDeduccion050 = 050,
        [System.Xml.Serialization.XmlEnumAttribute("051")]
        TipoDeduccion051 = 051,
        [System.Xml.Serialization.XmlEnumAttribute("052")]
        TipoDeduccion052 = 052,
        [System.Xml.Serialization.XmlEnumAttribute("053")]
        TipoDeduccion053 = 053,
        [System.Xml.Serialization.XmlEnumAttribute("054")]
        TipoDeduccion054 = 054,
        [System.Xml.Serialization.XmlEnumAttribute("055")]
        TipoDeduccion055 = 055,
        [System.Xml.Serialization.XmlEnumAttribute("056")]
        TipoDeduccion056 = 056,
        [System.Xml.Serialization.XmlEnumAttribute("057")]
        TipoDeduccion057 = 057,
        [System.Xml.Serialization.XmlEnumAttribute("058")]
        TipoDeduccion058 = 058,
        [System.Xml.Serialization.XmlEnumAttribute("059")]
        TipoDeduccion059 = 059,
        [System.Xml.Serialization.XmlEnumAttribute("060")]
        TipoDeduccion060 = 060,
        [System.Xml.Serialization.XmlEnumAttribute("061")]
        TipoDeduccion061 = 061,
        [System.Xml.Serialization.XmlEnumAttribute("062")]
        TipoDeduccion062 = 062,
        [System.Xml.Serialization.XmlEnumAttribute("063")]
        TipoDeduccion063 = 063,
        [System.Xml.Serialization.XmlEnumAttribute("064")]
        TipoDeduccion064 = 064,
        [System.Xml.Serialization.XmlEnumAttribute("065")]
        TipoDeduccion065 = 065,
        [System.Xml.Serialization.XmlEnumAttribute("066")]
        TipoDeduccion066 = 066,
        [System.Xml.Serialization.XmlEnumAttribute("067")]
        TipoDeduccion067 = 067,
        [System.Xml.Serialization.XmlEnumAttribute("068")]
        TipoDeduccion068 = 068,
        [System.Xml.Serialization.XmlEnumAttribute("069")]
        TipoDeduccion069 = 069,
        [System.Xml.Serialization.XmlEnumAttribute("070")]
        TipoDeduccion070 = 070,
        [System.Xml.Serialization.XmlEnumAttribute("071")]
        TipoDeduccion071 = 071,
        [System.Xml.Serialization.XmlEnumAttribute("072")]
        TipoDeduccion072 = 072,
        [System.Xml.Serialization.XmlEnumAttribute("073")]
        TipoDeduccion073 = 073,
        [System.Xml.Serialization.XmlEnumAttribute("074")]
        TipoDeduccion074 = 074,
        [System.Xml.Serialization.XmlEnumAttribute("075")]
        TipoDeduccion075 = 075,
        [System.Xml.Serialization.XmlEnumAttribute("076")]
        TipoDeduccion076 = 076,
        [System.Xml.Serialization.XmlEnumAttribute("077")]
        TipoDeduccion077 = 077,
        [System.Xml.Serialization.XmlEnumAttribute("078")]
        TipoDeduccion078 = 078,
        [System.Xml.Serialization.XmlEnumAttribute("079")]
        TipoDeduccion079 = 079,
        [System.Xml.Serialization.XmlEnumAttribute("080")]
        TipoDeduccion080 = 080,
        [System.Xml.Serialization.XmlEnumAttribute("081")]
        TipoDeduccion081 = 081,
        [System.Xml.Serialization.XmlEnumAttribute("082")]
        TipoDeduccion082 = 082,
        [System.Xml.Serialization.XmlEnumAttribute("083")]
        TipoDeduccion083 = 083,
        [System.Xml.Serialization.XmlEnumAttribute("084")]
        TipoDeduccion084 = 084,
        [System.Xml.Serialization.XmlEnumAttribute("085")]
        TipoDeduccion085 = 085,
        [System.Xml.Serialization.XmlEnumAttribute("086")]
        TipoDeduccion086 = 086,
        [System.Xml.Serialization.XmlEnumAttribute("087")]
        TipoDeduccion087 = 087,
        [System.Xml.Serialization.XmlEnumAttribute("088")]
        TipoDeduccion088 = 088,
        [System.Xml.Serialization.XmlEnumAttribute("089")]
        TipoDeduccion089 = 089,
        [System.Xml.Serialization.XmlEnumAttribute("090")]
        TipoDeduccion090 = 090,
        [System.Xml.Serialization.XmlEnumAttribute("091")]
        TipoDeduccion091 = 091,
        [System.Xml.Serialization.XmlEnumAttribute("092")]
        TipoDeduccion092 = 092,
        [System.Xml.Serialization.XmlEnumAttribute("093")]
        TipoDeduccion093 = 093,
        [System.Xml.Serialization.XmlEnumAttribute("094")]
        TipoDeduccion094 = 094,
        [System.Xml.Serialization.XmlEnumAttribute("095")]
        TipoDeduccion095 = 095,
        [System.Xml.Serialization.XmlEnumAttribute("096")]
        TipoDeduccion096 = 096,
        [System.Xml.Serialization.XmlEnumAttribute("097")]
        TipoDeduccion097 = 097,
        [System.Xml.Serialization.XmlEnumAttribute("098")]
        TipoDeduccion098 = 098,
        [System.Xml.Serialization.XmlEnumAttribute("099")]
        TipoDeduccion099 = 099,
        [System.Xml.Serialization.XmlEnumAttribute("100")]
        TipoDeduccion100 = 100,
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        TipoDeduccion101 = 101,
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        TipoDeduccion102 = 102,
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        TipoDeduccion103 = 103,
        [System.Xml.Serialization.XmlEnumAttribute("104")]
        TipoDeduccion104 = 104,
        [System.Xml.Serialization.XmlEnumAttribute("105")]
        TipoDeduccion105 = 105,
        [System.Xml.Serialization.XmlEnumAttribute("106")]
        TipoDeduccion106 = 106,
    }
}

