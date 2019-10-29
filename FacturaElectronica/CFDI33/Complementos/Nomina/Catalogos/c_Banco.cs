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
    public enum c_Banco
    {

        [System.Xml.Serialization.XmlEnumAttribute("002")]
        [StringValue("002")]
        Banco002 = 002,
        [System.Xml.Serialization.XmlEnumAttribute("006")]
        [StringValue("006")]
        Banco006 = 006,
        [System.Xml.Serialization.XmlEnumAttribute("009")]
        [StringValue("009")]
        Banco009 = 009,
        [System.Xml.Serialization.XmlEnumAttribute("012")]
        [StringValue("012")]
        Banco012 = 012,
        [System.Xml.Serialization.XmlEnumAttribute("014")]
        [StringValue("014")]
        Banco014 = 014,
        [System.Xml.Serialization.XmlEnumAttribute("019")]
        [StringValue("019")]
        Banco019 = 019,
        [System.Xml.Serialization.XmlEnumAttribute("021")]
        [StringValue("021")]
        Banco021 = 021,
        [System.Xml.Serialization.XmlEnumAttribute("030")]
        [StringValue("030")]
        Banco030 = 030,
        [System.Xml.Serialization.XmlEnumAttribute("032")]
        [StringValue("032")]
        Banco032 = 032,
        [System.Xml.Serialization.XmlEnumAttribute("036")]
        [StringValue("036")]
        Banco036 = 036,
        [System.Xml.Serialization.XmlEnumAttribute("037")]
        [StringValue("037")]
        Banco037 = 037,
        [System.Xml.Serialization.XmlEnumAttribute("042")]
        [StringValue("042")]
        Banco042 = 042,
        [System.Xml.Serialization.XmlEnumAttribute("044")]
        [StringValue("044")]
        Banco044 = 044,
        [System.Xml.Serialization.XmlEnumAttribute("058")]
        [StringValue("058")]
        Banco058 = 058,
        [System.Xml.Serialization.XmlEnumAttribute("059")]
        [StringValue("059")]
        Banco059 = 059,
        [System.Xml.Serialization.XmlEnumAttribute("060")]
        [StringValue("060")]
        Banco060 = 060,
        [System.Xml.Serialization.XmlEnumAttribute("062")]
        [StringValue("062")]
        Banco062 = 062,
        [System.Xml.Serialization.XmlEnumAttribute("072")]
        [StringValue("072")]
        Banco072 = 072,
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        [StringValue("102")]
        Banco102 = 102,
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        [StringValue("103")]
        Banco103 = 103,
        [System.Xml.Serialization.XmlEnumAttribute("106")]
        [StringValue("106")]
        Banco106 = 106,
        [System.Xml.Serialization.XmlEnumAttribute("108")]
        [StringValue("108")]
        Banco108 = 108,
        [System.Xml.Serialization.XmlEnumAttribute("110")]
        [StringValue("110")]
        Banco110 = 110,
        [System.Xml.Serialization.XmlEnumAttribute("112")]
        [StringValue("112")]
        Banco112 = 112,
        [System.Xml.Serialization.XmlEnumAttribute("113")]
        [StringValue("113")]
        Banco113 = 113,
        [System.Xml.Serialization.XmlEnumAttribute("116")]
        [StringValue("116")]
        Banco116 = 116,
        [System.Xml.Serialization.XmlEnumAttribute("124")]
        [StringValue("124")]
        Banco124 = 124,
        [System.Xml.Serialization.XmlEnumAttribute("126")]
        [StringValue("126")]
        Banco126 = 126,
        [System.Xml.Serialization.XmlEnumAttribute("127")]
        [StringValue("127")]
        Banco127 = 127,
        [System.Xml.Serialization.XmlEnumAttribute("128")]
        [StringValue("128")]
        Banco128 = 128,
        [System.Xml.Serialization.XmlEnumAttribute("129")]
        [StringValue("129")]
        Banco129 = 129,
        [System.Xml.Serialization.XmlEnumAttribute("130")]
        [StringValue("130")]
        Banco130 = 130,
        [System.Xml.Serialization.XmlEnumAttribute("131")]
        [StringValue("131")]
        Banco131 = 131,
        [System.Xml.Serialization.XmlEnumAttribute("132")]
        [StringValue("132")]
        Banco132 = 132,
        [System.Xml.Serialization.XmlEnumAttribute("133")]
        [StringValue("133")]
        Banco133 = 133,
        [System.Xml.Serialization.XmlEnumAttribute("134")]
        [StringValue("134")]
        Banco134 = 134,
        [System.Xml.Serialization.XmlEnumAttribute("135")]
        [StringValue("135")]
        Banco135 = 135,
        [System.Xml.Serialization.XmlEnumAttribute("136")]
        [StringValue("136")]
        Banco136 = 136,
        [System.Xml.Serialization.XmlEnumAttribute("137")]
        [StringValue("137")]
        Banco137 = 137,
        [System.Xml.Serialization.XmlEnumAttribute("138")]
        [StringValue("138")]
        Banco138 = 138,
        [System.Xml.Serialization.XmlEnumAttribute("139")]
        [StringValue("139")]
        Banco139 = 139,
        [System.Xml.Serialization.XmlEnumAttribute("140")]
        [StringValue("140")]
        Banco140 = 140,
        [System.Xml.Serialization.XmlEnumAttribute("141")]
        [StringValue("141")]
        Banco141 = 141,
        [System.Xml.Serialization.XmlEnumAttribute("143")]
        [StringValue("143")]
        Banco143 = 143,
        [System.Xml.Serialization.XmlEnumAttribute("145")]
        [StringValue("145")]
        Banco145 = 145,
        [System.Xml.Serialization.XmlEnumAttribute("147")]
        [StringValue("147")]
        Banco147 = 147,
        [System.Xml.Serialization.XmlEnumAttribute("148")]
        [StringValue("148")]
        Banco148 = 148,
        [System.Xml.Serialization.XmlEnumAttribute("149")]
        [StringValue("149")]
        Banco149 = 149,
        [System.Xml.Serialization.XmlEnumAttribute("150")]
        [StringValue("150")]
        Banco150 = 150,
        [System.Xml.Serialization.XmlEnumAttribute("151")]
        [StringValue("151")]
        Banco151 = 151,
        [System.Xml.Serialization.XmlEnumAttribute("152")]
        [StringValue("152")]
        Banco152 = 152,
        [System.Xml.Serialization.XmlEnumAttribute("153")]
        [StringValue("153")]
        Banco153 = 153,
        [System.Xml.Serialization.XmlEnumAttribute("154")]
        [StringValue("154")]
        Banco154 = 154,
        [System.Xml.Serialization.XmlEnumAttribute("155")]
        [StringValue("155")]
        Banco155 = 155,
        [System.Xml.Serialization.XmlEnumAttribute("156")]
        [StringValue("156")]
        Banco156 = 156,
        [System.Xml.Serialization.XmlEnumAttribute("157")]
        [StringValue("157")]
        Banco157 = 157,
        [System.Xml.Serialization.XmlEnumAttribute("158")]
        [StringValue("158")]
        Banco158 = 158,
        [System.Xml.Serialization.XmlEnumAttribute("159")]
        [StringValue("159")]
        Banco159 = 159,
        [System.Xml.Serialization.XmlEnumAttribute("160")]
        [StringValue("160")]
        Banco160 = 160,
        [System.Xml.Serialization.XmlEnumAttribute("166")]
        [StringValue("166")]
        Banco166 = 166,
        [System.Xml.Serialization.XmlEnumAttribute("168")]
        [StringValue("168")]
        Banco168 = 168,
        [System.Xml.Serialization.XmlEnumAttribute("600")]
        [StringValue("600")]
        Banco600 = 600,
        [System.Xml.Serialization.XmlEnumAttribute("601")]
        [StringValue("601")]
        Banco601 = 601,
        [System.Xml.Serialization.XmlEnumAttribute("602")]
        [StringValue("602")]
        Banco602 = 602,
        [System.Xml.Serialization.XmlEnumAttribute("605")]
        [StringValue("605")]
        Banco605 = 605,
        [System.Xml.Serialization.XmlEnumAttribute("606")]
        [StringValue("606")]
        Banco606 = 606,
        [System.Xml.Serialization.XmlEnumAttribute("607")]
        [StringValue("607")]
        Banco607 = 607,
        [System.Xml.Serialization.XmlEnumAttribute("608")]
        [StringValue("608")]
        Banco608 = 608,
        [System.Xml.Serialization.XmlEnumAttribute("610")]
        [StringValue("610")]
        Banco610 = 610,
        [System.Xml.Serialization.XmlEnumAttribute("614")]
        [StringValue("614")]
        Banco614 = 614,
        [System.Xml.Serialization.XmlEnumAttribute("615")]
        [StringValue("615")]
        Banco615 = 615,
        [System.Xml.Serialization.XmlEnumAttribute("616")]
        [StringValue("616")]
        Banco616 = 616,
        [System.Xml.Serialization.XmlEnumAttribute("617")]
        [StringValue("617")]
        Banco617 = 617,
        [System.Xml.Serialization.XmlEnumAttribute("618")]
        [StringValue("618")]
        Banco618 = 618,
        [System.Xml.Serialization.XmlEnumAttribute("619")]
        [StringValue("619")]
        Banco619 = 619,
        [System.Xml.Serialization.XmlEnumAttribute("620")]
        [StringValue("620")]
        Banco620 = 620,
        [System.Xml.Serialization.XmlEnumAttribute("621")]
        [StringValue("621")]
        Banco621 = 621,
        [System.Xml.Serialization.XmlEnumAttribute("622")]
        [StringValue("622")]
        Banco622 = 622,
        [System.Xml.Serialization.XmlEnumAttribute("623")]
        [StringValue("623")]
        Banco623 = 623,
        [System.Xml.Serialization.XmlEnumAttribute("626")]
        [StringValue("626")]
        Banco626 = 626,
        [System.Xml.Serialization.XmlEnumAttribute("627")]
        [StringValue("627")]
        Banco627 = 627,
        [System.Xml.Serialization.XmlEnumAttribute("628")]
        [StringValue("628")]
        Banco628 = 628,
        [System.Xml.Serialization.XmlEnumAttribute("629")]
        [StringValue("629")]
        Banco629 = 629,
        [System.Xml.Serialization.XmlEnumAttribute("630")]
        [StringValue("630")]
        Banco630 = 630,
        [System.Xml.Serialization.XmlEnumAttribute("631")]
        [StringValue("631")]
        Banco631 = 631,
        [System.Xml.Serialization.XmlEnumAttribute("632")]
        [StringValue("632")]
        Banco632 = 632,
        [System.Xml.Serialization.XmlEnumAttribute("633")]
        [StringValue("633")]
        Banco633 = 633,
        [System.Xml.Serialization.XmlEnumAttribute("634")]
        [StringValue("634")]
        Banco634 = 634,
        [System.Xml.Serialization.XmlEnumAttribute("636")]
        [StringValue("636")]
        Banco636 = 636,
        [System.Xml.Serialization.XmlEnumAttribute("637")]
        [StringValue("637")]
        Banco637 = 637,
        [System.Xml.Serialization.XmlEnumAttribute("638")]
        [StringValue("638")]
        Banco638 = 638,
        [System.Xml.Serialization.XmlEnumAttribute("640")]
        [StringValue("640")]
        Banco640 = 640,
        [System.Xml.Serialization.XmlEnumAttribute("642")]
        [StringValue("642")]
        Banco642 = 642,
        [System.Xml.Serialization.XmlEnumAttribute("646")]
        [StringValue("646")]
        Banco646 = 646,
        [System.Xml.Serialization.XmlEnumAttribute("647")]
        [StringValue("647")]
        Banco647 = 647,
        [System.Xml.Serialization.XmlEnumAttribute("648")]
        [StringValue("648")]
        Banco648 = 648,
        [System.Xml.Serialization.XmlEnumAttribute("649")]
        [StringValue("649")]
        Banco649 = 649,
        [System.Xml.Serialization.XmlEnumAttribute("651")]
        [StringValue("651")]
        Banco651 = 651,
        [System.Xml.Serialization.XmlEnumAttribute("652")]
        [StringValue("652")]
        Banco652 = 652,
        [System.Xml.Serialization.XmlEnumAttribute("653")]
        [StringValue("653")]
        Banco653 = 653,
        [System.Xml.Serialization.XmlEnumAttribute("655")]
        [StringValue("655")]
        Banco655 = 655,
        [System.Xml.Serialization.XmlEnumAttribute("656")]
        [StringValue("656")]
        Banco656 = 656,
        [System.Xml.Serialization.XmlEnumAttribute("659")]
        [StringValue("659")]
        Banco659 = 659,
        [System.Xml.Serialization.XmlEnumAttribute("670")]
        [StringValue("670")]
        Banco670 = 670,
        [System.Xml.Serialization.XmlEnumAttribute("901")]
        [StringValue("901")]
        Banco901 = 901,
        [System.Xml.Serialization.XmlEnumAttribute("902")]
        [StringValue("902")]
        Banco902 = 902,
    }
}
