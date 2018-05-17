using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.CFDI33
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
    public enum c_ClaveUnidad
    {
        /// <summary>
        /// group
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        [StringValue("10")]
        ClaveUnidad_10,

        /// <summary>
        /// outfit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        [StringValue("11")]
        ClaveUnidad_11,

        /// <summary>
        /// ration
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        [StringValue("13")]
        ClaveUnidad_13,

        /// <summary>
        /// shot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        [StringValue("14")]
        ClaveUnidad_14,

        /// <summary>
        /// stick, military
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        [StringValue("15")]
        ClaveUnidad_15,

        /// <summary>
        /// fixed rate
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1I")]
        [StringValue("1I")]
        ClaveUnidad_1I,

        /// <summary>
        /// twenty foot container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        [StringValue("20")]
        ClaveUnidad_20,

        /// <summary>
        /// forty foot container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        [StringValue("21")]
        ClaveUnidad_21,

        /// <summary>
        /// decilitre per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        [StringValue("22")]
        ClaveUnidad_22,

        /// <summary>
        /// gram per cubic centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        [StringValue("23")]
        ClaveUnidad_23,

        /// <summary>
        /// theoretical pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        [StringValue("24")]
        ClaveUnidad_24,

        /// <summary>
        /// gram per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        [StringValue("25")]
        ClaveUnidad_25,

        /// <summary>
        /// theoretical ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        [StringValue("27")]
        ClaveUnidad_27,

        /// <summary>
        /// kilogram per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        [StringValue("28")]
        ClaveUnidad_28,

        /// <summary>
        /// radian per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2A")]
        [StringValue("2A")]
        ClaveUnidad_2A,

        /// <summary>
        /// radian per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        [StringValue("2B")]
        ClaveUnidad_2B,

        /// <summary>
        /// roentgen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2C")]
        [StringValue("2C")]
        ClaveUnidad_2C,

        /// <summary>
        /// volt AC
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2G")]
        [StringValue("2G")]
        ClaveUnidad_2G,

        /// <summary>
        /// volt DC
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2H")]
        [StringValue("2H")]
        ClaveUnidad_2H,

        /// <summary>
        /// British thermal unit (international table) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2I")]
        [StringValue("2I")]
        ClaveUnidad_2I,

        /// <summary>
        /// cubic centimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2J")]
        [StringValue("2J")]
        ClaveUnidad_2J,

        /// <summary>
        /// cubic foot per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2K")]
        [StringValue("2K")]
        ClaveUnidad_2K,

        /// <summary>
        /// cubic foot per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2L")]
        [StringValue("2L")]
        ClaveUnidad_2L,

        /// <summary>
        /// centimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2M")]
        [StringValue("2M")]
        ClaveUnidad_2M,

        /// <summary>
        /// decibel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2N")]
        [StringValue("2N")]
        ClaveUnidad_2N,

        /// <summary>
        /// kilobyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2P")]
        [StringValue("2P")]
        ClaveUnidad_2P,

        /// <summary>
        /// kilobecquerel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2Q")]
        [StringValue("2Q")]
        ClaveUnidad_2Q,

        /// <summary>
        /// kilocurie
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2R")]
        [StringValue("2R")]
        ClaveUnidad_2R,

        /// <summary>
        /// megagram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2U")]
        [StringValue("2U")]
        ClaveUnidad_2U,

        /// <summary>
        /// metre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2X")]
        [StringValue("2X")]
        ClaveUnidad_2X,

        /// <summary>
        /// milliroentgen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2Y")]
        [StringValue("2Y")]
        ClaveUnidad_2Y,

        /// <summary>
        /// millivolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2Z")]
        [StringValue("2Z")]
        ClaveUnidad_2Z,

        /// <summary>
        /// kilopascal square metre per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        [StringValue("33")]
        ClaveUnidad_33,

        /// <summary>
        /// kilopascal per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        [StringValue("34")]
        ClaveUnidad_34,

        /// <summary>
        /// millilitre per square centimetre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        [StringValue("35")]
        ClaveUnidad_35,

        /// <summary>
        /// ounce per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        [StringValue("37")]
        ClaveUnidad_37,

        /// <summary>
        /// ounce per square foot per 0,01inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        [StringValue("38")]
        ClaveUnidad_38,

        /// <summary>
        /// megajoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3B")]
        [StringValue("3B")]
        ClaveUnidad_3B,

        /// <summary>
        /// manmonth
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3C")]
        [StringValue("3C")]
        ClaveUnidad_3C,

        /// <summary>
        /// millilitre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        [StringValue("40")]
        ClaveUnidad_40,

        /// <summary>
        /// millilitre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        [StringValue("41")]
        ClaveUnidad_41,

        /// <summary>
        /// centistokes
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4C")]
        [StringValue("4C")]
        ClaveUnidad_4C,

        /// <summary>
        /// microlitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4G")]
        [StringValue("4G")]
        ClaveUnidad_4G,

        /// <summary>
        /// micrometre (micron)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4H")]
        [StringValue("4H")]
        ClaveUnidad_4H,

        /// <summary>
        /// milliampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4K")]
        [StringValue("4K")]
        ClaveUnidad_4K,

        /// <summary>
        /// megabyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4L")]
        [StringValue("4L")]
        ClaveUnidad_4L,

        /// <summary>
        /// milligram per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4M")]
        [StringValue("4M")]
        ClaveUnidad_4M,

        /// <summary>
        /// megabecquerel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4N")]
        [StringValue("4N")]
        ClaveUnidad_4N,

        /// <summary>
        /// microfarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4O")]
        [StringValue("4O")]
        ClaveUnidad_4O,

        /// <summary>
        /// newton per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4P")]
        [StringValue("4P")]
        ClaveUnidad_4P,

        /// <summary>
        /// ounce inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4Q")]
        [StringValue("4Q")]
        ClaveUnidad_4Q,

        /// <summary>
        /// ounce foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4R")]
        [StringValue("4R")]
        ClaveUnidad_4R,

        /// <summary>
        /// picofarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4T")]
        [StringValue("4T")]
        ClaveUnidad_4T,

        /// <summary>
        /// pound per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4U")]
        [StringValue("4U")]
        ClaveUnidad_4U,

        /// <summary>
        /// ton (US) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4W")]
        [StringValue("4W")]
        ClaveUnidad_4W,

        /// <summary>
        /// kilolitre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4X")]
        [StringValue("4X")]
        ClaveUnidad_4X,

        /// <summary>
        /// sitas
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        [StringValue("56")]
        ClaveUnidad_56,

        /// <summary>
        /// mesh
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        [StringValue("57")]
        ClaveUnidad_57,

        /// <summary>
        /// net kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        [StringValue("58")]
        ClaveUnidad_58,

        /// <summary>
        /// part per million
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        [StringValue("59")]
        ClaveUnidad_59,

        /// <summary>
        /// barrel (US) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5A")]
        [StringValue("5A")]
        ClaveUnidad_5A,

        /// <summary>
        /// batch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5B")]
        [StringValue("5B")]
        ClaveUnidad_5B,

        /// <summary>
        /// MMSCF/day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5E")]
        [StringValue("5E")]
        ClaveUnidad_5E,

        /// <summary>
        /// hydraulic horse power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5J")]
        [StringValue("5J")]
        ClaveUnidad_5J,

        /// <summary>
        /// percent weight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        [StringValue("60")]
        ClaveUnidad_60,

        /// <summary>
        /// part per billion (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        [StringValue("61")]
        ClaveUnidad_61,

        /// <summary>
        /// millipascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        [StringValue("74")]
        ClaveUnidad_74,

        /// <summary>
        /// milli-inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("77")]
        [StringValue("77")]
        ClaveUnidad_77,

        /// <summary>
        /// pound per square inch absolute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("80")]
        [StringValue("80")]
        ClaveUnidad_80,

        /// <summary>
        /// henry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("81")]
        [StringValue("81")]
        ClaveUnidad_81,

        /// <summary>
        /// foot pound-force
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("85")]
        [StringValue("85")]
        ClaveUnidad_85,

        /// <summary>
        /// pound per cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("87")]
        [StringValue("87")]
        ClaveUnidad_87,

        /// <summary>
        /// poise
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("89")]
        [StringValue("89")]
        ClaveUnidad_89,

        /// <summary>
        /// stokes
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("91")]
        [StringValue("91")]
        ClaveUnidad_91,

        /// <summary>
        /// ampere square metre per joule second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A10")]
        [StringValue("A10")]
        ClaveUnidad_A10,

        /// <summary>
        /// angstrom
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A11")]
        [StringValue("A11")]
        ClaveUnidad_A11,

        /// <summary>
        /// astronomical unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A12")]
        [StringValue("A12")]
        ClaveUnidad_A12,

        /// <summary>
        /// attojoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A13")]
        [StringValue("A13")]
        ClaveUnidad_A13,

        /// <summary>
        /// barn
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A14")]
        [StringValue("A14")]
        ClaveUnidad_A14,

        /// <summary>
        /// barn per electronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A15")]
        [StringValue("A15")]
        ClaveUnidad_A15,

        /// <summary>
        /// barn per steradian electronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A16")]
        [StringValue("A16")]
        ClaveUnidad_A16,

        /// <summary>
        /// barn per steradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A17")]
        [StringValue("A17")]
        ClaveUnidad_A17,

        /// <summary>
        /// becquerel per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A18")]
        [StringValue("A18")]
        ClaveUnidad_A18,

        /// <summary>
        /// becquerel per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A19")]
        [StringValue("A19")]
        ClaveUnidad_A19,

        /// <summary>
        /// ampere per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A2")]
        [StringValue("A2")]
        ClaveUnidad_A2,

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A20")]
        [StringValue("A20")]
        ClaveUnidad_A20,

        /// <summary>
        /// British thermal unit (international table) per pound degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A21")]
        [StringValue("A21")]
        ClaveUnidad_A21,

        /// <summary>
        /// British thermal unit (international table) per second foot degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A22")]
        [StringValue("A22")]
        ClaveUnidad_A22,

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A23")]
        [StringValue("A23")]
        ClaveUnidad_A23,

        /// <summary>
        /// candela per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A24")]
        [StringValue("A24")]
        ClaveUnidad_A24,

        /// <summary>
        /// coulomb metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A26")]
        [StringValue("A26")]
        ClaveUnidad_A26,

        /// <summary>
        /// coulomb metre squared per volt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A27")]
        [StringValue("A27")]
        ClaveUnidad_A27,

        /// <summary>
        /// coulomb per cubic centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A28")]
        [StringValue("A28")]
        ClaveUnidad_A28,

        /// <summary>
        /// coulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A29")]
        [StringValue("A29")]
        ClaveUnidad_A29,

        /// <summary>
        /// ampere per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A3")]
        [StringValue("A3")]
        ClaveUnidad_A3,

        /// <summary>
        /// coulomb per cubic millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A30")]
        [StringValue("A30")]
        ClaveUnidad_A30,

        /// <summary>
        /// coulomb per kilogram second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A31")]
        [StringValue("A31")]
        ClaveUnidad_A31,

        /// <summary>
        /// coulomb per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A32")]
        [StringValue("A32")]
        ClaveUnidad_A32,

        /// <summary>
        /// coulomb per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A33")]
        [StringValue("A33")]
        ClaveUnidad_A33,

        /// <summary>
        /// coulomb per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A34")]
        [StringValue("A34")]
        ClaveUnidad_A34,

        /// <summary>
        /// coulomb per square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A35")]
        [StringValue("A35")]
        ClaveUnidad_A35,

        /// <summary>
        /// cubic centimetre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A36")]
        [StringValue("A36")]
        ClaveUnidad_A36,

        /// <summary>
        /// cubic decimetre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A37")]
        [StringValue("A37")]
        ClaveUnidad_A37,

        /// <summary>
        /// cubic metre per coulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A38")]
        [StringValue("A38")]
        ClaveUnidad_A38,

        /// <summary>
        /// cubic metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A39")]
        [StringValue("A39")]
        ClaveUnidad_A39,

        /// <summary>
        /// ampere per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A4")]
        [StringValue("A4")]
        ClaveUnidad_A4,

        /// <summary>
        /// cubic metre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A40")]
        [StringValue("A40")]
        ClaveUnidad_A40,

        /// <summary>
        /// ampere per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A41")]
        [StringValue("A41")]
        ClaveUnidad_A41,

        /// <summary>
        /// curie per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A42")]
        [StringValue("A42")]
        ClaveUnidad_A42,

        /// <summary>
        /// deadweight tonnage
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A43")]
        [StringValue("A43")]
        ClaveUnidad_A43,

        /// <summary>
        /// decalitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A44")]
        [StringValue("A44")]
        ClaveUnidad_A44,

        /// <summary>
        /// decametre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A45")]
        [StringValue("A45")]
        ClaveUnidad_A45,

        /// <summary>
        /// decitex
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A47")]
        [StringValue("A47")]
        ClaveUnidad_A47,

        /// <summary>
        /// degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A48")]
        [StringValue("A48")]
        ClaveUnidad_A48,

        /// <summary>
        /// denier
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A49")]
        [StringValue("A49")]
        ClaveUnidad_A49,

        /// <summary>
        /// ampere square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A5")]
        [StringValue("A5")]
        ClaveUnidad_A5,

        /// <summary>
        /// electronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A53")]
        [StringValue("A53")]
        ClaveUnidad_A53,

        /// <summary>
        /// electronvolt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A54")]
        [StringValue("A54")]
        ClaveUnidad_A54,

        /// <summary>
        /// electronvolt square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A55")]
        [StringValue("A55")]
        ClaveUnidad_A55,

        /// <summary>
        /// electronvolt square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A56")]
        [StringValue("A56")]
        ClaveUnidad_A56,

        /// <summary>
        /// 8-part cloud cover
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A59")]
        [StringValue("A59")]
        ClaveUnidad_A59,

        /// <summary>
        /// ampere per square metre kelvin squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A6")]
        [StringValue("A6")]
        ClaveUnidad_A6,

        /// <summary>
        /// exajoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A68")]
        [StringValue("A68")]
        ClaveUnidad_A68,

        /// <summary>
        /// farad per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A69")]
        [StringValue("A69")]
        ClaveUnidad_A69,

        /// <summary>
        /// ampere per square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A7")]
        [StringValue("A7")]
        ClaveUnidad_A7,

        /// <summary>
        /// femtojoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A70")]
        [StringValue("A70")]
        ClaveUnidad_A70,

        /// <summary>
        /// femtometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A71")]
        [StringValue("A71")]
        ClaveUnidad_A71,

        /// <summary>
        /// foot per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A73")]
        [StringValue("A73")]
        ClaveUnidad_A73,

        /// <summary>
        /// foot pound-force per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A74")]
        [StringValue("A74")]
        ClaveUnidad_A74,

        /// <summary>
        /// freight ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A75")]
        [StringValue("A75")]
        ClaveUnidad_A75,

        /// <summary>
        /// gal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A76")]
        [StringValue("A76")]
        ClaveUnidad_A76,

        /// <summary>
        /// ampere second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A8")]
        [StringValue("A8")]
        ClaveUnidad_A8,

        /// <summary>
        /// gigacoulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A84")]
        [StringValue("A84")]
        ClaveUnidad_A84,

        /// <summary>
        /// gigaelectronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A85")]
        [StringValue("A85")]
        ClaveUnidad_A85,

        /// <summary>
        /// gigahertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A86")]
        [StringValue("A86")]
        ClaveUnidad_A86,

        /// <summary>
        /// gigaohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A87")]
        [StringValue("A87")]
        ClaveUnidad_A87,

        /// <summary>
        /// gigaohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A88")]
        [StringValue("A88")]
        ClaveUnidad_A88,

        /// <summary>
        /// gigapascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A89")]
        [StringValue("A89")]
        ClaveUnidad_A89,

        /// <summary>
        /// rate
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A9")]
        [StringValue("A9")]
        ClaveUnidad_A9,

        /// <summary>
        /// gigawatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A90")]
        [StringValue("A90")]
        ClaveUnidad_A90,

        /// <summary>
        /// gon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A91")]
        [StringValue("A91")]
        ClaveUnidad_A91,

        /// <summary>
        /// gram per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A93")]
        [StringValue("A93")]
        ClaveUnidad_A93,

        /// <summary>
        /// gram per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A94")]
        [StringValue("A94")]
        ClaveUnidad_A94,

        /// <summary>
        /// gray
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A95")]
        [StringValue("A95")]
        ClaveUnidad_A95,

        /// <summary>
        /// gray per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A96")]
        [StringValue("A96")]
        ClaveUnidad_A96,

        /// <summary>
        /// hectopascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A97")]
        [StringValue("A97")]
        ClaveUnidad_A97,

        /// <summary>
        /// henry per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A98")]
        [StringValue("A98")]
        ClaveUnidad_A98,

        /// <summary>
        /// bit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("A99")]
        [StringValue("A99")]
        ClaveUnidad_A99,

        /// <summary>
        /// ball
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AA")]
        [StringValue("AA")]
        ClaveUnidad_AA,

        /// <summary>
        /// bulk pack
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AB")]
        [StringValue("AB")]
        ClaveUnidad_AB,

        /// <summary>
        /// acre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ACR")]
        [StringValue("ACR")]
        ClaveUnidad_ACR,

        /// <summary>
        /// activity
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ACT")]
        [StringValue("ACT")]
        ClaveUnidad_ACT,

        /// <summary>
        /// byte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AD")]
        [StringValue("AD")]
        ClaveUnidad_AD,

        /// <summary>
        /// ampere per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AE")]
        [StringValue("AE")]
        ClaveUnidad_AE,

        /// <summary>
        /// additional minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AH")]
        [StringValue("AH")]
        ClaveUnidad_AH,

        /// <summary>
        /// average minute per call
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AI")]
        [StringValue("AI")]
        ClaveUnidad_AI,

        /// <summary>
        /// fathom
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AK")]
        [StringValue("AK")]
        ClaveUnidad_AK,

        /// <summary>
        /// access line
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AL")]
        [StringValue("AL")]
        ClaveUnidad_AL,

        /// <summary>
        /// ampere hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AMH")]
        [StringValue("AMH")]
        ClaveUnidad_AMH,

        /// <summary>
        /// ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AMP")]
        [StringValue("AMP")]
        ClaveUnidad_AMP,

        /// <summary>
        /// year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ANN")]
        [StringValue("ANN")]
        ClaveUnidad_ANN,

        /// <summary>
        /// troy ounce or apothecary ounce
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("APZ")]
        [StringValue("APZ")]
        ClaveUnidad_APZ,

        /// <summary>
        /// anti-hemophilic factor (AHF) unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AQ")]
        [StringValue("AQ")]
        ClaveUnidad_AQ,

        /// <summary>
        /// assortment
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AS")]
        [StringValue("AS")]
        ClaveUnidad_AS,

        /// <summary>
        /// alcoholic strength by mass
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ASM")]
        [StringValue("ASM")]
        ClaveUnidad_ASM,

        /// <summary>
        /// alcoholic strength by volume
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ASU")]
        [StringValue("ASU")]
        ClaveUnidad_ASU,

        /// <summary>
        /// standard atmosphere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ATM")]
        [StringValue("ATM")]
        ClaveUnidad_ATM,

        /// <summary>
        /// american wire gauge
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AWG")]
        [StringValue("AWG")]
        ClaveUnidad_AWG,

        /// <summary>
        /// assembly
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AY")]
        [StringValue("AY")]
        ClaveUnidad_AY,

        /// <summary>
        /// British thermal unit (international table) per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("AZ")]
        [StringValue("AZ")]
        ClaveUnidad_AZ,

        /// <summary>
        /// barrel (US) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B1")]
        [StringValue("B1")]
        ClaveUnidad_B1,

        /// <summary>
        /// bit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B10")]
        [StringValue("B10")]
        ClaveUnidad_B10,

        /// <summary>
        /// joule per kilogram kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B11")]
        [StringValue("B11")]
        ClaveUnidad_B11,

        /// <summary>
        /// joule per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B12")]
        [StringValue("B12")]
        ClaveUnidad_B12,

        /// <summary>
        /// joule per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B13")]
        [StringValue("B13")]
        ClaveUnidad_B13,

        /// <summary>
        /// joule per metre to the fourth power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B14")]
        [StringValue("B14")]
        ClaveUnidad_B14,

        /// <summary>
        /// joule per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B15")]
        [StringValue("B15")]
        ClaveUnidad_B15,

        /// <summary>
        /// joule per mole kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B16")]
        [StringValue("B16")]
        ClaveUnidad_B16,

        /// <summary>
        /// credit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B17")]
        [StringValue("B17")]
        ClaveUnidad_B17,

        /// <summary>
        /// joule second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B18")]
        [StringValue("B18")]
        ClaveUnidad_B18,

        /// <summary>
        /// digit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B19")]
        [StringValue("B19")]
        ClaveUnidad_B19,

        /// <summary>
        /// joule square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B20")]
        [StringValue("B20")]
        ClaveUnidad_B20,

        /// <summary>
        /// kelvin per watt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B21")]
        [StringValue("B21")]
        ClaveUnidad_B21,

        /// <summary>
        /// kiloampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B22")]
        [StringValue("B22")]
        ClaveUnidad_B22,

        /// <summary>
        /// kiloampere per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B23")]
        [StringValue("B23")]
        ClaveUnidad_B23,

        /// <summary>
        /// kiloampere per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B24")]
        [StringValue("B24")]
        ClaveUnidad_B24,

        /// <summary>
        /// kilobecquerel per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B25")]
        [StringValue("B25")]
        ClaveUnidad_B25,

        /// <summary>
        /// kilocoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B26")]
        [StringValue("B26")]
        ClaveUnidad_B26,

        /// <summary>
        /// kilocoulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B27")]
        [StringValue("B27")]
        ClaveUnidad_B27,

        /// <summary>
        /// kilocoulomb per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B28")]
        [StringValue("B28")]
        ClaveUnidad_B28,

        /// <summary>
        /// kiloelectronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B29")]
        [StringValue("B29")]
        ClaveUnidad_B29,

        /// <summary>
        /// batting pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B3")]
        [StringValue("B3")]
        ClaveUnidad_B3,

        /// <summary>
        /// gibibit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B30")]
        [StringValue("B30")]
        ClaveUnidad_B30,

        /// <summary>
        /// kilogram metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B31")]
        [StringValue("B31")]
        ClaveUnidad_B31,

        /// <summary>
        /// kilogram metre squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B32")]
        [StringValue("B32")]
        ClaveUnidad_B32,

        /// <summary>
        /// kilogram metre squared per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B33")]
        [StringValue("B33")]
        ClaveUnidad_B33,

        /// <summary>
        /// kilogram per cubic decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B34")]
        [StringValue("B34")]
        ClaveUnidad_B34,

        /// <summary>
        /// kilogram per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B35")]
        [StringValue("B35")]
        ClaveUnidad_B35,

        /// <summary>
        /// barrel, imperial
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B4")]
        [StringValue("B4")]
        ClaveUnidad_B4,

        /// <summary>
        /// kilojoule per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B41")]
        [StringValue("B41")]
        ClaveUnidad_B41,

        /// <summary>
        /// kilojoule per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B42")]
        [StringValue("B42")]
        ClaveUnidad_B42,

        /// <summary>
        /// kilojoule per kilogram kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B43")]
        [StringValue("B43")]
        ClaveUnidad_B43,

        /// <summary>
        /// kilojoule per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B44")]
        [StringValue("B44")]
        ClaveUnidad_B44,

        /// <summary>
        /// kilomole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B45")]
        [StringValue("B45")]
        ClaveUnidad_B45,

        /// <summary>
        /// kilomole per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B46")]
        [StringValue("B46")]
        ClaveUnidad_B46,

        /// <summary>
        /// kilonewton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B47")]
        [StringValue("B47")]
        ClaveUnidad_B47,

        /// <summary>
        /// kilonewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B48")]
        [StringValue("B48")]
        ClaveUnidad_B48,

        /// <summary>
        /// kiloohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B49")]
        [StringValue("B49")]
        ClaveUnidad_B49,

        /// <summary>
        /// kiloohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B50")]
        [StringValue("B50")]
        ClaveUnidad_B50,

        /// <summary>
        /// kilosecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B52")]
        [StringValue("B52")]
        ClaveUnidad_B52,

        /// <summary>
        /// kilosiemens
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B53")]
        [StringValue("B53")]
        ClaveUnidad_B53,

        /// <summary>
        /// kilosiemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B54")]
        [StringValue("B54")]
        ClaveUnidad_B54,

        /// <summary>
        /// kilovolt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B55")]
        [StringValue("B55")]
        ClaveUnidad_B55,

        /// <summary>
        /// kiloweber per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B56")]
        [StringValue("B56")]
        ClaveUnidad_B56,

        /// <summary>
        /// light year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B57")]
        [StringValue("B57")]
        ClaveUnidad_B57,

        /// <summary>
        /// litre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B58")]
        [StringValue("B58")]
        ClaveUnidad_B58,

        /// <summary>
        /// lumen hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B59")]
        [StringValue("B59")]
        ClaveUnidad_B59,

        /// <summary>
        /// lumen per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B60")]
        [StringValue("B60")]
        ClaveUnidad_B60,

        /// <summary>
        /// lumen per watt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B61")]
        [StringValue("B61")]
        ClaveUnidad_B61,

        /// <summary>
        /// lumen second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B62")]
        [StringValue("B62")]
        ClaveUnidad_B62,

        /// <summary>
        /// lux hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B63")]
        [StringValue("B63")]
        ClaveUnidad_B63,

        /// <summary>
        /// lux second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B64")]
        [StringValue("B64")]
        ClaveUnidad_B64,

        /// <summary>
        /// megaampere per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B66")]
        [StringValue("B66")]
        ClaveUnidad_B66,

        /// <summary>
        /// megabecquerel per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B67")]
        [StringValue("B67")]
        ClaveUnidad_B67,

        /// <summary>
        /// gigabit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B68")]
        [StringValue("B68")]
        ClaveUnidad_B68,

        /// <summary>
        /// megacoulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B69")]
        [StringValue("B69")]
        ClaveUnidad_B69,

        /// <summary>
        /// cycle
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B7")]
        [StringValue("B7")]
        ClaveUnidad_B7,

        /// <summary>
        /// megacoulomb per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B70")]
        [StringValue("B70")]
        ClaveUnidad_B70,

        /// <summary>
        /// megaelectronvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B71")]
        [StringValue("B71")]
        ClaveUnidad_B71,

        /// <summary>
        /// megagram per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B72")]
        [StringValue("B72")]
        ClaveUnidad_B72,

        /// <summary>
        /// meganewton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B73")]
        [StringValue("B73")]
        ClaveUnidad_B73,

        /// <summary>
        /// meganewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B74")]
        [StringValue("B74")]
        ClaveUnidad_B74,

        /// <summary>
        /// megaohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B75")]
        [StringValue("B75")]
        ClaveUnidad_B75,

        /// <summary>
        /// megaohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B76")]
        [StringValue("B76")]
        ClaveUnidad_B76,

        /// <summary>
        /// megasiemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B77")]
        [StringValue("B77")]
        ClaveUnidad_B77,

        /// <summary>
        /// megavolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B78")]
        [StringValue("B78")]
        ClaveUnidad_B78,

        /// <summary>
        /// megavolt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B79")]
        [StringValue("B79")]
        ClaveUnidad_B79,

        /// <summary>
        /// joule per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B8")]
        [StringValue("B8")]
        ClaveUnidad_B8,

        /// <summary>
        /// gigabit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B80")]
        [StringValue("B80")]
        ClaveUnidad_B80,

        /// <summary>
        /// reciprocal metre squared reciprocal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B81")]
        [StringValue("B81")]
        ClaveUnidad_B81,

        /// <summary>
        /// inch per linear foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B82")]
        [StringValue("B82")]
        ClaveUnidad_B82,

        /// <summary>
        /// metre to the fourth power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B83")]
        [StringValue("B83")]
        ClaveUnidad_B83,

        /// <summary>
        /// microampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B84")]
        [StringValue("B84")]
        ClaveUnidad_B84,

        /// <summary>
        /// microbar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B85")]
        [StringValue("B85")]
        ClaveUnidad_B85,

        /// <summary>
        /// microcoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B86")]
        [StringValue("B86")]
        ClaveUnidad_B86,

        /// <summary>
        /// microcoulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B87")]
        [StringValue("B87")]
        ClaveUnidad_B87,

        /// <summary>
        /// microcoulomb per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B88")]
        [StringValue("B88")]
        ClaveUnidad_B88,

        /// <summary>
        /// microfarad per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B89")]
        [StringValue("B89")]
        ClaveUnidad_B89,

        /// <summary>
        /// microhenry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B90")]
        [StringValue("B90")]
        ClaveUnidad_B90,

        /// <summary>
        /// microhenry per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B91")]
        [StringValue("B91")]
        ClaveUnidad_B91,

        /// <summary>
        /// micronewton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B92")]
        [StringValue("B92")]
        ClaveUnidad_B92,

        /// <summary>
        /// micronewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B93")]
        [StringValue("B93")]
        ClaveUnidad_B93,

        /// <summary>
        /// microohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B94")]
        [StringValue("B94")]
        ClaveUnidad_B94,

        /// <summary>
        /// microohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B95")]
        [StringValue("B95")]
        ClaveUnidad_B95,

        /// <summary>
        /// micropascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B96")]
        [StringValue("B96")]
        ClaveUnidad_B96,

        /// <summary>
        /// microradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B97")]
        [StringValue("B97")]
        ClaveUnidad_B97,

        /// <summary>
        /// microsecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B98")]
        [StringValue("B98")]
        ClaveUnidad_B98,

        /// <summary>
        /// microsiemens
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("B99")]
        [StringValue("B99")]
        ClaveUnidad_B99,

        /// <summary>
        /// bar [unit of pressure]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BAR")]
        [StringValue("BAR")]
        ClaveUnidad_BAR,

        /// <summary>
        /// base box
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BB")]
        [StringValue("BB")]
        ClaveUnidad_BB,

        /// <summary>
        /// board foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BFT")]
        [StringValue("BFT")]
        ClaveUnidad_BFT,

        /// <summary>
        /// brake horse power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BHP")]
        [StringValue("BHP")]
        ClaveUnidad_BHP,

        /// <summary>
        /// billion (EUR)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BIL")]
        [StringValue("BIL")]
        ClaveUnidad_BIL,

        /// <summary>
        /// dry barrel (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BLD")]
        [StringValue("BLD")]
        ClaveUnidad_BLD,

        /// <summary>
        /// barrel (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BLL")]
        [StringValue("BLL")]
        ClaveUnidad_BLL,

        /// <summary>
        /// hundred board foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BP")]
        [StringValue("BP")]
        ClaveUnidad_BP,

        /// <summary>
        /// beats per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BPM")]
        [StringValue("BPM")]
        ClaveUnidad_BPM,

        /// <summary>
        /// becquerel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BQL")]
        [StringValue("BQL")]
        ClaveUnidad_BQL,

        /// <summary>
        /// British thermal unit (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BTU")]
        [StringValue("BTU")]
        ClaveUnidad_BTU,

        /// <summary>
        /// bushel (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BUA")]
        [StringValue("BUA")]
        ClaveUnidad_BUA,

        /// <summary>
        /// bushel (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("BUI")]
        [StringValue("BUI")]
        ClaveUnidad_BUI,

        /// <summary>
        /// call
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C0")]
        [StringValue("C0")]
        ClaveUnidad_C0,

        /// <summary>
        /// millifarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C10")]
        [StringValue("C10")]
        ClaveUnidad_C10,

        /// <summary>
        /// milligal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C11")]
        [StringValue("C11")]
        ClaveUnidad_C11,

        /// <summary>
        /// milligram per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C12")]
        [StringValue("C12")]
        ClaveUnidad_C12,

        /// <summary>
        /// milligray
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C13")]
        [StringValue("C13")]
        ClaveUnidad_C13,

        /// <summary>
        /// millihenry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C14")]
        [StringValue("C14")]
        ClaveUnidad_C14,

        /// <summary>
        /// millijoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C15")]
        [StringValue("C15")]
        ClaveUnidad_C15,

        /// <summary>
        /// millimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C16")]
        [StringValue("C16")]
        ClaveUnidad_C16,

        /// <summary>
        /// millimetre squared per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C17")]
        [StringValue("C17")]
        ClaveUnidad_C17,

        /// <summary>
        /// millimole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C18")]
        [StringValue("C18")]
        ClaveUnidad_C18,

        /// <summary>
        /// mole per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C19")]
        [StringValue("C19")]
        ClaveUnidad_C19,

        /// <summary>
        /// millinewton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C20")]
        [StringValue("C20")]
        ClaveUnidad_C20,

        /// <summary>
        /// kibibit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C21")]
        [StringValue("C21")]
        ClaveUnidad_C21,

        /// <summary>
        /// millinewton per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C22")]
        [StringValue("C22")]
        ClaveUnidad_C22,

        /// <summary>
        /// milliohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C23")]
        [StringValue("C23")]
        ClaveUnidad_C23,

        /// <summary>
        /// millipascal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C24")]
        [StringValue("C24")]
        ClaveUnidad_C24,

        /// <summary>
        /// milliradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C25")]
        [StringValue("C25")]
        ClaveUnidad_C25,

        /// <summary>
        /// millisecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C26")]
        [StringValue("C26")]
        ClaveUnidad_C26,

        /// <summary>
        /// millisiemens
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C27")]
        [StringValue("C27")]
        ClaveUnidad_C27,

        /// <summary>
        /// millisievert
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C28")]
        [StringValue("C28")]
        ClaveUnidad_C28,

        /// <summary>
        /// millitesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C29")]
        [StringValue("C29")]
        ClaveUnidad_C29,

        /// <summary>
        /// microvolt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C3")]
        [StringValue("C3")]
        ClaveUnidad_C3,

        /// <summary>
        /// millivolt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C30")]
        [StringValue("C30")]
        ClaveUnidad_C30,

        /// <summary>
        /// milliwatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C31")]
        [StringValue("C31")]
        ClaveUnidad_C31,

        /// <summary>
        /// milliwatt per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C32")]
        [StringValue("C32")]
        ClaveUnidad_C32,

        /// <summary>
        /// milliweber
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C33")]
        [StringValue("C33")]
        ClaveUnidad_C33,

        /// <summary>
        /// mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C34")]
        [StringValue("C34")]
        ClaveUnidad_C34,

        /// <summary>
        /// mole per cubic decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C35")]
        [StringValue("C35")]
        ClaveUnidad_C35,

        /// <summary>
        /// mole per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C36")]
        [StringValue("C36")]
        ClaveUnidad_C36,

        /// <summary>
        /// kilobit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C37")]
        [StringValue("C37")]
        ClaveUnidad_C37,

        /// <summary>
        /// mole per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C38")]
        [StringValue("C38")]
        ClaveUnidad_C38,

        /// <summary>
        /// nanoampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C39")]
        [StringValue("C39")]
        ClaveUnidad_C39,

        /// <summary>
        /// nanocoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C40")]
        [StringValue("C40")]
        ClaveUnidad_C40,

        /// <summary>
        /// nanofarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C41")]
        [StringValue("C41")]
        ClaveUnidad_C41,

        /// <summary>
        /// nanofarad per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C42")]
        [StringValue("C42")]
        ClaveUnidad_C42,

        /// <summary>
        /// nanohenry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C43")]
        [StringValue("C43")]
        ClaveUnidad_C43,

        /// <summary>
        /// nanohenry per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C44")]
        [StringValue("C44")]
        ClaveUnidad_C44,

        /// <summary>
        /// nanometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C45")]
        [StringValue("C45")]
        ClaveUnidad_C45,

        /// <summary>
        /// nanoohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C46")]
        [StringValue("C46")]
        ClaveUnidad_C46,

        /// <summary>
        /// nanosecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C47")]
        [StringValue("C47")]
        ClaveUnidad_C47,

        /// <summary>
        /// nanotesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C48")]
        [StringValue("C48")]
        ClaveUnidad_C48,

        /// <summary>
        /// nanowatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C49")]
        [StringValue("C49")]
        ClaveUnidad_C49,

        /// <summary>
        /// neper
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C50")]
        [StringValue("C50")]
        ClaveUnidad_C50,

        /// <summary>
        /// neper per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C51")]
        [StringValue("C51")]
        ClaveUnidad_C51,

        /// <summary>
        /// picometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C52")]
        [StringValue("C52")]
        ClaveUnidad_C52,

        /// <summary>
        /// newton metre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C53")]
        [StringValue("C53")]
        ClaveUnidad_C53,

        /// <summary>
        /// newton metre squared per kilogram squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C54")]
        [StringValue("C54")]
        ClaveUnidad_C54,

        /// <summary>
        /// newton per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C55")]
        [StringValue("C55")]
        ClaveUnidad_C55,

        /// <summary>
        /// newton per square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C56")]
        [StringValue("C56")]
        ClaveUnidad_C56,

        /// <summary>
        /// newton second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C57")]
        [StringValue("C57")]
        ClaveUnidad_C57,

        /// <summary>
        /// newton second per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C58")]
        [StringValue("C58")]
        ClaveUnidad_C58,

        /// <summary>
        /// octave
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C59")]
        [StringValue("C59")]
        ClaveUnidad_C59,

        /// <summary>
        /// ohm centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C60")]
        [StringValue("C60")]
        ClaveUnidad_C60,

        /// <summary>
        /// ohm metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C61")]
        [StringValue("C61")]
        ClaveUnidad_C61,

        /// <summary>
        /// one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C62")]
        [StringValue("C62")]
        ClaveUnidad_C62,

        /// <summary>
        /// parsec
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C63")]
        [StringValue("C63")]
        ClaveUnidad_C63,

        /// <summary>
        /// pascal per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C64")]
        [StringValue("C64")]
        ClaveUnidad_C64,

        /// <summary>
        /// pascal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C65")]
        [StringValue("C65")]
        ClaveUnidad_C65,

        /// <summary>
        /// pascal second per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C66")]
        [StringValue("C66")]
        ClaveUnidad_C66,

        /// <summary>
        /// pascal second per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C67")]
        [StringValue("C67")]
        ClaveUnidad_C67,

        /// <summary>
        /// petajoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C68")]
        [StringValue("C68")]
        ClaveUnidad_C68,

        /// <summary>
        /// phon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C69")]
        [StringValue("C69")]
        ClaveUnidad_C69,

        /// <summary>
        /// centipoise
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C7")]
        [StringValue("C7")]
        ClaveUnidad_C7,

        /// <summary>
        /// picoampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C70")]
        [StringValue("C70")]
        ClaveUnidad_C70,

        /// <summary>
        /// picocoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C71")]
        [StringValue("C71")]
        ClaveUnidad_C71,

        /// <summary>
        /// picofarad per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C72")]
        [StringValue("C72")]
        ClaveUnidad_C72,

        /// <summary>
        /// picohenry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C73")]
        [StringValue("C73")]
        ClaveUnidad_C73,

        /// <summary>
        /// kilobit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C74")]
        [StringValue("C74")]
        ClaveUnidad_C74,

        /// <summary>
        /// picowatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C75")]
        [StringValue("C75")]
        ClaveUnidad_C75,

        /// <summary>
        /// picowatt per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C76")]
        [StringValue("C76")]
        ClaveUnidad_C76,

        /// <summary>
        /// pound-force
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C78")]
        [StringValue("C78")]
        ClaveUnidad_C78,

        /// <summary>
        /// kilovolt ampere hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C79")]
        [StringValue("C79")]
        ClaveUnidad_C79,

        /// <summary>
        /// millicoulomb per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C8")]
        [StringValue("C8")]
        ClaveUnidad_C8,

        /// <summary>
        /// rad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C80")]
        [StringValue("C80")]
        ClaveUnidad_C80,

        /// <summary>
        /// radian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C81")]
        [StringValue("C81")]
        ClaveUnidad_C81,

        /// <summary>
        /// radian square metre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C82")]
        [StringValue("C82")]
        ClaveUnidad_C82,

        /// <summary>
        /// radian square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C83")]
        [StringValue("C83")]
        ClaveUnidad_C83,

        /// <summary>
        /// radian per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C84")]
        [StringValue("C84")]
        ClaveUnidad_C84,

        /// <summary>
        /// reciprocal angstrom
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C85")]
        [StringValue("C85")]
        ClaveUnidad_C85,

        /// <summary>
        /// reciprocal cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C86")]
        [StringValue("C86")]
        ClaveUnidad_C86,

        /// <summary>
        /// reciprocal cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C87")]
        [StringValue("C87")]
        ClaveUnidad_C87,

        /// <summary>
        /// reciprocal electron volt per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C88")]
        [StringValue("C88")]
        ClaveUnidad_C88,

        /// <summary>
        /// reciprocal henry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C89")]
        [StringValue("C89")]
        ClaveUnidad_C89,

        /// <summary>
        /// coil group
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C9")]
        [StringValue("C9")]
        ClaveUnidad_C9,

        /// <summary>
        /// reciprocal joule per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C90")]
        [StringValue("C90")]
        ClaveUnidad_C90,

        /// <summary>
        /// reciprocal kelvin or kelvin to the power minus one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C91")]
        [StringValue("C91")]
        ClaveUnidad_C91,

        /// <summary>
        /// reciprocal metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C92")]
        [StringValue("C92")]
        ClaveUnidad_C92,

        /// <summary>
        /// reciprocal square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C93")]
        [StringValue("C93")]
        ClaveUnidad_C93,

        /// <summary>
        /// reciprocal minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C94")]
        [StringValue("C94")]
        ClaveUnidad_C94,

        /// <summary>
        /// reciprocal mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C95")]
        [StringValue("C95")]
        ClaveUnidad_C95,

        /// <summary>
        /// reciprocal pascal or pascal to the power minus one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C96")]
        [StringValue("C96")]
        ClaveUnidad_C96,

        /// <summary>
        /// reciprocal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C97")]
        [StringValue("C97")]
        ClaveUnidad_C97,

        /// <summary>
        /// reciprocal second per metre squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("C99")]
        [StringValue("C99")]
        ClaveUnidad_C99,

        /// <summary>
        /// carrying capacity in metric ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CCT")]
        [StringValue("CCT")]
        ClaveUnidad_CCT,

        /// <summary>
        /// candela
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CDL")]
        [StringValue("CDL")]
        ClaveUnidad_CDL,

        /// <summary>
        /// degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CEL")]
        [StringValue("CEL")]
        ClaveUnidad_CEL,

        /// <summary>
        /// hundred
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CEN")]
        [StringValue("CEN")]
        ClaveUnidad_CEN,

        /// <summary>
        /// card
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CG")]
        [StringValue("CG")]
        ClaveUnidad_CG,

        /// <summary>
        /// centigram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CGM")]
        [StringValue("CGM")]
        ClaveUnidad_CGM,

        /// <summary>
        /// coulomb per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CKG")]
        [StringValue("CKG")]
        ClaveUnidad_CKG,

        /// <summary>
        /// hundred leave
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CLF")]
        [StringValue("CLF")]
        ClaveUnidad_CLF,

        /// <summary>
        /// centilitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CLT")]
        [StringValue("CLT")]
        ClaveUnidad_CLT,

        /// <summary>
        /// square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CMK")]
        [StringValue("CMK")]
        ClaveUnidad_CMK,

        /// <summary>
        /// cubic centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CMQ")]
        [StringValue("CMQ")]
        ClaveUnidad_CMQ,

        /// <summary>
        /// centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CMT")]
        [StringValue("CMT")]
        ClaveUnidad_CMT,

        /// <summary>
        /// hundred pack
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CNP")]
        [StringValue("CNP")]
        ClaveUnidad_CNP,

        /// <summary>
        /// cental (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CNT")]
        [StringValue("CNT")]
        ClaveUnidad_CNT,

        /// <summary>
        /// coulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("COU")]
        [StringValue("COU")]
        ClaveUnidad_COU,

        /// <summary>
        /// content gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CTG")]
        [StringValue("CTG")]
        ClaveUnidad_CTG,

        /// <summary>
        /// metric carat
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CTM")]
        [StringValue("CTM")]
        ClaveUnidad_CTM,

        /// <summary>
        /// content ton (metric)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CTN")]
        [StringValue("CTN")]
        ClaveUnidad_CTN,

        /// <summary>
        /// curie
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CUR")]
        [StringValue("CUR")]
        ClaveUnidad_CUR,

        /// <summary>
        /// hundred pound (cwt) / hundred weight (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CWA")]
        [StringValue("CWA")]
        ClaveUnidad_CWA,

        /// <summary>
        /// hundred weight (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("CWI")]
        [StringValue("CWI")]
        ClaveUnidad_CWI,

        /// <summary>
        /// kilowatt hour per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D03")]
        [StringValue("D03")]
        ClaveUnidad_D03,

        /// <summary>
        /// lot  [unit of weight]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D04")]
        [StringValue("D04")]
        ClaveUnidad_D04,

        /// <summary>
        /// reciprocal second per steradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D1")]
        [StringValue("D1")]
        ClaveUnidad_D1,

        /// <summary>
        /// siemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D10")]
        [StringValue("D10")]
        ClaveUnidad_D10,

        /// <summary>
        /// mebibit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D11")]
        [StringValue("D11")]
        ClaveUnidad_D11,

        /// <summary>
        /// siemens square metre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D12")]
        [StringValue("D12")]
        ClaveUnidad_D12,

        /// <summary>
        /// sievert
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D13")]
        [StringValue("D13")]
        ClaveUnidad_D13,

        /// <summary>
        /// sone
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D15")]
        [StringValue("D15")]
        ClaveUnidad_D15,

        /// <summary>
        /// square centimetre per erg
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D16")]
        [StringValue("D16")]
        ClaveUnidad_D16,

        /// <summary>
        /// square centimetre per steradian erg
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D17")]
        [StringValue("D17")]
        ClaveUnidad_D17,

        /// <summary>
        /// metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D18")]
        [StringValue("D18")]
        ClaveUnidad_D18,

        /// <summary>
        /// square metre kelvin per watt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D19")]
        [StringValue("D19")]
        ClaveUnidad_D19,

        /// <summary>
        /// reciprocal second per steradian metre squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D2")]
        [StringValue("D2")]
        ClaveUnidad_D2,

        /// <summary>
        /// square metre per joule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D20")]
        [StringValue("D20")]
        ClaveUnidad_D20,

        /// <summary>
        /// square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D21")]
        [StringValue("D21")]
        ClaveUnidad_D21,

        /// <summary>
        /// square metre per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D22")]
        [StringValue("D22")]
        ClaveUnidad_D22,

        /// <summary>
        /// pen gram (protein)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D23")]
        [StringValue("D23")]
        ClaveUnidad_D23,

        /// <summary>
        /// square metre per steradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D24")]
        [StringValue("D24")]
        ClaveUnidad_D24,

        /// <summary>
        /// square metre per steradian joule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D25")]
        [StringValue("D25")]
        ClaveUnidad_D25,

        /// <summary>
        /// square metre per volt second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D26")]
        [StringValue("D26")]
        ClaveUnidad_D26,

        /// <summary>
        /// steradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D27")]
        [StringValue("D27")]
        ClaveUnidad_D27,

        /// <summary>
        /// terahertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D29")]
        [StringValue("D29")]
        ClaveUnidad_D29,

        /// <summary>
        /// terajoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D30")]
        [StringValue("D30")]
        ClaveUnidad_D30,

        /// <summary>
        /// terawatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D31")]
        [StringValue("D31")]
        ClaveUnidad_D31,

        /// <summary>
        /// terawatt hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D32")]
        [StringValue("D32")]
        ClaveUnidad_D32,

        /// <summary>
        /// tesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D33")]
        [StringValue("D33")]
        ClaveUnidad_D33,

        /// <summary>
        /// tex
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D34")]
        [StringValue("D34")]
        ClaveUnidad_D34,

        /// <summary>
        /// megabit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D36")]
        [StringValue("D36")]
        ClaveUnidad_D36,

        /// <summary>
        /// tonne per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D41")]
        [StringValue("D41")]
        ClaveUnidad_D41,

        /// <summary>
        /// tropical year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D42")]
        [StringValue("D42")]
        ClaveUnidad_D42,

        /// <summary>
        /// unified atomic mass unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D43")]
        [StringValue("D43")]
        ClaveUnidad_D43,

        /// <summary>
        /// var
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D44")]
        [StringValue("D44")]
        ClaveUnidad_D44,

        /// <summary>
        /// volt squared per kelvin squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D45")]
        [StringValue("D45")]
        ClaveUnidad_D45,

        /// <summary>
        /// volt - ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D46")]
        [StringValue("D46")]
        ClaveUnidad_D46,

        /// <summary>
        /// volt per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D47")]
        [StringValue("D47")]
        ClaveUnidad_D47,

        /// <summary>
        /// volt per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D48")]
        [StringValue("D48")]
        ClaveUnidad_D48,

        /// <summary>
        /// millivolt per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D49")]
        [StringValue("D49")]
        ClaveUnidad_D49,

        /// <summary>
        /// kilogram per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D5")]
        [StringValue("D5")]
        ClaveUnidad_D5,

        /// <summary>
        /// volt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D50")]
        [StringValue("D50")]
        ClaveUnidad_D50,

        /// <summary>
        /// volt per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D51")]
        [StringValue("D51")]
        ClaveUnidad_D51,

        /// <summary>
        /// watt per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D52")]
        [StringValue("D52")]
        ClaveUnidad_D52,

        /// <summary>
        /// watt per metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D53")]
        [StringValue("D53")]
        ClaveUnidad_D53,

        /// <summary>
        /// watt per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D54")]
        [StringValue("D54")]
        ClaveUnidad_D54,

        /// <summary>
        /// watt per square metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D55")]
        [StringValue("D55")]
        ClaveUnidad_D55,

        /// <summary>
        /// watt per square metre kelvin to the fourth power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D56")]
        [StringValue("D56")]
        ClaveUnidad_D56,

        /// <summary>
        /// watt per steradian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D57")]
        [StringValue("D57")]
        ClaveUnidad_D57,

        /// <summary>
        /// watt per steradian square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D58")]
        [StringValue("D58")]
        ClaveUnidad_D58,

        /// <summary>
        /// weber per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D59")]
        [StringValue("D59")]
        ClaveUnidad_D59,

        /// <summary>
        /// roentgen per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D6")]
        [StringValue("D6")]
        ClaveUnidad_D6,

        /// <summary>
        /// weber per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D60")]
        [StringValue("D60")]
        ClaveUnidad_D60,

        /// <summary>
        /// minute [unit of angle]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D61")]
        [StringValue("D61")]
        ClaveUnidad_D61,

        /// <summary>
        /// second [unit of angle]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D62")]
        [StringValue("D62")]
        ClaveUnidad_D62,

        /// <summary>
        /// book
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D63")]
        [StringValue("D63")]
        ClaveUnidad_D63,

        /// <summary>
        /// round
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D65")]
        [StringValue("D65")]
        ClaveUnidad_D65,

        /// <summary>
        /// number of words
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D68")]
        [StringValue("D68")]
        ClaveUnidad_D68,

        /// <summary>
        /// inch to the fourth power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D69")]
        [StringValue("D69")]
        ClaveUnidad_D69,

        /// <summary>
        /// joule square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D73")]
        [StringValue("D73")]
        ClaveUnidad_D73,

        /// <summary>
        /// kilogram per mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D74")]
        [StringValue("D74")]
        ClaveUnidad_D74,

        /// <summary>
        /// megacoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D77")]
        [StringValue("D77")]
        ClaveUnidad_D77,

        /// <summary>
        /// megajoule per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D78")]
        [StringValue("D78")]
        ClaveUnidad_D78,

        /// <summary>
        /// microwatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D80")]
        [StringValue("D80")]
        ClaveUnidad_D80,

        /// <summary>
        /// microtesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D81")]
        [StringValue("D81")]
        ClaveUnidad_D81,

        /// <summary>
        /// microvolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D82")]
        [StringValue("D82")]
        ClaveUnidad_D82,

        /// <summary>
        /// millinewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D83")]
        [StringValue("D83")]
        ClaveUnidad_D83,

        /// <summary>
        /// microwatt per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D85")]
        [StringValue("D85")]
        ClaveUnidad_D85,

        /// <summary>
        /// millicoulomb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D86")]
        [StringValue("D86")]
        ClaveUnidad_D86,

        /// <summary>
        /// millimole per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D87")]
        [StringValue("D87")]
        ClaveUnidad_D87,

        /// <summary>
        /// millicoulomb per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D88")]
        [StringValue("D88")]
        ClaveUnidad_D88,

        /// <summary>
        /// millicoulomb per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D89")]
        [StringValue("D89")]
        ClaveUnidad_D89,

        /// <summary>
        /// rem
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D91")]
        [StringValue("D91")]
        ClaveUnidad_D91,

        /// <summary>
        /// second per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D93")]
        [StringValue("D93")]
        ClaveUnidad_D93,

        /// <summary>
        /// second per cubic metre radian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D94")]
        [StringValue("D94")]
        ClaveUnidad_D94,

        /// <summary>
        /// joule per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("D95")]
        [StringValue("D95")]
        ClaveUnidad_D95,

        /// <summary>
        /// decare
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DAA")]
        [StringValue("DAA")]
        ClaveUnidad_DAA,

        /// <summary>
        /// ten day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DAD")]
        [StringValue("DAD")]
        ClaveUnidad_DAD,

        /// <summary>
        /// day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DAY")]
        [StringValue("DAY")]
        ClaveUnidad_DAY,

        /// <summary>
        /// dry pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DB")]
        [StringValue("DB")]
        ClaveUnidad_DB,

        /// <summary>
        /// degree [unit of angle]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DD")]
        [StringValue("DD")]
        ClaveUnidad_DD,

        /// <summary>
        /// decade
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DEC")]
        [StringValue("DEC")]
        ClaveUnidad_DEC,

        /// <summary>
        /// decigram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DG")]
        [StringValue("DG")]
        ClaveUnidad_DG,

        /// <summary>
        /// decagram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DJ")]
        [StringValue("DJ")]
        ClaveUnidad_DJ,

        /// <summary>
        /// decilitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DLT")]
        [StringValue("DLT")]
        ClaveUnidad_DLT,

        /// <summary>
        /// cubic decametre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DMA")]
        [StringValue("DMA")]
        ClaveUnidad_DMA,

        /// <summary>
        /// square decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DMK")]
        [StringValue("DMK")]
        ClaveUnidad_DMK,

        /// <summary>
        /// standard kilolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DMO")]
        [StringValue("DMO")]
        ClaveUnidad_DMO,

        /// <summary>
        /// cubic decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DMQ")]
        [StringValue("DMQ")]
        ClaveUnidad_DMQ,

        /// <summary>
        /// decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DMT")]
        [StringValue("DMT")]
        ClaveUnidad_DMT,

        /// <summary>
        /// decinewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DN")]
        [StringValue("DN")]
        ClaveUnidad_DN,

        /// <summary>
        /// dozen piece
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DPC")]
        [StringValue("DPC")]
        ClaveUnidad_DPC,

        /// <summary>
        /// dozen pair
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DPR")]
        [StringValue("DPR")]
        ClaveUnidad_DPR,

        /// <summary>
        /// displacement tonnage
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DPT")]
        [StringValue("DPT")]
        ClaveUnidad_DPT,

        /// <summary>
        /// dram (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DRA")]
        [StringValue("DRA")]
        ClaveUnidad_DRA,

        /// <summary>
        /// dram (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DRI")]
        [StringValue("DRI")]
        ClaveUnidad_DRI,

        /// <summary>
        /// dozen roll
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DRL")]
        [StringValue("DRL")]
        ClaveUnidad_DRL,

        /// <summary>
        /// dry ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DT")]
        [StringValue("DT")]
        ClaveUnidad_DT,

        /// <summary>
        /// decitonne
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DTN")]
        [StringValue("DTN")]
        ClaveUnidad_DTN,

        /// <summary>
        /// pennyweight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DWT")]
        [StringValue("DWT")]
        ClaveUnidad_DWT,

        /// <summary>
        /// dozen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DZN")]
        [StringValue("DZN")]
        ClaveUnidad_DZN,

        /// <summary>
        /// dozen pack
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("DZP")]
        [StringValue("DZP")]
        ClaveUnidad_DZP,

        /// <summary>
        /// newton per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E01")]
        [StringValue("E01")]
        ClaveUnidad_E01,

        /// <summary>
        /// megawatt hour per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E07")]
        [StringValue("E07")]
        ClaveUnidad_E07,

        /// <summary>
        /// megawatt per hertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E08")]
        [StringValue("E08")]
        ClaveUnidad_E08,

        /// <summary>
        /// milliampere hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E09")]
        [StringValue("E09")]
        ClaveUnidad_E09,

        /// <summary>
        /// degree day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E10")]
        [StringValue("E10")]
        ClaveUnidad_E10,

        /// <summary>
        /// mille
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E12")]
        [StringValue("E12")]
        ClaveUnidad_E12,

        /// <summary>
        /// kilocalorie (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E14")]
        [StringValue("E14")]
        ClaveUnidad_E14,

        /// <summary>
        /// kilocalorie (thermochemical) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E15")]
        [StringValue("E15")]
        ClaveUnidad_E15,

        /// <summary>
        /// million Btu(IT) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E16")]
        [StringValue("E16")]
        ClaveUnidad_E16,

        /// <summary>
        /// cubic foot per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E17")]
        [StringValue("E17")]
        ClaveUnidad_E17,

        /// <summary>
        /// tonne per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E18")]
        [StringValue("E18")]
        ClaveUnidad_E18,

        /// <summary>
        /// ping
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E19")]
        [StringValue("E19")]
        ClaveUnidad_E19,

        /// <summary>
        /// megabit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E20")]
        [StringValue("E20")]
        ClaveUnidad_E20,

        /// <summary>
        /// shares
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E21")]
        [StringValue("E21")]
        ClaveUnidad_E21,

        /// <summary>
        /// TEU
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E22")]
        [StringValue("E22")]
        ClaveUnidad_E22,

        /// <summary>
        /// tyre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E23")]
        [StringValue("E23")]
        ClaveUnidad_E23,

        /// <summary>
        /// active unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E25")]
        [StringValue("E25")]
        ClaveUnidad_E25,

        /// <summary>
        /// dose
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E27")]
        [StringValue("E27")]
        ClaveUnidad_E27,

        /// <summary>
        /// air dry ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E28")]
        [StringValue("E28")]
        ClaveUnidad_E28,

        /// <summary>
        /// strand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E30")]
        [StringValue("E30")]
        ClaveUnidad_E30,

        /// <summary>
        /// square metre per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E31")]
        [StringValue("E31")]
        ClaveUnidad_E31,

        /// <summary>
        /// litre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E32")]
        [StringValue("E32")]
        ClaveUnidad_E32,

        /// <summary>
        /// foot per thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E33")]
        [StringValue("E33")]
        ClaveUnidad_E33,

        /// <summary>
        /// gigabyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E34")]
        [StringValue("E34")]
        ClaveUnidad_E34,

        /// <summary>
        /// terabyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E35")]
        [StringValue("E35")]
        ClaveUnidad_E35,

        /// <summary>
        /// petabyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E36")]
        [StringValue("E36")]
        ClaveUnidad_E36,

        /// <summary>
        /// pixel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E37")]
        [StringValue("E37")]
        ClaveUnidad_E37,

        /// <summary>
        /// megapixel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E38")]
        [StringValue("E38")]
        ClaveUnidad_E38,

        /// <summary>
        /// dots per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E39")]
        [StringValue("E39")]
        ClaveUnidad_E39,

        /// <summary>
        /// gross kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E4")]
        [StringValue("E4")]
        ClaveUnidad_E4,

        /// <summary>
        /// part per hundred thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E40")]
        [StringValue("E40")]
        ClaveUnidad_E40,

        /// <summary>
        /// kilogram-force per square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E41")]
        [StringValue("E41")]
        ClaveUnidad_E41,

        /// <summary>
        /// kilogram-force per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E42")]
        [StringValue("E42")]
        ClaveUnidad_E42,

        /// <summary>
        /// joule per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E43")]
        [StringValue("E43")]
        ClaveUnidad_E43,

        /// <summary>
        /// kilogram-force metre per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E44")]
        [StringValue("E44")]
        ClaveUnidad_E44,

        /// <summary>
        /// milliohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E45")]
        [StringValue("E45")]
        ClaveUnidad_E45,

        /// <summary>
        /// kilowatt hour per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E46")]
        [StringValue("E46")]
        ClaveUnidad_E46,

        /// <summary>
        /// kilowatt hour per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E47")]
        [StringValue("E47")]
        ClaveUnidad_E47,

        /// <summary>
        /// service unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E48")]
        [StringValue("E48")]
        ClaveUnidad_E48,

        /// <summary>
        /// working day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E49")]
        [StringValue("E49")]
        ClaveUnidad_E49,

        /// <summary>
        /// accounting unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E50")]
        [StringValue("E50")]
        ClaveUnidad_E50,

        /// <summary>
        /// job
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E51")]
        [StringValue("E51")]
        ClaveUnidad_E51,

        /// <summary>
        /// run foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E52")]
        [StringValue("E52")]
        ClaveUnidad_E52,

        /// <summary>
        /// test
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E53")]
        [StringValue("E53")]
        ClaveUnidad_E53,

        /// <summary>
        /// trip
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E54")]
        [StringValue("E54")]
        ClaveUnidad_E54,

        /// <summary>
        /// use
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E55")]
        [StringValue("E55")]
        ClaveUnidad_E55,

        /// <summary>
        /// well
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E56")]
        [StringValue("E56")]
        ClaveUnidad_E56,

        /// <summary>
        /// zone
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E57")]
        [StringValue("E57")]
        ClaveUnidad_E57,

        /// <summary>
        /// exabit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E58")]
        [StringValue("E58")]
        ClaveUnidad_E58,

        /// <summary>
        /// exbibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E59")]
        [StringValue("E59")]
        ClaveUnidad_E59,

        /// <summary>
        /// pebibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E60")]
        [StringValue("E60")]
        ClaveUnidad_E60,

        /// <summary>
        /// tebibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E61")]
        [StringValue("E61")]
        ClaveUnidad_E61,

        /// <summary>
        /// gibibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E62")]
        [StringValue("E62")]
        ClaveUnidad_E62,

        /// <summary>
        /// mebibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E63")]
        [StringValue("E63")]
        ClaveUnidad_E63,

        /// <summary>
        /// kibibyte
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E64")]
        [StringValue("E64")]
        ClaveUnidad_E64,

        /// <summary>
        /// exbibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E65")]
        [StringValue("E65")]
        ClaveUnidad_E65,

        /// <summary>
        /// exbibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E66")]
        [StringValue("E66")]
        ClaveUnidad_E66,

        /// <summary>
        /// exbibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E67")]
        [StringValue("E67")]
        ClaveUnidad_E67,

        /// <summary>
        /// gigabyte per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E68")]
        [StringValue("E68")]
        ClaveUnidad_E68,

        /// <summary>
        /// gibibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E69")]
        [StringValue("E69")]
        ClaveUnidad_E69,

        /// <summary>
        /// gibibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E70")]
        [StringValue("E70")]
        ClaveUnidad_E70,

        /// <summary>
        /// gibibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E71")]
        [StringValue("E71")]
        ClaveUnidad_E71,

        /// <summary>
        /// kibibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E72")]
        [StringValue("E72")]
        ClaveUnidad_E72,

        /// <summary>
        /// kibibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E73")]
        [StringValue("E73")]
        ClaveUnidad_E73,

        /// <summary>
        /// kibibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E74")]
        [StringValue("E74")]
        ClaveUnidad_E74,

        /// <summary>
        /// mebibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E75")]
        [StringValue("E75")]
        ClaveUnidad_E75,

        /// <summary>
        /// mebibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E76")]
        [StringValue("E76")]
        ClaveUnidad_E76,

        /// <summary>
        /// mebibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E77")]
        [StringValue("E77")]
        ClaveUnidad_E77,

        /// <summary>
        /// petabit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E78")]
        [StringValue("E78")]
        ClaveUnidad_E78,

        /// <summary>
        /// petabit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E79")]
        [StringValue("E79")]
        ClaveUnidad_E79,

        /// <summary>
        /// pebibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E80")]
        [StringValue("E80")]
        ClaveUnidad_E80,

        /// <summary>
        /// pebibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E81")]
        [StringValue("E81")]
        ClaveUnidad_E81,

        /// <summary>
        /// pebibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E82")]
        [StringValue("E82")]
        ClaveUnidad_E82,

        /// <summary>
        /// terabit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E83")]
        [StringValue("E83")]
        ClaveUnidad_E83,

        /// <summary>
        /// terabit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E84")]
        [StringValue("E84")]
        ClaveUnidad_E84,

        /// <summary>
        /// tebibit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E85")]
        [StringValue("E85")]
        ClaveUnidad_E85,

        /// <summary>
        /// tebibit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E86")]
        [StringValue("E86")]
        ClaveUnidad_E86,

        /// <summary>
        /// tebibit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E87")]
        [StringValue("E87")]
        ClaveUnidad_E87,

        /// <summary>
        /// bit per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E88")]
        [StringValue("E88")]
        ClaveUnidad_E88,

        /// <summary>
        /// bit per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E89")]
        [StringValue("E89")]
        ClaveUnidad_E89,

        /// <summary>
        /// reciprocal centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E90")]
        [StringValue("E90")]
        ClaveUnidad_E90,

        /// <summary>
        /// reciprocal day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E91")]
        [StringValue("E91")]
        ClaveUnidad_E91,

        /// <summary>
        /// cubic decimetre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E92")]
        [StringValue("E92")]
        ClaveUnidad_E92,

        /// <summary>
        /// kilogram per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E93")]
        [StringValue("E93")]
        ClaveUnidad_E93,

        /// <summary>
        /// kilomole per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E94")]
        [StringValue("E94")]
        ClaveUnidad_E94,

        /// <summary>
        /// mole per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E95")]
        [StringValue("E95")]
        ClaveUnidad_E95,

        /// <summary>
        /// degree per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E96")]
        [StringValue("E96")]
        ClaveUnidad_E96,

        /// <summary>
        /// millimetre per degree Celcius metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E97")]
        [StringValue("E97")]
        ClaveUnidad_E97,

        /// <summary>
        /// degree Celsius per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E98")]
        [StringValue("E98")]
        ClaveUnidad_E98,

        /// <summary>
        /// hectopascal per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("E99")]
        [StringValue("E99")]
        ClaveUnidad_E99,

        /// <summary>
        /// each
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("EA")]
        [StringValue("EA")]
        ClaveUnidad_EA,

        /// <summary>
        /// electronic mail box
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("EB")]
        [StringValue("EB")]
        ClaveUnidad_EB,

        /// <summary>
        /// equivalent gallon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("EQ")]
        [StringValue("EQ")]
        ClaveUnidad_EQ,

        /// <summary>
        /// bit per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F01")]
        [StringValue("F01")]
        ClaveUnidad_F01,

        /// <summary>
        /// kelvin per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F02")]
        [StringValue("F02")]
        ClaveUnidad_F02,

        /// <summary>
        /// kilopascal per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F03")]
        [StringValue("F03")]
        ClaveUnidad_F03,

        /// <summary>
        /// millibar per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F04")]
        [StringValue("F04")]
        ClaveUnidad_F04,

        /// <summary>
        /// megapascal per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F05")]
        [StringValue("F05")]
        ClaveUnidad_F05,

        /// <summary>
        /// poise per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F06")]
        [StringValue("F06")]
        ClaveUnidad_F06,

        /// <summary>
        /// pascal per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F07")]
        [StringValue("F07")]
        ClaveUnidad_F07,

        /// <summary>
        /// milliampere per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F08")]
        [StringValue("F08")]
        ClaveUnidad_F08,

        /// <summary>
        /// kelvin per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F10")]
        [StringValue("F10")]
        ClaveUnidad_F10,

        /// <summary>
        /// kelvin per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F11")]
        [StringValue("F11")]
        ClaveUnidad_F11,

        /// <summary>
        /// kelvin per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F12")]
        [StringValue("F12")]
        ClaveUnidad_F12,

        /// <summary>
        /// slug
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F13")]
        [StringValue("F13")]
        ClaveUnidad_F13,

        /// <summary>
        /// gram per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F14")]
        [StringValue("F14")]
        ClaveUnidad_F14,

        /// <summary>
        /// kilogram per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F15")]
        [StringValue("F15")]
        ClaveUnidad_F15,

        /// <summary>
        /// milligram per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F16")]
        [StringValue("F16")]
        ClaveUnidad_F16,

        /// <summary>
        /// pound-force per foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F17")]
        [StringValue("F17")]
        ClaveUnidad_F17,

        /// <summary>
        /// kilogram square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F18")]
        [StringValue("F18")]
        ClaveUnidad_F18,

        /// <summary>
        /// kilogram square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F19")]
        [StringValue("F19")]
        ClaveUnidad_F19,

        /// <summary>
        /// pound inch squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F20")]
        [StringValue("F20")]
        ClaveUnidad_F20,

        /// <summary>
        /// pound-force inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F21")]
        [StringValue("F21")]
        ClaveUnidad_F21,

        /// <summary>
        /// pound-force foot per ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F22")]
        [StringValue("F22")]
        ClaveUnidad_F22,

        /// <summary>
        /// gram per cubic decimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F23")]
        [StringValue("F23")]
        ClaveUnidad_F23,

        /// <summary>
        /// kilogram per kilomol
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F24")]
        [StringValue("F24")]
        ClaveUnidad_F24,

        /// <summary>
        /// gram per hertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F25")]
        [StringValue("F25")]
        ClaveUnidad_F25,

        /// <summary>
        /// gram per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F26")]
        [StringValue("F26")]
        ClaveUnidad_F26,

        /// <summary>
        /// gram per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F27")]
        [StringValue("F27")]
        ClaveUnidad_F27,

        /// <summary>
        /// gram per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F28")]
        [StringValue("F28")]
        ClaveUnidad_F28,

        /// <summary>
        /// gram per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F29")]
        [StringValue("F29")]
        ClaveUnidad_F29,

        /// <summary>
        /// kilogram per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F30")]
        [StringValue("F30")]
        ClaveUnidad_F30,

        /// <summary>
        /// kilogram per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F31")]
        [StringValue("F31")]
        ClaveUnidad_F31,

        /// <summary>
        /// milligram per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F32")]
        [StringValue("F32")]
        ClaveUnidad_F32,

        /// <summary>
        /// milligram per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F33")]
        [StringValue("F33")]
        ClaveUnidad_F33,

        /// <summary>
        /// milligram per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F34")]
        [StringValue("F34")]
        ClaveUnidad_F34,

        /// <summary>
        /// gram per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F35")]
        [StringValue("F35")]
        ClaveUnidad_F35,

        /// <summary>
        /// gram per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F36")]
        [StringValue("F36")]
        ClaveUnidad_F36,

        /// <summary>
        /// gram per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F37")]
        [StringValue("F37")]
        ClaveUnidad_F37,

        /// <summary>
        /// gram per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F38")]
        [StringValue("F38")]
        ClaveUnidad_F38,

        /// <summary>
        /// kilogram per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F39")]
        [StringValue("F39")]
        ClaveUnidad_F39,

        /// <summary>
        /// kilogram per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F40")]
        [StringValue("F40")]
        ClaveUnidad_F40,

        /// <summary>
        /// kilogram per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F41")]
        [StringValue("F41")]
        ClaveUnidad_F41,

        /// <summary>
        /// kilogram per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F42")]
        [StringValue("F42")]
        ClaveUnidad_F42,

        /// <summary>
        /// milligram per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F43")]
        [StringValue("F43")]
        ClaveUnidad_F43,

        /// <summary>
        /// milligram per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F44")]
        [StringValue("F44")]
        ClaveUnidad_F44,

        /// <summary>
        /// milligram per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F45")]
        [StringValue("F45")]
        ClaveUnidad_F45,

        /// <summary>
        /// milligram per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F46")]
        [StringValue("F46")]
        ClaveUnidad_F46,

        /// <summary>
        /// newton per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F47")]
        [StringValue("F47")]
        ClaveUnidad_F47,

        /// <summary>
        /// pound-force per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F48")]
        [StringValue("F48")]
        ClaveUnidad_F48,

        /// <summary>
        /// rod [unit of distance]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F49")]
        [StringValue("F49")]
        ClaveUnidad_F49,

        /// <summary>
        /// micrometre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F50")]
        [StringValue("F50")]
        ClaveUnidad_F50,

        /// <summary>
        /// centimetre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F51")]
        [StringValue("F51")]
        ClaveUnidad_F51,

        /// <summary>
        /// metre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F52")]
        [StringValue("F52")]
        ClaveUnidad_F52,

        /// <summary>
        /// millimetre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F53")]
        [StringValue("F53")]
        ClaveUnidad_F53,

        /// <summary>
        /// milliohm per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F54")]
        [StringValue("F54")]
        ClaveUnidad_F54,

        /// <summary>
        /// ohm per mile (statute mile)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F55")]
        [StringValue("F55")]
        ClaveUnidad_F55,

        /// <summary>
        /// ohm per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F56")]
        [StringValue("F56")]
        ClaveUnidad_F56,

        /// <summary>
        /// milliampere per pound-force per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F57")]
        [StringValue("F57")]
        ClaveUnidad_F57,

        /// <summary>
        /// reciprocal bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F58")]
        [StringValue("F58")]
        ClaveUnidad_F58,

        /// <summary>
        /// milliampere per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F59")]
        [StringValue("F59")]
        ClaveUnidad_F59,

        /// <summary>
        /// degree Celsius per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F60")]
        [StringValue("F60")]
        ClaveUnidad_F60,

        /// <summary>
        /// kelvin per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F61")]
        [StringValue("F61")]
        ClaveUnidad_F61,

        /// <summary>
        /// gram per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F62")]
        [StringValue("F62")]
        ClaveUnidad_F62,

        /// <summary>
        /// gram per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F63")]
        [StringValue("F63")]
        ClaveUnidad_F63,

        /// <summary>
        /// gram per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F64")]
        [StringValue("F64")]
        ClaveUnidad_F64,

        /// <summary>
        /// gram per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F65")]
        [StringValue("F65")]
        ClaveUnidad_F65,

        /// <summary>
        /// kilogram per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F66")]
        [StringValue("F66")]
        ClaveUnidad_F66,

        /// <summary>
        /// kilogram per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F67")]
        [StringValue("F67")]
        ClaveUnidad_F67,

        /// <summary>
        /// kilogram per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F68")]
        [StringValue("F68")]
        ClaveUnidad_F68,

        /// <summary>
        /// kilogram per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F69")]
        [StringValue("F69")]
        ClaveUnidad_F69,

        /// <summary>
        /// milligram per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F70")]
        [StringValue("F70")]
        ClaveUnidad_F70,

        /// <summary>
        /// milligram per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F71")]
        [StringValue("F71")]
        ClaveUnidad_F71,

        /// <summary>
        /// milligram per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F72")]
        [StringValue("F72")]
        ClaveUnidad_F72,

        /// <summary>
        /// milligram per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F73")]
        [StringValue("F73")]
        ClaveUnidad_F73,

        /// <summary>
        /// gram per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F74")]
        [StringValue("F74")]
        ClaveUnidad_F74,

        /// <summary>
        /// milligram per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F75")]
        [StringValue("F75")]
        ClaveUnidad_F75,

        /// <summary>
        /// milliampere per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F76")]
        [StringValue("F76")]
        ClaveUnidad_F76,

        /// <summary>
        /// pascal second per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F77")]
        [StringValue("F77")]
        ClaveUnidad_F77,

        /// <summary>
        /// inch of water
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F78")]
        [StringValue("F78")]
        ClaveUnidad_F78,

        /// <summary>
        /// inch of mercury
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F79")]
        [StringValue("F79")]
        ClaveUnidad_F79,

        /// <summary>
        /// water horse power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F80")]
        [StringValue("F80")]
        ClaveUnidad_F80,

        /// <summary>
        /// bar per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F81")]
        [StringValue("F81")]
        ClaveUnidad_F81,

        /// <summary>
        /// hectopascal per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F82")]
        [StringValue("F82")]
        ClaveUnidad_F82,

        /// <summary>
        /// kilopascal per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F83")]
        [StringValue("F83")]
        ClaveUnidad_F83,

        /// <summary>
        /// millibar per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F84")]
        [StringValue("F84")]
        ClaveUnidad_F84,

        /// <summary>
        /// megapascal per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F85")]
        [StringValue("F85")]
        ClaveUnidad_F85,

        /// <summary>
        /// poise per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F86")]
        [StringValue("F86")]
        ClaveUnidad_F86,

        /// <summary>
        /// volt per litre minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F87")]
        [StringValue("F87")]
        ClaveUnidad_F87,

        /// <summary>
        /// newton centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F88")]
        [StringValue("F88")]
        ClaveUnidad_F88,

        /// <summary>
        /// newton metre per degree
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F89")]
        [StringValue("F89")]
        ClaveUnidad_F89,

        /// <summary>
        /// newton metre per ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F90")]
        [StringValue("F90")]
        ClaveUnidad_F90,

        /// <summary>
        /// bar litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F91")]
        [StringValue("F91")]
        ClaveUnidad_F91,

        /// <summary>
        /// bar cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F92")]
        [StringValue("F92")]
        ClaveUnidad_F92,

        /// <summary>
        /// hectopascal litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F93")]
        [StringValue("F93")]
        ClaveUnidad_F93,

        /// <summary>
        /// hectopascal cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F94")]
        [StringValue("F94")]
        ClaveUnidad_F94,

        /// <summary>
        /// millibar litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F95")]
        [StringValue("F95")]
        ClaveUnidad_F95,

        /// <summary>
        /// millibar cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F96")]
        [StringValue("F96")]
        ClaveUnidad_F96,

        /// <summary>
        /// megapascal litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F97")]
        [StringValue("F97")]
        ClaveUnidad_F97,

        /// <summary>
        /// megapascal cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F98")]
        [StringValue("F98")]
        ClaveUnidad_F98,

        /// <summary>
        /// pascal litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("F99")]
        [StringValue("F99")]
        ClaveUnidad_F99,

        /// <summary>
        /// degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FAH")]
        [StringValue("FAH")]
        ClaveUnidad_FAH,

        /// <summary>
        /// farad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FAR")]
        [StringValue("FAR")]
        ClaveUnidad_FAR,

        /// <summary>
        /// fibre metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FBM")]
        [StringValue("FBM")]
        ClaveUnidad_FBM,

        /// <summary>
        /// thousand cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FC")]
        [StringValue("FC")]
        ClaveUnidad_FC,

        /// <summary>
        /// hundred cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FF")]
        [StringValue("FF")]
        ClaveUnidad_FF,

        /// <summary>
        /// micromole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FH")]
        [StringValue("FH")]
        ClaveUnidad_FH,

        /// <summary>
        /// failures in time
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FIT")]
        [StringValue("FIT")]
        ClaveUnidad_FIT,

        /// <summary>
        /// flake ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FL")]
        [StringValue("FL")]
        ClaveUnidad_FL,

        /// <summary>
        /// foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FOT")]
        [StringValue("FOT")]
        ClaveUnidad_FOT,

        /// <summary>
        /// pound per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FP")]
        [StringValue("FP")]
        ClaveUnidad_FP,

        /// <summary>
        /// foot per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FR")]
        [StringValue("FR")]
        ClaveUnidad_FR,

        /// <summary>
        /// foot per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FS")]
        [StringValue("FS")]
        ClaveUnidad_FS,

        /// <summary>
        /// square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FTK")]
        [StringValue("FTK")]
        ClaveUnidad_FTK,

        /// <summary>
        /// cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("FTQ")]
        [StringValue("FTQ")]
        ClaveUnidad_FTQ,

        /// <summary>
        /// pascal cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G01")]
        [StringValue("G01")]
        ClaveUnidad_G01,

        /// <summary>
        /// centimetre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G04")]
        [StringValue("G04")]
        ClaveUnidad_G04,

        /// <summary>
        /// metre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G05")]
        [StringValue("G05")]
        ClaveUnidad_G05,

        /// <summary>
        /// millimetre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G06")]
        [StringValue("G06")]
        ClaveUnidad_G06,

        /// <summary>
        /// square inch per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G08")]
        [StringValue("G08")]
        ClaveUnidad_G08,

        /// <summary>
        /// square metre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G09")]
        [StringValue("G09")]
        ClaveUnidad_G09,

        /// <summary>
        /// stokes per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G10")]
        [StringValue("G10")]
        ClaveUnidad_G10,

        /// <summary>
        /// gram per cubic centimetre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G11")]
        [StringValue("G11")]
        ClaveUnidad_G11,

        /// <summary>
        /// gram per cubic decimetre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G12")]
        [StringValue("G12")]
        ClaveUnidad_G12,

        /// <summary>
        /// gram per litre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G13")]
        [StringValue("G13")]
        ClaveUnidad_G13,

        /// <summary>
        /// gram per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G14")]
        [StringValue("G14")]
        ClaveUnidad_G14,

        /// <summary>
        /// gram per millilitre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G15")]
        [StringValue("G15")]
        ClaveUnidad_G15,

        /// <summary>
        /// kilogram per cubic centimetre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G16")]
        [StringValue("G16")]
        ClaveUnidad_G16,

        /// <summary>
        /// kilogram per litre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G17")]
        [StringValue("G17")]
        ClaveUnidad_G17,

        /// <summary>
        /// kilogram per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G18")]
        [StringValue("G18")]
        ClaveUnidad_G18,

        /// <summary>
        /// newton metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G19")]
        [StringValue("G19")]
        ClaveUnidad_G19,

        /// <summary>
        /// US gallon per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G2")]
        [StringValue("G2")]
        ClaveUnidad_G2,

        /// <summary>
        /// pound-force foot per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G20")]
        [StringValue("G20")]
        ClaveUnidad_G20,

        /// <summary>
        /// cup [unit of volume]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G21")]
        [StringValue("G21")]
        ClaveUnidad_G21,

        /// <summary>
        /// peck
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G23")]
        [StringValue("G23")]
        ClaveUnidad_G23,

        /// <summary>
        /// tablespoon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G24")]
        [StringValue("G24")]
        ClaveUnidad_G24,

        /// <summary>
        /// teaspoon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G25")]
        [StringValue("G25")]
        ClaveUnidad_G25,

        /// <summary>
        /// stere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G26")]
        [StringValue("G26")]
        ClaveUnidad_G26,

        /// <summary>
        /// cubic centimetre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G27")]
        [StringValue("G27")]
        ClaveUnidad_G27,

        /// <summary>
        /// litre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G28")]
        [StringValue("G28")]
        ClaveUnidad_G28,

        /// <summary>
        /// cubic metre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G29")]
        [StringValue("G29")]
        ClaveUnidad_G29,

        /// <summary>
        /// Imperial gallon per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G3")]
        [StringValue("G3")]
        ClaveUnidad_G3,

        /// <summary>
        /// millilitre per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G30")]
        [StringValue("G30")]
        ClaveUnidad_G30,

        /// <summary>
        /// kilogram per cubic centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G31")]
        [StringValue("G31")]
        ClaveUnidad_G31,

        /// <summary>
        /// ounce (avoirdupois) per cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G32")]
        [StringValue("G32")]
        ClaveUnidad_G32,

        /// <summary>
        /// gram per cubic centimetre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G33")]
        [StringValue("G33")]
        ClaveUnidad_G33,

        /// <summary>
        /// gram per cubic decimetre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G34")]
        [StringValue("G34")]
        ClaveUnidad_G34,

        /// <summary>
        /// gram per litre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G35")]
        [StringValue("G35")]
        ClaveUnidad_G35,

        /// <summary>
        /// gram per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G36")]
        [StringValue("G36")]
        ClaveUnidad_G36,

        /// <summary>
        /// gram per millilitre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G37")]
        [StringValue("G37")]
        ClaveUnidad_G37,

        /// <summary>
        /// kilogram per cubic centimetre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G38")]
        [StringValue("G38")]
        ClaveUnidad_G38,

        /// <summary>
        /// kilogram per litre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G39")]
        [StringValue("G39")]
        ClaveUnidad_G39,

        /// <summary>
        /// kilogram per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G40")]
        [StringValue("G40")]
        ClaveUnidad_G40,

        /// <summary>
        /// square metre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G41")]
        [StringValue("G41")]
        ClaveUnidad_G41,

        /// <summary>
        /// microsiemens per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G42")]
        [StringValue("G42")]
        ClaveUnidad_G42,

        /// <summary>
        /// microsiemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G43")]
        [StringValue("G43")]
        ClaveUnidad_G43,

        /// <summary>
        /// nanosiemens per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G44")]
        [StringValue("G44")]
        ClaveUnidad_G44,

        /// <summary>
        /// nanosiemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G45")]
        [StringValue("G45")]
        ClaveUnidad_G45,

        /// <summary>
        /// stokes per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G46")]
        [StringValue("G46")]
        ClaveUnidad_G46,

        /// <summary>
        /// cubic centimetre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G47")]
        [StringValue("G47")]
        ClaveUnidad_G47,

        /// <summary>
        /// cubic centimetre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G48")]
        [StringValue("G48")]
        ClaveUnidad_G48,

        /// <summary>
        /// cubic centimetre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G49")]
        [StringValue("G49")]
        ClaveUnidad_G49,

        /// <summary>
        /// gallon (US) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G50")]
        [StringValue("G50")]
        ClaveUnidad_G50,

        /// <summary>
        /// litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G51")]
        [StringValue("G51")]
        ClaveUnidad_G51,

        /// <summary>
        /// cubic metre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G52")]
        [StringValue("G52")]
        ClaveUnidad_G52,

        /// <summary>
        /// cubic metre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G53")]
        [StringValue("G53")]
        ClaveUnidad_G53,

        /// <summary>
        /// millilitre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G54")]
        [StringValue("G54")]
        ClaveUnidad_G54,

        /// <summary>
        /// millilitre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G55")]
        [StringValue("G55")]
        ClaveUnidad_G55,

        /// <summary>
        /// cubic inch per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G56")]
        [StringValue("G56")]
        ClaveUnidad_G56,

        /// <summary>
        /// cubic inch per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G57")]
        [StringValue("G57")]
        ClaveUnidad_G57,

        /// <summary>
        /// cubic inch per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G58")]
        [StringValue("G58")]
        ClaveUnidad_G58,

        /// <summary>
        /// milliampere per litre minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G59")]
        [StringValue("G59")]
        ClaveUnidad_G59,

        /// <summary>
        /// volt per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G60")]
        [StringValue("G60")]
        ClaveUnidad_G60,

        /// <summary>
        /// cubic centimetre per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G61")]
        [StringValue("G61")]
        ClaveUnidad_G61,

        /// <summary>
        /// cubic centimetre per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G62")]
        [StringValue("G62")]
        ClaveUnidad_G62,

        /// <summary>
        /// cubic centimetre per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G63")]
        [StringValue("G63")]
        ClaveUnidad_G63,

        /// <summary>
        /// cubic centimetre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G64")]
        [StringValue("G64")]
        ClaveUnidad_G64,

        /// <summary>
        /// litre per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G65")]
        [StringValue("G65")]
        ClaveUnidad_G65,

        /// <summary>
        /// litre per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G66")]
        [StringValue("G66")]
        ClaveUnidad_G66,

        /// <summary>
        /// litre per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G67")]
        [StringValue("G67")]
        ClaveUnidad_G67,

        /// <summary>
        /// litre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G68")]
        [StringValue("G68")]
        ClaveUnidad_G68,

        /// <summary>
        /// cubic metre per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G69")]
        [StringValue("G69")]
        ClaveUnidad_G69,

        /// <summary>
        /// cubic metre per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G70")]
        [StringValue("G70")]
        ClaveUnidad_G70,

        /// <summary>
        /// cubic metre per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G71")]
        [StringValue("G71")]
        ClaveUnidad_G71,

        /// <summary>
        /// cubic metre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G72")]
        [StringValue("G72")]
        ClaveUnidad_G72,

        /// <summary>
        /// millilitre per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G73")]
        [StringValue("G73")]
        ClaveUnidad_G73,

        /// <summary>
        /// millilitre per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G74")]
        [StringValue("G74")]
        ClaveUnidad_G74,

        /// <summary>
        /// millilitre per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G75")]
        [StringValue("G75")]
        ClaveUnidad_G75,

        /// <summary>
        /// millilitre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G76")]
        [StringValue("G76")]
        ClaveUnidad_G76,

        /// <summary>
        /// millimetre to the fourth power
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G77")]
        [StringValue("G77")]
        ClaveUnidad_G77,

        /// <summary>
        /// cubic centimetre per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G78")]
        [StringValue("G78")]
        ClaveUnidad_G78,

        /// <summary>
        /// cubic centimetre per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G79")]
        [StringValue("G79")]
        ClaveUnidad_G79,

        /// <summary>
        /// cubic centimetre per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G80")]
        [StringValue("G80")]
        ClaveUnidad_G80,

        /// <summary>
        /// cubic centimetre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G81")]
        [StringValue("G81")]
        ClaveUnidad_G81,

        /// <summary>
        /// litre per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G82")]
        [StringValue("G82")]
        ClaveUnidad_G82,

        /// <summary>
        /// litre per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G83")]
        [StringValue("G83")]
        ClaveUnidad_G83,

        /// <summary>
        /// litre per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G84")]
        [StringValue("G84")]
        ClaveUnidad_G84,

        /// <summary>
        /// litre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G85")]
        [StringValue("G85")]
        ClaveUnidad_G85,

        /// <summary>
        /// cubic metre per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G86")]
        [StringValue("G86")]
        ClaveUnidad_G86,

        /// <summary>
        /// cubic metre per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G87")]
        [StringValue("G87")]
        ClaveUnidad_G87,

        /// <summary>
        /// cubic metre per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G88")]
        [StringValue("G88")]
        ClaveUnidad_G88,

        /// <summary>
        /// cubic metre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G89")]
        [StringValue("G89")]
        ClaveUnidad_G89,

        /// <summary>
        /// millilitre per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G90")]
        [StringValue("G90")]
        ClaveUnidad_G90,

        /// <summary>
        /// millilitre per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G91")]
        [StringValue("G91")]
        ClaveUnidad_G91,

        /// <summary>
        /// millilitre per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G92")]
        [StringValue("G92")]
        ClaveUnidad_G92,

        /// <summary>
        /// millilitre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G93")]
        [StringValue("G93")]
        ClaveUnidad_G93,

        /// <summary>
        /// cubic centimetre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G94")]
        [StringValue("G94")]
        ClaveUnidad_G94,

        /// <summary>
        /// litre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G95")]
        [StringValue("G95")]
        ClaveUnidad_G95,

        /// <summary>
        /// cubic metre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G96")]
        [StringValue("G96")]
        ClaveUnidad_G96,

        /// <summary>
        /// millilitre per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G97")]
        [StringValue("G97")]
        ClaveUnidad_G97,

        /// <summary>
        /// microhenry per kiloohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G98")]
        [StringValue("G98")]
        ClaveUnidad_G98,

        /// <summary>
        /// microhenry per ohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("G99")]
        [StringValue("G99")]
        ClaveUnidad_G99,

        /// <summary>
        /// gallon (US) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GB")]
        [StringValue("GB")]
        ClaveUnidad_GB,

        /// <summary>
        /// gigabecquerel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GBQ")]
        [StringValue("GBQ")]
        ClaveUnidad_GBQ,

        /// <summary>
        /// gram, dry weight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GDW")]
        [StringValue("GDW")]
        ClaveUnidad_GDW,

        /// <summary>
        /// pound per gallon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GE")]
        [StringValue("GE")]
        ClaveUnidad_GE,

        /// <summary>
        /// gram per metre (gram per 100 centimetres)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GF")]
        [StringValue("GF")]
        ClaveUnidad_GF,

        /// <summary>
        /// gram of fissile isotope
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GFI")]
        [StringValue("GFI")]
        ClaveUnidad_GFI,

        /// <summary>
        /// great gross
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GGR")]
        [StringValue("GGR")]
        ClaveUnidad_GGR,

        /// <summary>
        /// gill (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GIA")]
        [StringValue("GIA")]
        ClaveUnidad_GIA,

        /// <summary>
        /// gram, including container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GIC")]
        [StringValue("GIC")]
        ClaveUnidad_GIC,

        /// <summary>
        /// gill (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GII")]
        [StringValue("GII")]
        ClaveUnidad_GII,

        /// <summary>
        /// gram, including inner packaging
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GIP")]
        [StringValue("GIP")]
        ClaveUnidad_GIP,

        /// <summary>
        /// gram per millilitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GJ")]
        [StringValue("GJ")]
        ClaveUnidad_GJ,

        /// <summary>
        /// gram per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GL")]
        [StringValue("GL")]
        ClaveUnidad_GL,

        /// <summary>
        /// dry gallon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GLD")]
        [StringValue("GLD")]
        ClaveUnidad_GLD,

        /// <summary>
        /// gallon (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GLI")]
        [StringValue("GLI")]
        ClaveUnidad_GLI,

        /// <summary>
        /// gallon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GLL")]
        [StringValue("GLL")]
        ClaveUnidad_GLL,

        /// <summary>
        /// gram per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GM")]
        [StringValue("GM")]
        ClaveUnidad_GM,

        /// <summary>
        /// milligram per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GO")]
        [StringValue("GO")]
        ClaveUnidad_GO,

        /// <summary>
        /// milligram per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GP")]
        [StringValue("GP")]
        ClaveUnidad_GP,

        /// <summary>
        /// microgram per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GQ")]
        [StringValue("GQ")]
        ClaveUnidad_GQ,

        /// <summary>
        /// gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GRM")]
        [StringValue("GRM")]
        ClaveUnidad_GRM,

        /// <summary>
        /// grain
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GRN")]
        [StringValue("GRN")]
        ClaveUnidad_GRN,

        /// <summary>
        /// gross
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GRO")]
        [StringValue("GRO")]
        ClaveUnidad_GRO,

        /// <summary>
        /// gigajoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GV")]
        [StringValue("GV")]
        ClaveUnidad_GV,

        /// <summary>
        /// gigawatt hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("GWH")]
        [StringValue("GWH")]
        ClaveUnidad_GWH,

        /// <summary>
        /// henry per kiloohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H03")]
        [StringValue("H03")]
        ClaveUnidad_H03,

        /// <summary>
        /// henry per ohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H04")]
        [StringValue("H04")]
        ClaveUnidad_H04,

        /// <summary>
        /// millihenry per kiloohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H05")]
        [StringValue("H05")]
        ClaveUnidad_H05,

        /// <summary>
        /// millihenry per ohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H06")]
        [StringValue("H06")]
        ClaveUnidad_H06,

        /// <summary>
        /// pascal second per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H07")]
        [StringValue("H07")]
        ClaveUnidad_H07,

        /// <summary>
        /// microbecquerel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H08")]
        [StringValue("H08")]
        ClaveUnidad_H08,

        /// <summary>
        /// reciprocal year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H09")]
        [StringValue("H09")]
        ClaveUnidad_H09,

        /// <summary>
        /// reciprocal hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H10")]
        [StringValue("H10")]
        ClaveUnidad_H10,

        /// <summary>
        /// reciprocal month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H11")]
        [StringValue("H11")]
        ClaveUnidad_H11,

        /// <summary>
        /// degree Celsius per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H12")]
        [StringValue("H12")]
        ClaveUnidad_H12,

        /// <summary>
        /// degree Celsius per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H13")]
        [StringValue("H13")]
        ClaveUnidad_H13,

        /// <summary>
        /// degree Celsius per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H14")]
        [StringValue("H14")]
        ClaveUnidad_H14,

        /// <summary>
        /// square centimetre per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H15")]
        [StringValue("H15")]
        ClaveUnidad_H15,

        /// <summary>
        /// square decametre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H16")]
        [StringValue("H16")]
        ClaveUnidad_H16,

        /// <summary>
        /// square hectometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H18")]
        [StringValue("H18")]
        ClaveUnidad_H18,

        /// <summary>
        /// cubic hectometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H19")]
        [StringValue("H19")]
        ClaveUnidad_H19,

        /// <summary>
        /// cubic kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H20")]
        [StringValue("H20")]
        ClaveUnidad_H20,

        /// <summary>
        /// blank
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H21")]
        [StringValue("H21")]
        ClaveUnidad_H21,

        /// <summary>
        /// volt square inch per pound-force
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H22")]
        [StringValue("H22")]
        ClaveUnidad_H22,

        /// <summary>
        /// volt per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H23")]
        [StringValue("H23")]
        ClaveUnidad_H23,

        /// <summary>
        /// volt per microsecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H24")]
        [StringValue("H24")]
        ClaveUnidad_H24,

        /// <summary>
        /// percent per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H25")]
        [StringValue("H25")]
        ClaveUnidad_H25,

        /// <summary>
        /// ohm per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H26")]
        [StringValue("H26")]
        ClaveUnidad_H26,

        /// <summary>
        /// degree per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H27")]
        [StringValue("H27")]
        ClaveUnidad_H27,

        /// <summary>
        /// microfarad per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H28")]
        [StringValue("H28")]
        ClaveUnidad_H28,

        /// <summary>
        /// microgram per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H29")]
        [StringValue("H29")]
        ClaveUnidad_H29,

        /// <summary>
        /// square micrometre (square micron)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H30")]
        [StringValue("H30")]
        ClaveUnidad_H30,

        /// <summary>
        /// ampere per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H31")]
        [StringValue("H31")]
        ClaveUnidad_H31,

        /// <summary>
        /// ampere squared second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H32")]
        [StringValue("H32")]
        ClaveUnidad_H32,

        /// <summary>
        /// farad per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H33")]
        [StringValue("H33")]
        ClaveUnidad_H33,

        /// <summary>
        /// hertz metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H34")]
        [StringValue("H34")]
        ClaveUnidad_H34,

        /// <summary>
        /// kelvin metre per watt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H35")]
        [StringValue("H35")]
        ClaveUnidad_H35,

        /// <summary>
        /// megaohm per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H36")]
        [StringValue("H36")]
        ClaveUnidad_H36,

        /// <summary>
        /// megaohm per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H37")]
        [StringValue("H37")]
        ClaveUnidad_H37,

        /// <summary>
        /// megaampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H38")]
        [StringValue("H38")]
        ClaveUnidad_H38,

        /// <summary>
        /// megahertz kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H39")]
        [StringValue("H39")]
        ClaveUnidad_H39,

        /// <summary>
        /// newton per ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H40")]
        [StringValue("H40")]
        ClaveUnidad_H40,

        /// <summary>
        /// newton metre watt to the power minus 0,5
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H41")]
        [StringValue("H41")]
        ClaveUnidad_H41,

        /// <summary>
        /// pascal per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H42")]
        [StringValue("H42")]
        ClaveUnidad_H42,

        /// <summary>
        /// siemens per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H43")]
        [StringValue("H43")]
        ClaveUnidad_H43,

        /// <summary>
        /// teraohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H44")]
        [StringValue("H44")]
        ClaveUnidad_H44,

        /// <summary>
        /// volt second per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H45")]
        [StringValue("H45")]
        ClaveUnidad_H45,

        /// <summary>
        /// volt per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H46")]
        [StringValue("H46")]
        ClaveUnidad_H46,

        /// <summary>
        /// watt per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H47")]
        [StringValue("H47")]
        ClaveUnidad_H47,

        /// <summary>
        /// attofarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H48")]
        [StringValue("H48")]
        ClaveUnidad_H48,

        /// <summary>
        /// centimetre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H49")]
        [StringValue("H49")]
        ClaveUnidad_H49,

        /// <summary>
        /// reciprocal cubic centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H50")]
        [StringValue("H50")]
        ClaveUnidad_H50,

        /// <summary>
        /// decibel per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H51")]
        [StringValue("H51")]
        ClaveUnidad_H51,

        /// <summary>
        /// decibel per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H52")]
        [StringValue("H52")]
        ClaveUnidad_H52,

        /// <summary>
        /// kilogram per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H53")]
        [StringValue("H53")]
        ClaveUnidad_H53,

        /// <summary>
        /// kilogram per cubic decimetre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H54")]
        [StringValue("H54")]
        ClaveUnidad_H54,

        /// <summary>
        /// kilogram per cubic decimetre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H55")]
        [StringValue("H55")]
        ClaveUnidad_H55,

        /// <summary>
        /// kilogram per square metre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H56")]
        [StringValue("H56")]
        ClaveUnidad_H56,

        /// <summary>
        /// inch per two pi radiant
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H57")]
        [StringValue("H57")]
        ClaveUnidad_H57,

        /// <summary>
        /// metre per volt second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H58")]
        [StringValue("H58")]
        ClaveUnidad_H58,

        /// <summary>
        /// square metre per newton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H59")]
        [StringValue("H59")]
        ClaveUnidad_H59,

        /// <summary>
        /// cubic metre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H60")]
        [StringValue("H60")]
        ClaveUnidad_H60,

        /// <summary>
        /// millisiemens per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H61")]
        [StringValue("H61")]
        ClaveUnidad_H61,

        /// <summary>
        /// millivolt per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H62")]
        [StringValue("H62")]
        ClaveUnidad_H62,

        /// <summary>
        /// milligram per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H63")]
        [StringValue("H63")]
        ClaveUnidad_H63,

        /// <summary>
        /// milligram per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H64")]
        [StringValue("H64")]
        ClaveUnidad_H64,

        /// <summary>
        /// millilitre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H65")]
        [StringValue("H65")]
        ClaveUnidad_H65,

        /// <summary>
        /// millimetre per year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H66")]
        [StringValue("H66")]
        ClaveUnidad_H66,

        /// <summary>
        /// millimetre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H67")]
        [StringValue("H67")]
        ClaveUnidad_H67,

        /// <summary>
        /// millimole per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H68")]
        [StringValue("H68")]
        ClaveUnidad_H68,

        /// <summary>
        /// picopascal per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H69")]
        [StringValue("H69")]
        ClaveUnidad_H69,

        /// <summary>
        /// picosecond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H70")]
        [StringValue("H70")]
        ClaveUnidad_H70,

        /// <summary>
        /// percent per month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H71")]
        [StringValue("H71")]
        ClaveUnidad_H71,

        /// <summary>
        /// percent per hectobar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H72")]
        [StringValue("H72")]
        ClaveUnidad_H72,

        /// <summary>
        /// percent per decakelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H73")]
        [StringValue("H73")]
        ClaveUnidad_H73,

        /// <summary>
        /// watt per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H74")]
        [StringValue("H74")]
        ClaveUnidad_H74,

        /// <summary>
        /// decapascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H75")]
        [StringValue("H75")]
        ClaveUnidad_H75,

        /// <summary>
        /// gram per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H76")]
        [StringValue("H76")]
        ClaveUnidad_H76,

        /// <summary>
        /// module width
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H77")]
        [StringValue("H77")]
        ClaveUnidad_H77,

        /// <summary>
        /// French gauge
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H79")]
        [StringValue("H79")]
        ClaveUnidad_H79,

        /// <summary>
        /// rack unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H80")]
        [StringValue("H80")]
        ClaveUnidad_H80,

        /// <summary>
        /// millimetre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H81")]
        [StringValue("H81")]
        ClaveUnidad_H81,

        /// <summary>
        /// big point
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H82")]
        [StringValue("H82")]
        ClaveUnidad_H82,

        /// <summary>
        /// litre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H83")]
        [StringValue("H83")]
        ClaveUnidad_H83,

        /// <summary>
        /// gram millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H84")]
        [StringValue("H84")]
        ClaveUnidad_H84,

        /// <summary>
        /// reciprocal week
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H85")]
        [StringValue("H85")]
        ClaveUnidad_H85,

        /// <summary>
        /// piece
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H87")]
        [StringValue("H87")]
        ClaveUnidad_H87,

        /// <summary>
        /// megaohm kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H88")]
        [StringValue("H88")]
        ClaveUnidad_H88,

        /// <summary>
        /// percent per ohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H89")]
        [StringValue("H89")]
        ClaveUnidad_H89,

        /// <summary>
        /// percent per degree
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H90")]
        [StringValue("H90")]
        ClaveUnidad_H90,

        /// <summary>
        /// percent per ten thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H91")]
        [StringValue("H91")]
        ClaveUnidad_H91,

        /// <summary>
        /// percent per one hundred thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H92")]
        [StringValue("H92")]
        ClaveUnidad_H92,

        /// <summary>
        /// percent per hundred
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H93")]
        [StringValue("H93")]
        ClaveUnidad_H93,

        /// <summary>
        /// percent per thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H94")]
        [StringValue("H94")]
        ClaveUnidad_H94,

        /// <summary>
        /// percent per volt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H95")]
        [StringValue("H95")]
        ClaveUnidad_H95,

        /// <summary>
        /// percent per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H96")]
        [StringValue("H96")]
        ClaveUnidad_H96,

        /// <summary>
        /// percent per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H98")]
        [StringValue("H98")]
        ClaveUnidad_H98,

        /// <summary>
        /// percent per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("H99")]
        [StringValue("H99")]
        ClaveUnidad_H99,

        /// <summary>
        /// hank
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HA")]
        [StringValue("HA")]
        ClaveUnidad_HA,

        /// <summary>
        /// hectobar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HBA")]
        [StringValue("HBA")]
        ClaveUnidad_HBA,

        /// <summary>
        /// hundred boxes
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HBX")]
        [StringValue("HBX")]
        ClaveUnidad_HBX,

        /// <summary>
        /// hundred count
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HC")]
        [StringValue("HC")]
        ClaveUnidad_HC,

        /// <summary>
        /// hundred kilogram, dry weight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HDW")]
        [StringValue("HDW")]
        ClaveUnidad_HDW,

        /// <summary>
        /// head
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HEA")]
        [StringValue("HEA")]
        ClaveUnidad_HEA,

        /// <summary>
        /// hectogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HGM")]
        [StringValue("HGM")]
        ClaveUnidad_HGM,

        /// <summary>
        /// hundred cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HH")]
        [StringValue("HH")]
        ClaveUnidad_HH,

        /// <summary>
        /// hundred international unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HIU")]
        [StringValue("HIU")]
        ClaveUnidad_HIU,

        /// <summary>
        /// hundred kilogram, net mass
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HKM")]
        [StringValue("HKM")]
        ClaveUnidad_HKM,

        /// <summary>
        /// hectolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HLT")]
        [StringValue("HLT")]
        ClaveUnidad_HLT,

        /// <summary>
        /// mile per hour (statute mile)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HM")]
        [StringValue("HM")]
        ClaveUnidad_HM,

        /// <summary>
        /// million cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HMQ")]
        [StringValue("HMQ")]
        ClaveUnidad_HMQ,

        /// <summary>
        /// hectometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HMT")]
        [StringValue("HMT")]
        ClaveUnidad_HMT,

        /// <summary>
        /// hectolitre of pure alcohol
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HPA")]
        [StringValue("HPA")]
        ClaveUnidad_HPA,

        /// <summary>
        /// hertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HTZ")]
        [StringValue("HTZ")]
        ClaveUnidad_HTZ,

        /// <summary>
        /// hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("HUR")]
        [StringValue("HUR")]
        ClaveUnidad_HUR,

        /// <summary>
        /// inch pound (pound inch)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("IA")]
        [StringValue("IA")]
        ClaveUnidad_IA,

        /// <summary>
        /// person
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("IE")]
        [StringValue("IE")]
        ClaveUnidad_IE,

        /// <summary>
        /// inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("INH")]
        [StringValue("INH")]
        ClaveUnidad_INH,

        /// <summary>
        /// square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("INK")]
        [StringValue("INK")]
        ClaveUnidad_INK,

        /// <summary>
        /// cubic inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("INQ")]
        [StringValue("INQ")]
        ClaveUnidad_INQ,

        /// <summary>
        /// international sugar degree
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ISD")]
        [StringValue("ISD")]
        ClaveUnidad_ISD,

        /// <summary>
        /// inch per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("IU")]
        [StringValue("IU")]
        ClaveUnidad_IU,

        /// <summary>
        /// inch per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("IV")]
        [StringValue("IV")]
        ClaveUnidad_IV,

        /// <summary>
        /// percent per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J10")]
        [StringValue("J10")]
        ClaveUnidad_J10,

        /// <summary>
        /// per mille per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J12")]
        [StringValue("J12")]
        ClaveUnidad_J12,

        /// <summary>
        /// degree API
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J13")]
        [StringValue("J13")]
        ClaveUnidad_J13,

        /// <summary>
        /// degree Baume (origin scale)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J14")]
        [StringValue("J14")]
        ClaveUnidad_J14,

        /// <summary>
        /// degree Baume (US heavy)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J15")]
        [StringValue("J15")]
        ClaveUnidad_J15,

        /// <summary>
        /// degree Baume (US light)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J16")]
        [StringValue("J16")]
        ClaveUnidad_J16,

        /// <summary>
        /// degree Balling
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J17")]
        [StringValue("J17")]
        ClaveUnidad_J17,

        /// <summary>
        /// degree Brix
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J18")]
        [StringValue("J18")]
        ClaveUnidad_J18,

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (thermochemical)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J19")]
        [StringValue("J19")]
        ClaveUnidad_J19,

        /// <summary>
        /// joule per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J2")]
        [StringValue("J2")]
        ClaveUnidad_J2,

        /// <summary>
        /// degree Fahrenheit per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J20")]
        [StringValue("J20")]
        ClaveUnidad_J20,

        /// <summary>
        /// degree Fahrenheit per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J21")]
        [StringValue("J21")]
        ClaveUnidad_J21,

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J22")]
        [StringValue("J22")]
        ClaveUnidad_J22,

        /// <summary>
        /// degree Fahrenheit per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J23")]
        [StringValue("J23")]
        ClaveUnidad_J23,

        /// <summary>
        /// degree Fahrenheit per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J24")]
        [StringValue("J24")]
        ClaveUnidad_J24,

        /// <summary>
        /// degree Fahrenheit per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J25")]
        [StringValue("J25")]
        ClaveUnidad_J25,

        /// <summary>
        /// reciprocal degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J26")]
        [StringValue("J26")]
        ClaveUnidad_J26,

        /// <summary>
        /// degree Oechsle
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J27")]
        [StringValue("J27")]
        ClaveUnidad_J27,

        /// <summary>
        /// degree Rankine per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J28")]
        [StringValue("J28")]
        ClaveUnidad_J28,

        /// <summary>
        /// degree Rankine per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J29")]
        [StringValue("J29")]
        ClaveUnidad_J29,

        /// <summary>
        /// degree Rankine per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J30")]
        [StringValue("J30")]
        ClaveUnidad_J30,

        /// <summary>
        /// degree Twaddell
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J31")]
        [StringValue("J31")]
        ClaveUnidad_J31,

        /// <summary>
        /// micropoise
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J32")]
        [StringValue("J32")]
        ClaveUnidad_J32,

        /// <summary>
        /// microgram per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J33")]
        [StringValue("J33")]
        ClaveUnidad_J33,

        /// <summary>
        /// microgram per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J34")]
        [StringValue("J34")]
        ClaveUnidad_J34,

        /// <summary>
        /// microgram per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J35")]
        [StringValue("J35")]
        ClaveUnidad_J35,

        /// <summary>
        /// microlitre per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J36")]
        [StringValue("J36")]
        ClaveUnidad_J36,

        /// <summary>
        /// baud
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J38")]
        [StringValue("J38")]
        ClaveUnidad_J38,

        /// <summary>
        /// British thermal unit (mean)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J39")]
        [StringValue("J39")]
        ClaveUnidad_J39,

        /// <summary>
        /// British thermal unit (international table) foot per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J40")]
        [StringValue("J40")]
        ClaveUnidad_J40,

        /// <summary>
        /// British thermal unit (international table) inch per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J41")]
        [StringValue("J41")]
        ClaveUnidad_J41,

        /// <summary>
        /// British thermal unit (international table) inch per second square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J42")]
        [StringValue("J42")]
        ClaveUnidad_J42,

        /// <summary>
        /// British thermal unit (international table) per pound degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J43")]
        [StringValue("J43")]
        ClaveUnidad_J43,

        /// <summary>
        /// British thermal unit (international table) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J44")]
        [StringValue("J44")]
        ClaveUnidad_J44,

        /// <summary>
        /// British thermal unit (international table) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J45")]
        [StringValue("J45")]
        ClaveUnidad_J45,

        /// <summary>
        /// British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J46")]
        [StringValue("J46")]
        ClaveUnidad_J46,

        /// <summary>
        /// British thermal unit (thermochemical) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J47")]
        [StringValue("J47")]
        ClaveUnidad_J47,

        /// <summary>
        /// British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J48")]
        [StringValue("J48")]
        ClaveUnidad_J48,

        /// <summary>
        /// British thermal unit (thermochemical) inch per second square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J49")]
        [StringValue("J49")]
        ClaveUnidad_J49,

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J50")]
        [StringValue("J50")]
        ClaveUnidad_J50,

        /// <summary>
        /// British thermal unit (thermochemical) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J51")]
        [StringValue("J51")]
        ClaveUnidad_J51,

        /// <summary>
        /// British thermal unit (thermochemical) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J52")]
        [StringValue("J52")]
        ClaveUnidad_J52,

        /// <summary>
        /// coulomb square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J53")]
        [StringValue("J53")]
        ClaveUnidad_J53,

        /// <summary>
        /// megabaud
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J54")]
        [StringValue("J54")]
        ClaveUnidad_J54,

        /// <summary>
        /// watt second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J55")]
        [StringValue("J55")]
        ClaveUnidad_J55,

        /// <summary>
        /// bar per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J56")]
        [StringValue("J56")]
        ClaveUnidad_J56,

        /// <summary>
        /// barrel (UK petroleum)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J57")]
        [StringValue("J57")]
        ClaveUnidad_J57,

        /// <summary>
        /// barrel (UK petroleum) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J58")]
        [StringValue("J58")]
        ClaveUnidad_J58,

        /// <summary>
        /// barrel (UK petroleum) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J59")]
        [StringValue("J59")]
        ClaveUnidad_J59,

        /// <summary>
        /// barrel (UK petroleum) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J60")]
        [StringValue("J60")]
        ClaveUnidad_J60,

        /// <summary>
        /// barrel (UK petroleum) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J61")]
        [StringValue("J61")]
        ClaveUnidad_J61,

        /// <summary>
        /// barrel (US petroleum) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J62")]
        [StringValue("J62")]
        ClaveUnidad_J62,

        /// <summary>
        /// barrel (US petroleum) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J63")]
        [StringValue("J63")]
        ClaveUnidad_J63,

        /// <summary>
        /// bushel (UK) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J64")]
        [StringValue("J64")]
        ClaveUnidad_J64,

        /// <summary>
        /// bushel (UK) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J65")]
        [StringValue("J65")]
        ClaveUnidad_J65,

        /// <summary>
        /// bushel (UK) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J66")]
        [StringValue("J66")]
        ClaveUnidad_J66,

        /// <summary>
        /// bushel (UK) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J67")]
        [StringValue("J67")]
        ClaveUnidad_J67,

        /// <summary>
        /// bushel (US dry) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J68")]
        [StringValue("J68")]
        ClaveUnidad_J68,

        /// <summary>
        /// bushel (US dry) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J69")]
        [StringValue("J69")]
        ClaveUnidad_J69,

        /// <summary>
        /// bushel (US dry) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J70")]
        [StringValue("J70")]
        ClaveUnidad_J70,

        /// <summary>
        /// bushel (US dry) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J71")]
        [StringValue("J71")]
        ClaveUnidad_J71,

        /// <summary>
        /// centinewton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J72")]
        [StringValue("J72")]
        ClaveUnidad_J72,

        /// <summary>
        /// centipoise per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J73")]
        [StringValue("J73")]
        ClaveUnidad_J73,

        /// <summary>
        /// centipoise per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J74")]
        [StringValue("J74")]
        ClaveUnidad_J74,

        /// <summary>
        /// calorie (mean)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J75")]
        [StringValue("J75")]
        ClaveUnidad_J75,

        /// <summary>
        /// calorie (international table) per gram degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J76")]
        [StringValue("J76")]
        ClaveUnidad_J76,

        /// <summary>
        /// calorie (thermochemical) per centimetre second degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J78")]
        [StringValue("J78")]
        ClaveUnidad_J78,

        /// <summary>
        /// calorie (thermochemical) per gram degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J79")]
        [StringValue("J79")]
        ClaveUnidad_J79,

        /// <summary>
        /// calorie (thermochemical) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J81")]
        [StringValue("J81")]
        ClaveUnidad_J81,

        /// <summary>
        /// calorie (thermochemical) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J82")]
        [StringValue("J82")]
        ClaveUnidad_J82,

        /// <summary>
        /// clo
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J83")]
        [StringValue("J83")]
        ClaveUnidad_J83,

        /// <summary>
        /// centimetre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J84")]
        [StringValue("J84")]
        ClaveUnidad_J84,

        /// <summary>
        /// centimetre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J85")]
        [StringValue("J85")]
        ClaveUnidad_J85,

        /// <summary>
        /// cubic centimetre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J87")]
        [StringValue("J87")]
        ClaveUnidad_J87,

        /// <summary>
        /// cubic decimetre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J90")]
        [StringValue("J90")]
        ClaveUnidad_J90,

        /// <summary>
        /// cubic decimetre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J91")]
        [StringValue("J91")]
        ClaveUnidad_J91,

        /// <summary>
        /// cubic decimetre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J92")]
        [StringValue("J92")]
        ClaveUnidad_J92,

        /// <summary>
        /// cubic decimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J93")]
        [StringValue("J93")]
        ClaveUnidad_J93,

        /// <summary>
        /// ounce (UK fluid) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J95")]
        [StringValue("J95")]
        ClaveUnidad_J95,

        /// <summary>
        /// ounce (UK fluid) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J96")]
        [StringValue("J96")]
        ClaveUnidad_J96,

        /// <summary>
        /// ounce (UK fluid) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J97")]
        [StringValue("J97")]
        ClaveUnidad_J97,

        /// <summary>
        /// ounce (UK fluid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J98")]
        [StringValue("J98")]
        ClaveUnidad_J98,

        /// <summary>
        /// ounce (US fluid) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("J99")]
        [StringValue("J99")]
        ClaveUnidad_J99,

        /// <summary>
        /// joule per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JE")]
        [StringValue("JE")]
        ClaveUnidad_JE,

        /// <summary>
        /// megajoule per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JK")]
        [StringValue("JK")]
        ClaveUnidad_JK,

        /// <summary>
        /// megajoule per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JM")]
        [StringValue("JM")]
        ClaveUnidad_JM,

        /// <summary>
        /// pipeline joint
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JNT")]
        [StringValue("JNT")]
        ClaveUnidad_JNT,

        /// <summary>
        /// joule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JOU")]
        [StringValue("JOU")]
        ClaveUnidad_JOU,

        /// <summary>
        /// hundred metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JPS")]
        [StringValue("JPS")]
        ClaveUnidad_JPS,

        /// <summary>
        /// number of jewels
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("JWL")]
        [StringValue("JWL")]
        ClaveUnidad_JWL,

        /// <summary>
        /// kilowatt demand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K1")]
        [StringValue("K1")]
        ClaveUnidad_K1,

        /// <summary>
        /// ounce (US fluid) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K10")]
        [StringValue("K10")]
        ClaveUnidad_K10,

        /// <summary>
        /// ounce (US fluid) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K11")]
        [StringValue("K11")]
        ClaveUnidad_K11,

        /// <summary>
        /// ounce (US fluid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K12")]
        [StringValue("K12")]
        ClaveUnidad_K12,

        /// <summary>
        /// foot per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K13")]
        [StringValue("K13")]
        ClaveUnidad_K13,

        /// <summary>
        /// foot per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K14")]
        [StringValue("K14")]
        ClaveUnidad_K14,

        /// <summary>
        /// foot pound-force per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K15")]
        [StringValue("K15")]
        ClaveUnidad_K15,

        /// <summary>
        /// foot pound-force per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K16")]
        [StringValue("K16")]
        ClaveUnidad_K16,

        /// <summary>
        /// foot per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K17")]
        [StringValue("K17")]
        ClaveUnidad_K17,

        /// <summary>
        /// foot per second degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K18")]
        [StringValue("K18")]
        ClaveUnidad_K18,

        /// <summary>
        /// foot per second psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K19")]
        [StringValue("K19")]
        ClaveUnidad_K19,

        /// <summary>
        /// kilovolt ampere reactive demand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K2")]
        [StringValue("K2")]
        ClaveUnidad_K2,

        /// <summary>
        /// reciprocal cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K20")]
        [StringValue("K20")]
        ClaveUnidad_K20,

        /// <summary>
        /// cubic foot per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K21")]
        [StringValue("K21")]
        ClaveUnidad_K21,

        /// <summary>
        /// cubic foot per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K22")]
        [StringValue("K22")]
        ClaveUnidad_K22,

        /// <summary>
        /// cubic foot per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K23")]
        [StringValue("K23")]
        ClaveUnidad_K23,

        /// <summary>
        /// gallon (UK) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K26")]
        [StringValue("K26")]
        ClaveUnidad_K26,

        /// <summary>
        /// gallon (UK) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K27")]
        [StringValue("K27")]
        ClaveUnidad_K27,

        /// <summary>
        /// gallon (UK) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K28")]
        [StringValue("K28")]
        ClaveUnidad_K28,

        /// <summary>
        /// kilovolt ampere reactive hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K3")]
        [StringValue("K3")]
        ClaveUnidad_K3,

        /// <summary>
        /// gallon (US liquid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K30")]
        [StringValue("K30")]
        ClaveUnidad_K30,

        /// <summary>
        /// gram-force per square centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K31")]
        [StringValue("K31")]
        ClaveUnidad_K31,

        /// <summary>
        /// gill (UK) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K32")]
        [StringValue("K32")]
        ClaveUnidad_K32,

        /// <summary>
        /// gill (UK) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K33")]
        [StringValue("K33")]
        ClaveUnidad_K33,

        /// <summary>
        /// gill (UK) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K34")]
        [StringValue("K34")]
        ClaveUnidad_K34,

        /// <summary>
        /// gill (UK) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K35")]
        [StringValue("K35")]
        ClaveUnidad_K35,

        /// <summary>
        /// gill (US) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K36")]
        [StringValue("K36")]
        ClaveUnidad_K36,

        /// <summary>
        /// gill (US) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K37")]
        [StringValue("K37")]
        ClaveUnidad_K37,

        /// <summary>
        /// gill (US) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K38")]
        [StringValue("K38")]
        ClaveUnidad_K38,

        /// <summary>
        /// gill (US) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K39")]
        [StringValue("K39")]
        ClaveUnidad_K39,

        /// <summary>
        /// standard acceleration of free fall
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K40")]
        [StringValue("K40")]
        ClaveUnidad_K40,

        /// <summary>
        /// grain per gallon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K41")]
        [StringValue("K41")]
        ClaveUnidad_K41,

        /// <summary>
        /// horsepower (boiler)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K42")]
        [StringValue("K42")]
        ClaveUnidad_K42,

        /// <summary>
        /// horsepower (electric)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K43")]
        [StringValue("K43")]
        ClaveUnidad_K43,

        /// <summary>
        /// inch per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K45")]
        [StringValue("K45")]
        ClaveUnidad_K45,

        /// <summary>
        /// inch per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K46")]
        [StringValue("K46")]
        ClaveUnidad_K46,

        /// <summary>
        /// inch per second degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K47")]
        [StringValue("K47")]
        ClaveUnidad_K47,

        /// <summary>
        /// inch per second psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K48")]
        [StringValue("K48")]
        ClaveUnidad_K48,

        /// <summary>
        /// reciprocal cubic inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K49")]
        [StringValue("K49")]
        ClaveUnidad_K49,

        /// <summary>
        /// kilobaud
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K50")]
        [StringValue("K50")]
        ClaveUnidad_K50,

        /// <summary>
        /// kilocalorie (mean)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K51")]
        [StringValue("K51")]
        ClaveUnidad_K51,

        /// <summary>
        /// kilocalorie (international table) per hour metre degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K52")]
        [StringValue("K52")]
        ClaveUnidad_K52,

        /// <summary>
        /// kilocalorie (thermochemical)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K53")]
        [StringValue("K53")]
        ClaveUnidad_K53,

        /// <summary>
        /// kilocalorie (thermochemical) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K54")]
        [StringValue("K54")]
        ClaveUnidad_K54,

        /// <summary>
        /// kilocalorie (thermochemical) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K55")]
        [StringValue("K55")]
        ClaveUnidad_K55,

        /// <summary>
        /// kilomole per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K58")]
        [StringValue("K58")]
        ClaveUnidad_K58,

        /// <summary>
        /// kilomole per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K59")]
        [StringValue("K59")]
        ClaveUnidad_K59,

        /// <summary>
        /// kilolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K6")]
        [StringValue("K6")]
        ClaveUnidad_K6,

        /// <summary>
        /// kilomole per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K60")]
        [StringValue("K60")]
        ClaveUnidad_K60,

        /// <summary>
        /// kilomole per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K61")]
        [StringValue("K61")]
        ClaveUnidad_K61,

        /// <summary>
        /// litre per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K62")]
        [StringValue("K62")]
        ClaveUnidad_K62,

        /// <summary>
        /// reciprocal litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K63")]
        [StringValue("K63")]
        ClaveUnidad_K63,

        /// <summary>
        /// pound (avoirdupois) per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K64")]
        [StringValue("K64")]
        ClaveUnidad_K64,

        /// <summary>
        /// pound (avoirdupois) square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K65")]
        [StringValue("K65")]
        ClaveUnidad_K65,

        /// <summary>
        /// pound (avoirdupois) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K66")]
        [StringValue("K66")]
        ClaveUnidad_K66,

        /// <summary>
        /// pound per foot hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K67")]
        [StringValue("K67")]
        ClaveUnidad_K67,

        /// <summary>
        /// pound per foot second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K68")]
        [StringValue("K68")]
        ClaveUnidad_K68,

        /// <summary>
        /// pound (avoirdupois) per cubic foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K69")]
        [StringValue("K69")]
        ClaveUnidad_K69,

        /// <summary>
        /// pound (avoirdupois) per cubic foot psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K70")]
        [StringValue("K70")]
        ClaveUnidad_K70,

        /// <summary>
        /// pound (avoirdupois) per gallon (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K71")]
        [StringValue("K71")]
        ClaveUnidad_K71,

        /// <summary>
        /// pound (avoirdupois) per hour degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K73")]
        [StringValue("K73")]
        ClaveUnidad_K73,

        /// <summary>
        /// pound (avoirdupois) per hour psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K74")]
        [StringValue("K74")]
        ClaveUnidad_K74,

        /// <summary>
        /// pound (avoirdupois) per cubic inch degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K75")]
        [StringValue("K75")]
        ClaveUnidad_K75,

        /// <summary>
        /// pound (avoirdupois) per cubic inch psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K76")]
        [StringValue("K76")]
        ClaveUnidad_K76,

        /// <summary>
        /// pound (avoirdupois) per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K77")]
        [StringValue("K77")]
        ClaveUnidad_K77,

        /// <summary>
        /// pound (avoirdupois) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K78")]
        [StringValue("K78")]
        ClaveUnidad_K78,

        /// <summary>
        /// pound (avoirdupois) per minute degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K79")]
        [StringValue("K79")]
        ClaveUnidad_K79,

        /// <summary>
        /// pound (avoirdupois) per minute psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K80")]
        [StringValue("K80")]
        ClaveUnidad_K80,

        /// <summary>
        /// pound (avoirdupois) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K81")]
        [StringValue("K81")]
        ClaveUnidad_K81,

        /// <summary>
        /// pound (avoirdupois) per second degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K82")]
        [StringValue("K82")]
        ClaveUnidad_K82,

        /// <summary>
        /// pound (avoirdupois) per second psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K83")]
        [StringValue("K83")]
        ClaveUnidad_K83,

        /// <summary>
        /// pound per cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K84")]
        [StringValue("K84")]
        ClaveUnidad_K84,

        /// <summary>
        /// pound-force per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K85")]
        [StringValue("K85")]
        ClaveUnidad_K85,

        /// <summary>
        /// pound-force per square inch degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K86")]
        [StringValue("K86")]
        ClaveUnidad_K86,

        /// <summary>
        /// psi cubic inch per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K87")]
        [StringValue("K87")]
        ClaveUnidad_K87,

        /// <summary>
        /// psi litre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K88")]
        [StringValue("K88")]
        ClaveUnidad_K88,

        /// <summary>
        /// psi cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K89")]
        [StringValue("K89")]
        ClaveUnidad_K89,

        /// <summary>
        /// psi cubic yard per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K90")]
        [StringValue("K90")]
        ClaveUnidad_K90,

        /// <summary>
        /// pound-force second per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K91")]
        [StringValue("K91")]
        ClaveUnidad_K91,

        /// <summary>
        /// pound-force second per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K92")]
        [StringValue("K92")]
        ClaveUnidad_K92,

        /// <summary>
        /// reciprocal psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K93")]
        [StringValue("K93")]
        ClaveUnidad_K93,

        /// <summary>
        /// quart (UK liquid) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K94")]
        [StringValue("K94")]
        ClaveUnidad_K94,

        /// <summary>
        /// quart (UK liquid) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K95")]
        [StringValue("K95")]
        ClaveUnidad_K95,

        /// <summary>
        /// quart (UK liquid) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K96")]
        [StringValue("K96")]
        ClaveUnidad_K96,

        /// <summary>
        /// quart (UK liquid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K97")]
        [StringValue("K97")]
        ClaveUnidad_K97,

        /// <summary>
        /// quart (US liquid) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K98")]
        [StringValue("K98")]
        ClaveUnidad_K98,

        /// <summary>
        /// quart (US liquid) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("K99")]
        [StringValue("K99")]
        ClaveUnidad_K99,

        /// <summary>
        /// cake
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KA")]
        [StringValue("KA")]
        ClaveUnidad_KA,

        /// <summary>
        /// katal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KAT")]
        [StringValue("KAT")]
        ClaveUnidad_KAT,

        /// <summary>
        /// kilocharacter
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KB")]
        [StringValue("KB")]
        ClaveUnidad_KB,

        /// <summary>
        /// kilobar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KBA")]
        [StringValue("KBA")]
        ClaveUnidad_KBA,

        /// <summary>
        /// kilogram of choline chloride
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KCC")]
        [StringValue("KCC")]
        ClaveUnidad_KCC,

        /// <summary>
        /// kilogram drained net weight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KDW")]
        [StringValue("KDW")]
        ClaveUnidad_KDW,

        /// <summary>
        /// kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KEL")]
        [StringValue("KEL")]
        ClaveUnidad_KEL,

        /// <summary>
        /// kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KGM")]
        [StringValue("KGM")]
        ClaveUnidad_KGM,

        /// <summary>
        /// kilogram per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KGS")]
        [StringValue("KGS")]
        ClaveUnidad_KGS,

        /// <summary>
        /// kilogram of hydrogen peroxide
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KHY")]
        [StringValue("KHY")]
        ClaveUnidad_KHY,

        /// <summary>
        /// kilohertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KHZ")]
        [StringValue("KHZ")]
        ClaveUnidad_KHZ,

        /// <summary>
        /// kilogram per millimetre width
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KI")]
        [StringValue("KI")]
        ClaveUnidad_KI,

        /// <summary>
        /// kilogram, including container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KIC")]
        [StringValue("KIC")]
        ClaveUnidad_KIC,

        /// <summary>
        /// kilogram, including inner packaging
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KIP")]
        [StringValue("KIP")]
        ClaveUnidad_KIP,

        /// <summary>
        /// kilosegment
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KJ")]
        [StringValue("KJ")]
        ClaveUnidad_KJ,

        /// <summary>
        /// kilojoule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KJO")]
        [StringValue("KJO")]
        ClaveUnidad_KJO,

        /// <summary>
        /// kilogram per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KL")]
        [StringValue("KL")]
        ClaveUnidad_KL,

        /// <summary>
        /// lactic dry material percentage
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KLK")]
        [StringValue("KLK")]
        ClaveUnidad_KLK,

        /// <summary>
        /// kilolux
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KLX")]
        [StringValue("KLX")]
        ClaveUnidad_KLX,

        /// <summary>
        /// kilogram of methylamine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KMA")]
        [StringValue("KMA")]
        ClaveUnidad_KMA,

        /// <summary>
        /// kilometre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KMH")]
        [StringValue("KMH")]
        ClaveUnidad_KMH,

        /// <summary>
        /// square kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KMK")]
        [StringValue("KMK")]
        ClaveUnidad_KMK,

        /// <summary>
        /// kilogram per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KMQ")]
        [StringValue("KMQ")]
        ClaveUnidad_KMQ,

        /// <summary>
        /// kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KMT")]
        [StringValue("KMT")]
        ClaveUnidad_KMT,

        /// <summary>
        /// kilogram of nitrogen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KNI")]
        [StringValue("KNI")]
        ClaveUnidad_KNI,

        /// <summary>
        /// kilonewton per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KNM")]
        [StringValue("KNM")]
        ClaveUnidad_KNM,

        /// <summary>
        /// kilogram named substance
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KNS")]
        [StringValue("KNS")]
        ClaveUnidad_KNS,

        /// <summary>
        /// knot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KNT")]
        [StringValue("KNT")]
        ClaveUnidad_KNT,

        /// <summary>
        /// milliequivalence caustic potash per gram of product
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KO")]
        [StringValue("KO")]
        ClaveUnidad_KO,

        /// <summary>
        /// kilopascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KPA")]
        [StringValue("KPA")]
        ClaveUnidad_KPA,

        /// <summary>
        /// kilogram of potassium hydroxide (caustic potash)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KPH")]
        [StringValue("KPH")]
        ClaveUnidad_KPH,

        /// <summary>
        /// kilogram of potassium oxide
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KPO")]
        [StringValue("KPO")]
        ClaveUnidad_KPO,

        /// <summary>
        /// kilogram of phosphorus pentoxide (phosphoric anhydride)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KPP")]
        [StringValue("KPP")]
        ClaveUnidad_KPP,

        /// <summary>
        /// kiloroentgen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KR")]
        [StringValue("KR")]
        ClaveUnidad_KR,

        /// <summary>
        /// kilogram of substance 90 % dry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KSD")]
        [StringValue("KSD")]
        ClaveUnidad_KSD,

        /// <summary>
        /// kilogram of sodium hydroxide (caustic soda)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KSH")]
        [StringValue("KSH")]
        ClaveUnidad_KSH,

        /// <summary>
        /// kit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KT")]
        [StringValue("KT")]
        ClaveUnidad_KT,

        /// <summary>
        /// kilotonne
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KTN")]
        [StringValue("KTN")]
        ClaveUnidad_KTN,

        /// <summary>
        /// kilogram of uranium
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KUR")]
        [StringValue("KUR")]
        ClaveUnidad_KUR,

        /// <summary>
        /// kilovolt - ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KVA")]
        [StringValue("KVA")]
        ClaveUnidad_KVA,

        /// <summary>
        /// kilovar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KVR")]
        [StringValue("KVR")]
        ClaveUnidad_KVR,

        /// <summary>
        /// kilovolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KVT")]
        [StringValue("KVT")]
        ClaveUnidad_KVT,

        /// <summary>
        /// kilogram per millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KW")]
        [StringValue("KW")]
        ClaveUnidad_KW,

        /// <summary>
        /// kilowatt hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KWH")]
        [StringValue("KWH")]
        ClaveUnidad_KWH,

        /// <summary>
        /// Kilowatt hour per normalized cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KWN")]
        [StringValue("KWN")]
        ClaveUnidad_KWN,

        /// <summary>
        /// kilogram of tungsten trioxide
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KWO")]
        [StringValue("KWO")]
        ClaveUnidad_KWO,

        /// <summary>
        /// Kilowatt hour per standard cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KWS")]
        [StringValue("KWS")]
        ClaveUnidad_KWS,

        /// <summary>
        /// kilowatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KWT")]
        [StringValue("KWT")]
        ClaveUnidad_KWT,

        /// <summary>
        /// millilitre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("KX")]
        [StringValue("KX")]
        ClaveUnidad_KX,

        /// <summary>
        /// quart (US liquid) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L10")]
        [StringValue("L10")]
        ClaveUnidad_L10,

        /// <summary>
        /// quart (US liquid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L11")]
        [StringValue("L11")]
        ClaveUnidad_L11,

        /// <summary>
        /// metre per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L12")]
        [StringValue("L12")]
        ClaveUnidad_L12,

        /// <summary>
        /// metre per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L13")]
        [StringValue("L13")]
        ClaveUnidad_L13,

        /// <summary>
        /// square metre hour degree Celsius per kilocalorie (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L14")]
        [StringValue("L14")]
        ClaveUnidad_L14,

        /// <summary>
        /// millipascal second per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L15")]
        [StringValue("L15")]
        ClaveUnidad_L15,

        /// <summary>
        /// millipascal second per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L16")]
        [StringValue("L16")]
        ClaveUnidad_L16,

        /// <summary>
        /// milligram per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L17")]
        [StringValue("L17")]
        ClaveUnidad_L17,

        /// <summary>
        /// milligram per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L18")]
        [StringValue("L18")]
        ClaveUnidad_L18,

        /// <summary>
        /// millilitre per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L19")]
        [StringValue("L19")]
        ClaveUnidad_L19,

        /// <summary>
        /// litre per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L2")]
        [StringValue("L2")]
        ClaveUnidad_L2,

        /// <summary>
        /// reciprocal cubic millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L20")]
        [StringValue("L20")]
        ClaveUnidad_L20,

        /// <summary>
        /// cubic millimetre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L21")]
        [StringValue("L21")]
        ClaveUnidad_L21,

        /// <summary>
        /// mole per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L23")]
        [StringValue("L23")]
        ClaveUnidad_L23,

        /// <summary>
        /// mole per kilogram kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L24")]
        [StringValue("L24")]
        ClaveUnidad_L24,

        /// <summary>
        /// mole per kilogram bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L25")]
        [StringValue("L25")]
        ClaveUnidad_L25,

        /// <summary>
        /// mole per litre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L26")]
        [StringValue("L26")]
        ClaveUnidad_L26,

        /// <summary>
        /// mole per litre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L27")]
        [StringValue("L27")]
        ClaveUnidad_L27,

        /// <summary>
        /// mole per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L28")]
        [StringValue("L28")]
        ClaveUnidad_L28,

        /// <summary>
        /// mole per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L29")]
        [StringValue("L29")]
        ClaveUnidad_L29,

        /// <summary>
        /// mole per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L30")]
        [StringValue("L30")]
        ClaveUnidad_L30,

        /// <summary>
        /// milliroentgen aequivalent men
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L31")]
        [StringValue("L31")]
        ClaveUnidad_L31,

        /// <summary>
        /// nanogram per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L32")]
        [StringValue("L32")]
        ClaveUnidad_L32,

        /// <summary>
        /// ounce (avoirdupois) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L33")]
        [StringValue("L33")]
        ClaveUnidad_L33,

        /// <summary>
        /// ounce (avoirdupois) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L34")]
        [StringValue("L34")]
        ClaveUnidad_L34,

        /// <summary>
        /// ounce (avoirdupois) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L35")]
        [StringValue("L35")]
        ClaveUnidad_L35,

        /// <summary>
        /// ounce (avoirdupois) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L36")]
        [StringValue("L36")]
        ClaveUnidad_L36,

        /// <summary>
        /// ounce (avoirdupois) per gallon (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L37")]
        [StringValue("L37")]
        ClaveUnidad_L37,

        /// <summary>
        /// ounce (avoirdupois) per gallon (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L38")]
        [StringValue("L38")]
        ClaveUnidad_L38,

        /// <summary>
        /// ounce (avoirdupois) per cubic inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L39")]
        [StringValue("L39")]
        ClaveUnidad_L39,

        /// <summary>
        /// ounce (avoirdupois)-force
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L40")]
        [StringValue("L40")]
        ClaveUnidad_L40,

        /// <summary>
        /// ounce (avoirdupois)-force inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L41")]
        [StringValue("L41")]
        ClaveUnidad_L41,

        /// <summary>
        /// picosiemens per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L42")]
        [StringValue("L42")]
        ClaveUnidad_L42,

        /// <summary>
        /// peck (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L43")]
        [StringValue("L43")]
        ClaveUnidad_L43,

        /// <summary>
        /// peck (UK) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L44")]
        [StringValue("L44")]
        ClaveUnidad_L44,

        /// <summary>
        /// peck (UK) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L45")]
        [StringValue("L45")]
        ClaveUnidad_L45,

        /// <summary>
        /// peck (UK) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L46")]
        [StringValue("L46")]
        ClaveUnidad_L46,

        /// <summary>
        /// peck (UK) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L47")]
        [StringValue("L47")]
        ClaveUnidad_L47,

        /// <summary>
        /// peck (US dry) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L48")]
        [StringValue("L48")]
        ClaveUnidad_L48,

        /// <summary>
        /// peck (US dry) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L49")]
        [StringValue("L49")]
        ClaveUnidad_L49,

        /// <summary>
        /// peck (US dry) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L50")]
        [StringValue("L50")]
        ClaveUnidad_L50,

        /// <summary>
        /// peck (US dry) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L51")]
        [StringValue("L51")]
        ClaveUnidad_L51,

        /// <summary>
        /// psi per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L52")]
        [StringValue("L52")]
        ClaveUnidad_L52,

        /// <summary>
        /// pint (UK) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L53")]
        [StringValue("L53")]
        ClaveUnidad_L53,

        /// <summary>
        /// pint (UK) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L54")]
        [StringValue("L54")]
        ClaveUnidad_L54,

        /// <summary>
        /// pint (UK) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L55")]
        [StringValue("L55")]
        ClaveUnidad_L55,

        /// <summary>
        /// pint (UK) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L56")]
        [StringValue("L56")]
        ClaveUnidad_L56,

        /// <summary>
        /// pint (US liquid) per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L57")]
        [StringValue("L57")]
        ClaveUnidad_L57,

        /// <summary>
        /// pint (US liquid) per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L58")]
        [StringValue("L58")]
        ClaveUnidad_L58,

        /// <summary>
        /// pint (US liquid) per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L59")]
        [StringValue("L59")]
        ClaveUnidad_L59,

        /// <summary>
        /// pint (US liquid) per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L60")]
        [StringValue("L60")]
        ClaveUnidad_L60,

        /// <summary>
        /// slug per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L63")]
        [StringValue("L63")]
        ClaveUnidad_L63,

        /// <summary>
        /// slug per foot second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L64")]
        [StringValue("L64")]
        ClaveUnidad_L64,

        /// <summary>
        /// slug per cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L65")]
        [StringValue("L65")]
        ClaveUnidad_L65,

        /// <summary>
        /// slug per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L66")]
        [StringValue("L66")]
        ClaveUnidad_L66,

        /// <summary>
        /// slug per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L67")]
        [StringValue("L67")]
        ClaveUnidad_L67,

        /// <summary>
        /// slug per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L68")]
        [StringValue("L68")]
        ClaveUnidad_L68,

        /// <summary>
        /// tonne per kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L69")]
        [StringValue("L69")]
        ClaveUnidad_L69,

        /// <summary>
        /// tonne per bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L70")]
        [StringValue("L70")]
        ClaveUnidad_L70,

        /// <summary>
        /// tonne per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L71")]
        [StringValue("L71")]
        ClaveUnidad_L71,

        /// <summary>
        /// tonne per day kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L72")]
        [StringValue("L72")]
        ClaveUnidad_L72,

        /// <summary>
        /// tonne per day bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L73")]
        [StringValue("L73")]
        ClaveUnidad_L73,

        /// <summary>
        /// tonne per hour kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L74")]
        [StringValue("L74")]
        ClaveUnidad_L74,

        /// <summary>
        /// tonne per hour bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L75")]
        [StringValue("L75")]
        ClaveUnidad_L75,

        /// <summary>
        /// tonne per cubic metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L76")]
        [StringValue("L76")]
        ClaveUnidad_L76,

        /// <summary>
        /// tonne per cubic metre bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L77")]
        [StringValue("L77")]
        ClaveUnidad_L77,

        /// <summary>
        /// tonne per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L78")]
        [StringValue("L78")]
        ClaveUnidad_L78,

        /// <summary>
        /// tonne per minute kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L79")]
        [StringValue("L79")]
        ClaveUnidad_L79,

        /// <summary>
        /// tonne per minute bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L80")]
        [StringValue("L80")]
        ClaveUnidad_L80,

        /// <summary>
        /// tonne per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L81")]
        [StringValue("L81")]
        ClaveUnidad_L81,

        /// <summary>
        /// tonne per second kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L82")]
        [StringValue("L82")]
        ClaveUnidad_L82,

        /// <summary>
        /// tonne per second bar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L83")]
        [StringValue("L83")]
        ClaveUnidad_L83,

        /// <summary>
        /// ton (UK shipping)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L84")]
        [StringValue("L84")]
        ClaveUnidad_L84,

        /// <summary>
        /// ton long per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L85")]
        [StringValue("L85")]
        ClaveUnidad_L85,

        /// <summary>
        /// ton (US shipping)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L86")]
        [StringValue("L86")]
        ClaveUnidad_L86,

        /// <summary>
        /// ton short per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L87")]
        [StringValue("L87")]
        ClaveUnidad_L87,

        /// <summary>
        /// ton short per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L88")]
        [StringValue("L88")]
        ClaveUnidad_L88,

        /// <summary>
        /// ton short per hour degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L89")]
        [StringValue("L89")]
        ClaveUnidad_L89,

        /// <summary>
        /// ton short per hour psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L90")]
        [StringValue("L90")]
        ClaveUnidad_L90,

        /// <summary>
        /// ton short per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L91")]
        [StringValue("L91")]
        ClaveUnidad_L91,

        /// <summary>
        /// ton (UK long) per cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L92")]
        [StringValue("L92")]
        ClaveUnidad_L92,

        /// <summary>
        /// ton (US short) per cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L93")]
        [StringValue("L93")]
        ClaveUnidad_L93,

        /// <summary>
        /// ton-force (US short)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L94")]
        [StringValue("L94")]
        ClaveUnidad_L94,

        /// <summary>
        /// common year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L95")]
        [StringValue("L95")]
        ClaveUnidad_L95,

        /// <summary>
        /// sidereal year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L96")]
        [StringValue("L96")]
        ClaveUnidad_L96,

        /// <summary>
        /// yard per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L98")]
        [StringValue("L98")]
        ClaveUnidad_L98,

        /// <summary>
        /// yard per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("L99")]
        [StringValue("L99")]
        ClaveUnidad_L99,

        /// <summary>
        /// pound per cubic inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LA")]
        [StringValue("LA")]
        ClaveUnidad_LA,

        /// <summary>
        /// lactose excess percentage
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LAC")]
        [StringValue("LAC")]
        ClaveUnidad_LAC,

        /// <summary>
        /// pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LBR")]
        [StringValue("LBR")]
        ClaveUnidad_LBR,

        /// <summary>
        /// troy pound (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LBT")]
        [StringValue("LBT")]
        ClaveUnidad_LBT,

        /// <summary>
        /// litre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LD")]
        [StringValue("LD")]
        ClaveUnidad_LD,

        /// <summary>
        /// leaf
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LEF")]
        [StringValue("LEF")]
        ClaveUnidad_LEF,

        /// <summary>
        /// linear foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LF")]
        [StringValue("LF")]
        ClaveUnidad_LF,

        /// <summary>
        /// labour hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LH")]
        [StringValue("LH")]
        ClaveUnidad_LH,

        /// <summary>
        /// link
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LK")]
        [StringValue("LK")]
        ClaveUnidad_LK,

        /// <summary>
        /// linear metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LM")]
        [StringValue("LM")]
        ClaveUnidad_LM,

        /// <summary>
        /// length
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LN")]
        [StringValue("LN")]
        ClaveUnidad_LN,

        /// <summary>
        /// lot  [unit of procurement]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LO")]
        [StringValue("LO")]
        ClaveUnidad_LO,

        /// <summary>
        /// liquid pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LP")]
        [StringValue("LP")]
        ClaveUnidad_LP,

        /// <summary>
        /// litre of pure alcohol
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LPA")]
        [StringValue("LPA")]
        ClaveUnidad_LPA,

        /// <summary>
        /// layer
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LR")]
        [StringValue("LR")]
        ClaveUnidad_LR,

        /// <summary>
        /// lump sum
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LS")]
        [StringValue("LS")]
        ClaveUnidad_LS,

        /// <summary>
        /// ton (UK) or long ton (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LTN")]
        [StringValue("LTN")]
        ClaveUnidad_LTN,

        /// <summary>
        /// litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LTR")]
        [StringValue("LTR")]
        ClaveUnidad_LTR,

        /// <summary>
        /// metric ton, lubricating oil
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LUB")]
        [StringValue("LUB")]
        ClaveUnidad_LUB,

        /// <summary>
        /// lumen
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LUM")]
        [StringValue("LUM")]
        ClaveUnidad_LUM,

        /// <summary>
        /// lux
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LUX")]
        [StringValue("LUX")]
        ClaveUnidad_LUX,

        /// <summary>
        /// linear yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("LY")]
        [StringValue("LY")]
        ClaveUnidad_LY,

        /// <summary>
        /// milligram per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M1")]
        [StringValue("M1")]
        ClaveUnidad_M1,

        /// <summary>
        /// reciprocal cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M10")]
        [StringValue("M10")]
        ClaveUnidad_M10,

        /// <summary>
        /// cubic yard per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M11")]
        [StringValue("M11")]
        ClaveUnidad_M11,

        /// <summary>
        /// cubic yard per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M12")]
        [StringValue("M12")]
        ClaveUnidad_M12,

        /// <summary>
        /// cubic yard per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M13")]
        [StringValue("M13")]
        ClaveUnidad_M13,

        /// <summary>
        /// cubic yard per psi
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M14")]
        [StringValue("M14")]
        ClaveUnidad_M14,

        /// <summary>
        /// cubic yard per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M15")]
        [StringValue("M15")]
        ClaveUnidad_M15,

        /// <summary>
        /// cubic yard per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M16")]
        [StringValue("M16")]
        ClaveUnidad_M16,

        /// <summary>
        /// kilohertz metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M17")]
        [StringValue("M17")]
        ClaveUnidad_M17,

        /// <summary>
        /// gigahertz metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M18")]
        [StringValue("M18")]
        ClaveUnidad_M18,

        /// <summary>
        /// Beaufort
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M19")]
        [StringValue("M19")]
        ClaveUnidad_M19,

        /// <summary>
        /// reciprocal megakelvin or megakelvin to the power minus one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M20")]
        [StringValue("M20")]
        ClaveUnidad_M20,

        /// <summary>
        /// reciprocal kilovolt - ampere reciprocal hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M21")]
        [StringValue("M21")]
        ClaveUnidad_M21,

        /// <summary>
        /// millilitre per square centimetre minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M22")]
        [StringValue("M22")]
        ClaveUnidad_M22,

        /// <summary>
        /// newton per centimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M23")]
        [StringValue("M23")]
        ClaveUnidad_M23,

        /// <summary>
        /// ohm kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M24")]
        [StringValue("M24")]
        ClaveUnidad_M24,

        /// <summary>
        /// percent per degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M25")]
        [StringValue("M25")]
        ClaveUnidad_M25,

        /// <summary>
        /// gigaohm per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M26")]
        [StringValue("M26")]
        ClaveUnidad_M26,

        /// <summary>
        /// megahertz metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M27")]
        [StringValue("M27")]
        ClaveUnidad_M27,

        /// <summary>
        /// kilogram per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M29")]
        [StringValue("M29")]
        ClaveUnidad_M29,

        /// <summary>
        /// reciprocal volt - ampere reciprocal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M30")]
        [StringValue("M30")]
        ClaveUnidad_M30,

        /// <summary>
        /// kilogram per kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M31")]
        [StringValue("M31")]
        ClaveUnidad_M31,

        /// <summary>
        /// pascal second per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M32")]
        [StringValue("M32")]
        ClaveUnidad_M32,

        /// <summary>
        /// millimole per litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M33")]
        [StringValue("M33")]
        ClaveUnidad_M33,

        /// <summary>
        /// newton metre per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M34")]
        [StringValue("M34")]
        ClaveUnidad_M34,

        /// <summary>
        /// millivolt - ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M35")]
        [StringValue("M35")]
        ClaveUnidad_M35,

        /// <summary>
        /// 30-day month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M36")]
        [StringValue("M36")]
        ClaveUnidad_M36,

        /// <summary>
        /// actual/360
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M37")]
        [StringValue("M37")]
        ClaveUnidad_M37,

        /// <summary>
        /// kilometre per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M38")]
        [StringValue("M38")]
        ClaveUnidad_M38,

        /// <summary>
        /// centimetre per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M39")]
        [StringValue("M39")]
        ClaveUnidad_M39,

        /// <summary>
        /// monetary value
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M4")]
        [StringValue("M4")]
        ClaveUnidad_M4,

        /// <summary>
        /// yard per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M40")]
        [StringValue("M40")]
        ClaveUnidad_M40,

        /// <summary>
        /// millimetre per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M41")]
        [StringValue("M41")]
        ClaveUnidad_M41,

        /// <summary>
        /// mile (statute mile) per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M42")]
        [StringValue("M42")]
        ClaveUnidad_M42,

        /// <summary>
        /// mil
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M43")]
        [StringValue("M43")]
        ClaveUnidad_M43,

        /// <summary>
        /// revolution
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M44")]
        [StringValue("M44")]
        ClaveUnidad_M44,

        /// <summary>
        /// degree [unit of angle] per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M45")]
        [StringValue("M45")]
        ClaveUnidad_M45,

        /// <summary>
        /// revolution per minute 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M46")]
        [StringValue("M46")]
        ClaveUnidad_M46,

        /// <summary>
        /// circular mil 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M47")]
        [StringValue("M47")]
        ClaveUnidad_M47,

        /// <summary>
        /// square mile (based on U.S. survey foot) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M48")]
        [StringValue("M48")]
        ClaveUnidad_M48,

        /// <summary>
        /// chain (based on U.S. survey foot)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M49")]
        [StringValue("M49")]
        ClaveUnidad_M49,

        /// <summary>
        /// microcurie
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M5")]
        [StringValue("M5")]
        ClaveUnidad_M5,

        /// <summary>
        /// furlong
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M50")]
        [StringValue("M50")]
        ClaveUnidad_M50,

        /// <summary>
        /// foot (U.S. survey) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M51")]
        [StringValue("M51")]
        ClaveUnidad_M51,

        /// <summary>
        /// mile (based on U.S. survey foot) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M52")]
        [StringValue("M52")]
        ClaveUnidad_M52,

        /// <summary>
        /// metre per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M53")]
        [StringValue("M53")]
        ClaveUnidad_M53,

        /// <summary>
        /// metre per radiant
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M55")]
        [StringValue("M55")]
        ClaveUnidad_M55,

        /// <summary>
        /// shake
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M56")]
        [StringValue("M56")]
        ClaveUnidad_M56,

        /// <summary>
        /// mile per minute 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M57")]
        [StringValue("M57")]
        ClaveUnidad_M57,

        /// <summary>
        /// mile per second 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M58")]
        [StringValue("M58")]
        ClaveUnidad_M58,

        /// <summary>
        /// metre per second pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M59")]
        [StringValue("M59")]
        ClaveUnidad_M59,

        /// <summary>
        /// metre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M60")]
        [StringValue("M60")]
        ClaveUnidad_M60,

        /// <summary>
        /// inch per year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M61")]
        [StringValue("M61")]
        ClaveUnidad_M61,

        /// <summary>
        /// kilometre per second 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M62")]
        [StringValue("M62")]
        ClaveUnidad_M62,

        /// <summary>
        /// inch per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M63")]
        [StringValue("M63")]
        ClaveUnidad_M63,

        /// <summary>
        /// yard per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M64")]
        [StringValue("M64")]
        ClaveUnidad_M64,

        /// <summary>
        /// yard per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M65")]
        [StringValue("M65")]
        ClaveUnidad_M65,

        /// <summary>
        /// yard per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M66")]
        [StringValue("M66")]
        ClaveUnidad_M66,

        /// <summary>
        /// acre-foot (based on U.S. survey foot)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M67")]
        [StringValue("M67")]
        ClaveUnidad_M67,

        /// <summary>
        /// cord (128 ft3)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M68")]
        [StringValue("M68")]
        ClaveUnidad_M68,

        /// <summary>
        /// cubic mile (UK statute)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M69")]
        [StringValue("M69")]
        ClaveUnidad_M69,

        /// <summary>
        /// micro-inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M7")]
        [StringValue("M7")]
        ClaveUnidad_M7,

        /// <summary>
        /// ton, register 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M70")]
        [StringValue("M70")]
        ClaveUnidad_M70,

        /// <summary>
        /// cubic metre per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M71")]
        [StringValue("M71")]
        ClaveUnidad_M71,

        /// <summary>
        /// bel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M72")]
        [StringValue("M72")]
        ClaveUnidad_M72,

        /// <summary>
        /// kilogram per cubic metre pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M73")]
        [StringValue("M73")]
        ClaveUnidad_M73,

        /// <summary>
        /// kilogram per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M74")]
        [StringValue("M74")]
        ClaveUnidad_M74,

        /// <summary>
        /// kilopound-force
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M75")]
        [StringValue("M75")]
        ClaveUnidad_M75,

        /// <summary>
        /// poundal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M76")]
        [StringValue("M76")]
        ClaveUnidad_M76,

        /// <summary>
        /// kilogram metre per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M77")]
        [StringValue("M77")]
        ClaveUnidad_M77,

        /// <summary>
        /// pond
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M78")]
        [StringValue("M78")]
        ClaveUnidad_M78,

        /// <summary>
        /// square foot per hour 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M79")]
        [StringValue("M79")]
        ClaveUnidad_M79,

        /// <summary>
        /// stokes per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M80")]
        [StringValue("M80")]
        ClaveUnidad_M80,

        /// <summary>
        /// square centimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M81")]
        [StringValue("M81")]
        ClaveUnidad_M81,

        /// <summary>
        /// square metre per second pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M82")]
        [StringValue("M82")]
        ClaveUnidad_M82,

        /// <summary>
        /// denier 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M83")]
        [StringValue("M83")]
        ClaveUnidad_M83,

        /// <summary>
        /// pound per yard 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M84")]
        [StringValue("M84")]
        ClaveUnidad_M84,

        /// <summary>
        /// ton, assay
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M85")]
        [StringValue("M85")]
        ClaveUnidad_M85,

        /// <summary>
        /// pfund
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M86")]
        [StringValue("M86")]
        ClaveUnidad_M86,

        /// <summary>
        /// kilogram per second pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M87")]
        [StringValue("M87")]
        ClaveUnidad_M87,

        /// <summary>
        /// tonne per month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M88")]
        [StringValue("M88")]
        ClaveUnidad_M88,

        /// <summary>
        /// tonne per year
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M89")]
        [StringValue("M89")]
        ClaveUnidad_M89,

        /// <summary>
        /// million Btu per 1000 cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M9")]
        [StringValue("M9")]
        ClaveUnidad_M9,

        /// <summary>
        /// kilopound per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M90")]
        [StringValue("M90")]
        ClaveUnidad_M90,

        /// <summary>
        /// pound per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M91")]
        [StringValue("M91")]
        ClaveUnidad_M91,

        /// <summary>
        /// pound-force foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M92")]
        [StringValue("M92")]
        ClaveUnidad_M92,

        /// <summary>
        /// newton metre per radian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M93")]
        [StringValue("M93")]
        ClaveUnidad_M93,

        /// <summary>
        /// kilogram metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M94")]
        [StringValue("M94")]
        ClaveUnidad_M94,

        /// <summary>
        /// poundal foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M95")]
        [StringValue("M95")]
        ClaveUnidad_M95,

        /// <summary>
        /// poundal inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M96")]
        [StringValue("M96")]
        ClaveUnidad_M96,

        /// <summary>
        /// dyne metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M97")]
        [StringValue("M97")]
        ClaveUnidad_M97,

        /// <summary>
        /// kilogram centimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M98")]
        [StringValue("M98")]
        ClaveUnidad_M98,

        /// <summary>
        /// gram centimetre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("M99")]
        [StringValue("M99")]
        ClaveUnidad_M99,

        /// <summary>
        /// megavolt ampere reactive hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MAH")]
        [StringValue("MAH")]
        ClaveUnidad_MAH,

        /// <summary>
        /// megalitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MAL")]
        [StringValue("MAL")]
        ClaveUnidad_MAL,

        /// <summary>
        /// megametre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MAM")]
        [StringValue("MAM")]
        ClaveUnidad_MAM,

        /// <summary>
        /// megavar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MAR")]
        [StringValue("MAR")]
        ClaveUnidad_MAR,

        /// <summary>
        /// megawatt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MAW")]
        [StringValue("MAW")]
        ClaveUnidad_MAW,

        /// <summary>
        /// thousand standard brick equivalent
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MBE")]
        [StringValue("MBE")]
        ClaveUnidad_MBE,

        /// <summary>
        /// thousand board foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MBF")]
        [StringValue("MBF")]
        ClaveUnidad_MBF,

        /// <summary>
        /// millibar
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MBR")]
        [StringValue("MBR")]
        ClaveUnidad_MBR,

        /// <summary>
        /// microgram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MC")]
        [StringValue("MC")]
        ClaveUnidad_MC,

        /// <summary>
        /// millicurie
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MCU")]
        [StringValue("MCU")]
        ClaveUnidad_MCU,

        /// <summary>
        /// air dry metric ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MD")]
        [StringValue("MD")]
        ClaveUnidad_MD,

        /// <summary>
        /// milligram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MGM")]
        [StringValue("MGM")]
        ClaveUnidad_MGM,

        /// <summary>
        /// megahertz
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MHZ")]
        [StringValue("MHZ")]
        ClaveUnidad_MHZ,

        /// <summary>
        /// square mile (statute mile)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MIK")]
        [StringValue("MIK")]
        ClaveUnidad_MIK,

        /// <summary>
        /// thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MIL")]
        [StringValue("MIL")]
        ClaveUnidad_MIL,

        /// <summary>
        /// minute [unit of time]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MIN")]
        [StringValue("MIN")]
        ClaveUnidad_MIN,

        /// <summary>
        /// million
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MIO")]
        [StringValue("MIO")]
        ClaveUnidad_MIO,

        /// <summary>
        /// million international unit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MIU")]
        [StringValue("MIU")]
        ClaveUnidad_MIU,

        /// <summary>
        /// milliard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MLD")]
        [StringValue("MLD")]
        ClaveUnidad_MLD,

        /// <summary>
        /// millilitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MLT")]
        [StringValue("MLT")]
        ClaveUnidad_MLT,

        /// <summary>
        /// square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MMK")]
        [StringValue("MMK")]
        ClaveUnidad_MMK,

        /// <summary>
        /// cubic millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MMQ")]
        [StringValue("MMQ")]
        ClaveUnidad_MMQ,

        /// <summary>
        /// millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MMT")]
        [StringValue("MMT")]
        ClaveUnidad_MMT,

        /// <summary>
        /// kilogram, dry weight
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MND")]
        [StringValue("MND")]
        ClaveUnidad_MND,

        /// <summary>
        /// month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MON")]
        [StringValue("MON")]
        ClaveUnidad_MON,

        /// <summary>
        /// megapascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MPA")]
        [StringValue("MPA")]
        ClaveUnidad_MPA,

        /// <summary>
        /// cubic metre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MQH")]
        [StringValue("MQH")]
        ClaveUnidad_MQH,

        /// <summary>
        /// cubic metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MQS")]
        [StringValue("MQS")]
        ClaveUnidad_MQS,

        /// <summary>
        /// metre per second squared
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MSK")]
        [StringValue("MSK")]
        ClaveUnidad_MSK,

        /// <summary>
        /// square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MTK")]
        [StringValue("MTK")]
        ClaveUnidad_MTK,

        /// <summary>
        /// cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MTQ")]
        [StringValue("MTQ")]
        ClaveUnidad_MTQ,

        /// <summary>
        /// metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MTR")]
        [StringValue("MTR")]
        ClaveUnidad_MTR,

        /// <summary>
        /// metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MTS")]
        [StringValue("MTS")]
        ClaveUnidad_MTS,

        /// <summary>
        /// megavolt - ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MVA")]
        [StringValue("MVA")]
        ClaveUnidad_MVA,

        /// <summary>
        /// megawatt hour (1000 kW.h)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MWH")]
        [StringValue("MWH")]
        ClaveUnidad_MWH,

        /// <summary>
        /// pen calorie
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N1")]
        [StringValue("N1")]
        ClaveUnidad_N1,

        /// <summary>
        /// pound foot per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N10")]
        [StringValue("N10")]
        ClaveUnidad_N10,

        /// <summary>
        /// pound inch per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N11")]
        [StringValue("N11")]
        ClaveUnidad_N11,

        /// <summary>
        /// Pferdestaerke
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N12")]
        [StringValue("N12")]
        ClaveUnidad_N12,

        /// <summary>
        /// centimetre of mercury (0 ºC)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N13")]
        [StringValue("N13")]
        ClaveUnidad_N13,

        /// <summary>
        /// centimetre of water (4 ºC)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N14")]
        [StringValue("N14")]
        ClaveUnidad_N14,

        /// <summary>
        /// foot of water (39.2 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N15")]
        [StringValue("N15")]
        ClaveUnidad_N15,

        /// <summary>
        /// inch of mercury (32 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N16")]
        [StringValue("N16")]
        ClaveUnidad_N16,

        /// <summary>
        /// inch of mercury (60 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N17")]
        [StringValue("N17")]
        ClaveUnidad_N17,

        /// <summary>
        /// inch of water (39.2 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N18")]
        [StringValue("N18")]
        ClaveUnidad_N18,

        /// <summary>
        /// inch of water (60 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N19")]
        [StringValue("N19")]
        ClaveUnidad_N19,

        /// <summary>
        /// kip per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N20")]
        [StringValue("N20")]
        ClaveUnidad_N20,

        /// <summary>
        /// poundal per square foot 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N21")]
        [StringValue("N21")]
        ClaveUnidad_N21,

        /// <summary>
        /// ounce (avoirdupois) per square inch 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N22")]
        [StringValue("N22")]
        ClaveUnidad_N22,

        /// <summary>
        /// conventional metre of water
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N23")]
        [StringValue("N23")]
        ClaveUnidad_N23,

        /// <summary>
        /// gram per square millimetre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N24")]
        [StringValue("N24")]
        ClaveUnidad_N24,

        /// <summary>
        /// pound per square yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N25")]
        [StringValue("N25")]
        ClaveUnidad_N25,

        /// <summary>
        /// poundal per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N26")]
        [StringValue("N26")]
        ClaveUnidad_N26,

        /// <summary>
        /// foot to the fourth power 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N27")]
        [StringValue("N27")]
        ClaveUnidad_N27,

        /// <summary>
        /// cubic decimetre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N28")]
        [StringValue("N28")]
        ClaveUnidad_N28,

        /// <summary>
        /// cubic foot per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N29")]
        [StringValue("N29")]
        ClaveUnidad_N29,

        /// <summary>
        /// print point
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N3")]
        [StringValue("N3")]
        ClaveUnidad_N3,

        /// <summary>
        /// cubic inch per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N30")]
        [StringValue("N30")]
        ClaveUnidad_N30,

        /// <summary>
        /// kilonewton per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N31")]
        [StringValue("N31")]
        ClaveUnidad_N31,

        /// <summary>
        /// poundal per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N32")]
        [StringValue("N32")]
        ClaveUnidad_N32,

        /// <summary>
        /// pound-force per yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N33")]
        [StringValue("N33")]
        ClaveUnidad_N33,

        /// <summary>
        /// poundal second per square foot 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N34")]
        [StringValue("N34")]
        ClaveUnidad_N34,

        /// <summary>
        /// poise per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N35")]
        [StringValue("N35")]
        ClaveUnidad_N35,

        /// <summary>
        /// newton second per square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N36")]
        [StringValue("N36")]
        ClaveUnidad_N36,

        /// <summary>
        /// kilogram per metre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N37")]
        [StringValue("N37")]
        ClaveUnidad_N37,

        /// <summary>
        /// kilogram per metre minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N38")]
        [StringValue("N38")]
        ClaveUnidad_N38,

        /// <summary>
        /// kilogram per metre day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N39")]
        [StringValue("N39")]
        ClaveUnidad_N39,

        /// <summary>
        /// kilogram per metre hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N40")]
        [StringValue("N40")]
        ClaveUnidad_N40,

        /// <summary>
        /// gram per centimetre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N41")]
        [StringValue("N41")]
        ClaveUnidad_N41,

        /// <summary>
        /// poundal second per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N42")]
        [StringValue("N42")]
        ClaveUnidad_N42,

        /// <summary>
        /// pound per foot minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N43")]
        [StringValue("N43")]
        ClaveUnidad_N43,

        /// <summary>
        /// pound per foot day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N44")]
        [StringValue("N44")]
        ClaveUnidad_N44,

        /// <summary>
        /// cubic metre per second pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N45")]
        [StringValue("N45")]
        ClaveUnidad_N45,

        /// <summary>
        /// foot poundal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N46")]
        [StringValue("N46")]
        ClaveUnidad_N46,

        /// <summary>
        /// inch poundal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N47")]
        [StringValue("N47")]
        ClaveUnidad_N47,

        /// <summary>
        /// watt per square centimetre 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N48")]
        [StringValue("N48")]
        ClaveUnidad_N48,

        /// <summary>
        /// watt per square inch 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N49")]
        [StringValue("N49")]
        ClaveUnidad_N49,

        /// <summary>
        /// British thermal unit (international table) per square foot hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N50")]
        [StringValue("N50")]
        ClaveUnidad_N50,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N51")]
        [StringValue("N51")]
        ClaveUnidad_N51,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N52")]
        [StringValue("N52")]
        ClaveUnidad_N52,

        /// <summary>
        /// British thermal unit (international table) per square foot second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N53")]
        [StringValue("N53")]
        ClaveUnidad_N53,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N54")]
        [StringValue("N54")]
        ClaveUnidad_N54,

        /// <summary>
        /// British thermal unit (international table) per square inch second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N55")]
        [StringValue("N55")]
        ClaveUnidad_N55,

        /// <summary>
        /// calorie (thermochemical) per square centimetre minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N56")]
        [StringValue("N56")]
        ClaveUnidad_N56,

        /// <summary>
        /// calorie (thermochemical) per square centimetre second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N57")]
        [StringValue("N57")]
        ClaveUnidad_N57,

        /// <summary>
        /// British thermal unit (international table) per cubic foot 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N58")]
        [StringValue("N58")]
        ClaveUnidad_N58,

        /// <summary>
        /// British thermal unit (thermochemical) per cubic foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N59")]
        [StringValue("N59")]
        ClaveUnidad_N59,

        /// <summary>
        /// British thermal unit (international table) per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N60")]
        [StringValue("N60")]
        ClaveUnidad_N60,

        /// <summary>
        /// British thermal unit (thermochemical) per degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N61")]
        [StringValue("N61")]
        ClaveUnidad_N61,

        /// <summary>
        /// British thermal unit (international table) per degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N62")]
        [StringValue("N62")]
        ClaveUnidad_N62,

        /// <summary>
        /// British thermal unit (thermochemical) per degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N63")]
        [StringValue("N63")]
        ClaveUnidad_N63,

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Rankine
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N64")]
        [StringValue("N64")]
        ClaveUnidad_N64,

        /// <summary>
        /// kilocalorie (international table) per gram kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N65")]
        [StringValue("N65")]
        ClaveUnidad_N65,

        /// <summary>
        /// British thermal unit (39 ºF) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N66")]
        [StringValue("N66")]
        ClaveUnidad_N66,

        /// <summary>
        /// British thermal unit (59 ºF)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N67")]
        [StringValue("N67")]
        ClaveUnidad_N67,

        /// <summary>
        /// British thermal unit (60 ºF) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N68")]
        [StringValue("N68")]
        ClaveUnidad_N68,

        /// <summary>
        /// calorie (20 ºC) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N69")]
        [StringValue("N69")]
        ClaveUnidad_N69,

        /// <summary>
        /// quad (1015 BtuIT)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N70")]
        [StringValue("N70")]
        ClaveUnidad_N70,

        /// <summary>
        /// therm (EC)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N71")]
        [StringValue("N71")]
        ClaveUnidad_N71,

        /// <summary>
        /// therm (U.S.)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N72")]
        [StringValue("N72")]
        ClaveUnidad_N72,

        /// <summary>
        /// British thermal unit (thermochemical) per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N73")]
        [StringValue("N73")]
        ClaveUnidad_N73,

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N74")]
        [StringValue("N74")]
        ClaveUnidad_N74,

        /// <summary>
        /// British thermal unit (thermochemical) per hour square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N75")]
        [StringValue("N75")]
        ClaveUnidad_N75,

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N76")]
        [StringValue("N76")]
        ClaveUnidad_N76,

        /// <summary>
        /// British thermal unit (thermochemical) per second square foot degree Fahrenheit
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N77")]
        [StringValue("N77")]
        ClaveUnidad_N77,

        /// <summary>
        /// kilowatt per square metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N78")]
        [StringValue("N78")]
        ClaveUnidad_N78,

        /// <summary>
        /// kelvin per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N79")]
        [StringValue("N79")]
        ClaveUnidad_N79,

        /// <summary>
        /// watt per metre degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N80")]
        [StringValue("N80")]
        ClaveUnidad_N80,

        /// <summary>
        /// kilowatt per metre kelvin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N81")]
        [StringValue("N81")]
        ClaveUnidad_N81,

        /// <summary>
        /// kilowatt per metre degree Celsius
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N82")]
        [StringValue("N82")]
        ClaveUnidad_N82,

        /// <summary>
        /// metre per degree Celcius metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N83")]
        [StringValue("N83")]
        ClaveUnidad_N83,

        /// <summary>
        /// degree Fahrenheit hour per British thermal unit (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N84")]
        [StringValue("N84")]
        ClaveUnidad_N84,

        /// <summary>
        /// degree Fahrenheit hour per British thermal unit (thermochemical)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N85")]
        [StringValue("N85")]
        ClaveUnidad_N85,

        /// <summary>
        /// degree Fahrenheit second per British thermal unit (international table)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N86")]
        [StringValue("N86")]
        ClaveUnidad_N86,

        /// <summary>
        /// degree Fahrenheit second per British thermal unit (thermochemical)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N87")]
        [StringValue("N87")]
        ClaveUnidad_N87,

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (international table) inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N88")]
        [StringValue("N88")]
        ClaveUnidad_N88,

        /// <summary>
        /// degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N89")]
        [StringValue("N89")]
        ClaveUnidad_N89,

        /// <summary>
        /// kilofarad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N90")]
        [StringValue("N90")]
        ClaveUnidad_N90,

        /// <summary>
        /// reciprocal joule
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N91")]
        [StringValue("N91")]
        ClaveUnidad_N91,

        /// <summary>
        /// picosiemens
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N92")]
        [StringValue("N92")]
        ClaveUnidad_N92,

        /// <summary>
        /// ampere per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N93")]
        [StringValue("N93")]
        ClaveUnidad_N93,

        /// <summary>
        /// franklin
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N94")]
        [StringValue("N94")]
        ClaveUnidad_N94,

        /// <summary>
        /// ampere minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N95")]
        [StringValue("N95")]
        ClaveUnidad_N95,

        /// <summary>
        /// biot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N96")]
        [StringValue("N96")]
        ClaveUnidad_N96,

        /// <summary>
        /// gilbert
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N97")]
        [StringValue("N97")]
        ClaveUnidad_N97,

        /// <summary>
        /// volt per pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N98")]
        [StringValue("N98")]
        ClaveUnidad_N98,

        /// <summary>
        /// picovolt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("N99")]
        [StringValue("N99")]
        ClaveUnidad_N99,

        /// <summary>
        /// milligram per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NA")]
        [StringValue("NA")]
        ClaveUnidad_NA,

        /// <summary>
        /// number of articles
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NAR")]
        [StringValue("NAR")]
        ClaveUnidad_NAR,

        /// <summary>
        /// number of cells
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NCL")]
        [StringValue("NCL")]
        ClaveUnidad_NCL,

        /// <summary>
        /// newton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NEW")]
        [StringValue("NEW")]
        ClaveUnidad_NEW,

        /// <summary>
        /// message
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NF")]
        [StringValue("NF")]
        ClaveUnidad_NF,

        /// <summary>
        /// nil
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NIL")]
        [StringValue("NIL")]
        ClaveUnidad_NIL,

        /// <summary>
        /// number of international units
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NIU")]
        [StringValue("NIU")]
        ClaveUnidad_NIU,

        /// <summary>
        /// load
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NL")]
        [StringValue("NL")]
        ClaveUnidad_NL,

        /// <summary>
        /// Normalised cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NM3")]
        [StringValue("NM3")]
        ClaveUnidad_NM3,

        /// <summary>
        /// nautical mile
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NMI")]
        [StringValue("NMI")]
        ClaveUnidad_NMI,

        /// <summary>
        /// number of packs
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NMP")]
        [StringValue("NMP")]
        ClaveUnidad_NMP,

        /// <summary>
        /// number of parts
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NPT")]
        [StringValue("NPT")]
        ClaveUnidad_NPT,

        /// <summary>
        /// net ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NT")]
        [StringValue("NT")]
        ClaveUnidad_NT,

        /// <summary>
        /// newton metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NU")]
        [StringValue("NU")]
        ClaveUnidad_NU,

        /// <summary>
        /// part per thousand
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NX")]
        [StringValue("NX")]
        ClaveUnidad_NX,

        /// <summary>
        /// panel
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OA")]
        [StringValue("OA")]
        ClaveUnidad_OA,

        /// <summary>
        /// ozone depletion equivalent
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ODE")]
        [StringValue("ODE")]
        ClaveUnidad_ODE,

        /// <summary>
        /// ohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OHM")]
        [StringValue("OHM")]
        ClaveUnidad_OHM,

        /// <summary>
        /// ounce per square yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ON")]
        [StringValue("ON")]
        ClaveUnidad_ON,

        /// <summary>
        /// ounce (avoirdupois)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ONZ")]
        [StringValue("ONZ")]
        ClaveUnidad_ONZ,

        /// <summary>
        /// oscillations per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OPM")]
        [StringValue("OPM")]
        ClaveUnidad_OPM,

        /// <summary>
        /// overtime hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OT")]
        [StringValue("OT")]
        ClaveUnidad_OT,

        /// <summary>
        /// fluid ounce (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OZA")]
        [StringValue("OZA")]
        ClaveUnidad_OZA,

        /// <summary>
        /// fluid ounce (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OZI")]
        [StringValue("OZI")]
        ClaveUnidad_OZI,

        /// <summary>
        /// percent
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P1")]
        [StringValue("P1")]
        ClaveUnidad_P1,

        /// <summary>
        /// coulomb per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P10")]
        [StringValue("P10")]
        ClaveUnidad_P10,

        /// <summary>
        /// kiloweber
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P11")]
        [StringValue("P11")]
        ClaveUnidad_P11,

        /// <summary>
        /// gamma
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P12")]
        [StringValue("P12")]
        ClaveUnidad_P12,

        /// <summary>
        /// kilotesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P13")]
        [StringValue("P13")]
        ClaveUnidad_P13,

        /// <summary>
        /// joule per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P14")]
        [StringValue("P14")]
        ClaveUnidad_P14,

        /// <summary>
        /// joule per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P15")]
        [StringValue("P15")]
        ClaveUnidad_P15,

        /// <summary>
        /// joule per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P16")]
        [StringValue("P16")]
        ClaveUnidad_P16,

        /// <summary>
        /// joule per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P17")]
        [StringValue("P17")]
        ClaveUnidad_P17,

        /// <summary>
        /// kilojoule per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P18")]
        [StringValue("P18")]
        ClaveUnidad_P18,

        /// <summary>
        /// kilojoule per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P19")]
        [StringValue("P19")]
        ClaveUnidad_P19,

        /// <summary>
        /// pound per foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P2")]
        [StringValue("P2")]
        ClaveUnidad_P2,

        /// <summary>
        /// kilojoule per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P20")]
        [StringValue("P20")]
        ClaveUnidad_P20,

        /// <summary>
        /// kilojoule per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P21")]
        [StringValue("P21")]
        ClaveUnidad_P21,

        /// <summary>
        /// nanoohm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P22")]
        [StringValue("P22")]
        ClaveUnidad_P22,

        /// <summary>
        /// ohm circular-mil per foot 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P23")]
        [StringValue("P23")]
        ClaveUnidad_P23,

        /// <summary>
        /// kilohenry
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P24")]
        [StringValue("P24")]
        ClaveUnidad_P24,

        /// <summary>
        /// lumen per square foot 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P25")]
        [StringValue("P25")]
        ClaveUnidad_P25,

        /// <summary>
        /// phot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P26")]
        [StringValue("P26")]
        ClaveUnidad_P26,

        /// <summary>
        /// footcandle
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P27")]
        [StringValue("P27")]
        ClaveUnidad_P27,

        /// <summary>
        /// candela per square inch 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P28")]
        [StringValue("P28")]
        ClaveUnidad_P28,

        /// <summary>
        /// footlambert
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P29")]
        [StringValue("P29")]
        ClaveUnidad_P29,

        /// <summary>
        /// lambert
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P30")]
        [StringValue("P30")]
        ClaveUnidad_P30,

        /// <summary>
        /// stilb
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P31")]
        [StringValue("P31")]
        ClaveUnidad_P31,

        /// <summary>
        /// candela per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P32")]
        [StringValue("P32")]
        ClaveUnidad_P32,

        /// <summary>
        /// kilocandela
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P33")]
        [StringValue("P33")]
        ClaveUnidad_P33,

        /// <summary>
        /// millicandela
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P34")]
        [StringValue("P34")]
        ClaveUnidad_P34,

        /// <summary>
        /// Hefner-Kerze
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P35")]
        [StringValue("P35")]
        ClaveUnidad_P35,

        /// <summary>
        /// international candle 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P36")]
        [StringValue("P36")]
        ClaveUnidad_P36,

        /// <summary>
        /// British thermal unit (international table) per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P37")]
        [StringValue("P37")]
        ClaveUnidad_P37,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P38")]
        [StringValue("P38")]
        ClaveUnidad_P38,

        /// <summary>
        /// calorie (thermochemical) per square centimetre 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P39")]
        [StringValue("P39")]
        ClaveUnidad_P39,

        /// <summary>
        /// langley
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P40")]
        [StringValue("P40")]
        ClaveUnidad_P40,

        /// <summary>
        /// decade (logarithmic)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P41")]
        [StringValue("P41")]
        ClaveUnidad_P41,

        /// <summary>
        /// pascal squared second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P42")]
        [StringValue("P42")]
        ClaveUnidad_P42,

        /// <summary>
        /// bel per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P43")]
        [StringValue("P43")]
        ClaveUnidad_P43,

        /// <summary>
        /// pound mole
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P44")]
        [StringValue("P44")]
        ClaveUnidad_P44,

        /// <summary>
        /// pound mole per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P45")]
        [StringValue("P45")]
        ClaveUnidad_P45,

        /// <summary>
        /// pound mole per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P46")]
        [StringValue("P46")]
        ClaveUnidad_P46,

        /// <summary>
        /// kilomole per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P47")]
        [StringValue("P47")]
        ClaveUnidad_P47,

        /// <summary>
        /// pound mole per pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P48")]
        [StringValue("P48")]
        ClaveUnidad_P48,

        /// <summary>
        /// newton square metre per ampere
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P49")]
        [StringValue("P49")]
        ClaveUnidad_P49,

        /// <summary>
        /// five pack
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P5")]
        [StringValue("P5")]
        ClaveUnidad_P5,

        /// <summary>
        /// weber metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P50")]
        [StringValue("P50")]
        ClaveUnidad_P50,

        /// <summary>
        /// mol per kilogram pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P51")]
        [StringValue("P51")]
        ClaveUnidad_P51,

        /// <summary>
        /// mol per cubic metre pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P52")]
        [StringValue("P52")]
        ClaveUnidad_P52,

        /// <summary>
        /// unit pole 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P53")]
        [StringValue("P53")]
        ClaveUnidad_P53,

        /// <summary>
        /// milligray per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P54")]
        [StringValue("P54")]
        ClaveUnidad_P54,

        /// <summary>
        /// microgray per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P55")]
        [StringValue("P55")]
        ClaveUnidad_P55,

        /// <summary>
        /// nanogray per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P56")]
        [StringValue("P56")]
        ClaveUnidad_P56,

        /// <summary>
        /// gray per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P57")]
        [StringValue("P57")]
        ClaveUnidad_P57,

        /// <summary>
        /// milligray per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P58")]
        [StringValue("P58")]
        ClaveUnidad_P58,

        /// <summary>
        /// microgray per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P59")]
        [StringValue("P59")]
        ClaveUnidad_P59,

        /// <summary>
        /// nanogray per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P60")]
        [StringValue("P60")]
        ClaveUnidad_P60,

        /// <summary>
        /// gray per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P61")]
        [StringValue("P61")]
        ClaveUnidad_P61,

        /// <summary>
        /// milligray per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P62")]
        [StringValue("P62")]
        ClaveUnidad_P62,

        /// <summary>
        /// microgray per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P63")]
        [StringValue("P63")]
        ClaveUnidad_P63,

        /// <summary>
        /// nanogray per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P64")]
        [StringValue("P64")]
        ClaveUnidad_P64,

        /// <summary>
        /// sievert per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P65")]
        [StringValue("P65")]
        ClaveUnidad_P65,

        /// <summary>
        /// millisievert per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P66")]
        [StringValue("P66")]
        ClaveUnidad_P66,

        /// <summary>
        /// microsievert per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P67")]
        [StringValue("P67")]
        ClaveUnidad_P67,

        /// <summary>
        /// nanosievert per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P68")]
        [StringValue("P68")]
        ClaveUnidad_P68,

        /// <summary>
        /// rem per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P69")]
        [StringValue("P69")]
        ClaveUnidad_P69,

        /// <summary>
        /// sievert per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P70")]
        [StringValue("P70")]
        ClaveUnidad_P70,

        /// <summary>
        /// millisievert per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P71")]
        [StringValue("P71")]
        ClaveUnidad_P71,

        /// <summary>
        /// microsievert per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P72")]
        [StringValue("P72")]
        ClaveUnidad_P72,

        /// <summary>
        /// nanosievert per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P73")]
        [StringValue("P73")]
        ClaveUnidad_P73,

        /// <summary>
        /// sievert per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P74")]
        [StringValue("P74")]
        ClaveUnidad_P74,

        /// <summary>
        /// millisievert per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P75")]
        [StringValue("P75")]
        ClaveUnidad_P75,

        /// <summary>
        /// microsievert per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P76")]
        [StringValue("P76")]
        ClaveUnidad_P76,

        /// <summary>
        /// nanosievert per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P77")]
        [StringValue("P77")]
        ClaveUnidad_P77,

        /// <summary>
        /// reciprocal square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P78")]
        [StringValue("P78")]
        ClaveUnidad_P78,

        /// <summary>
        /// pascal square metre per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P79")]
        [StringValue("P79")]
        ClaveUnidad_P79,

        /// <summary>
        /// millipascal per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P80")]
        [StringValue("P80")]
        ClaveUnidad_P80,

        /// <summary>
        /// kilopascal per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P81")]
        [StringValue("P81")]
        ClaveUnidad_P81,

        /// <summary>
        /// hectopascal per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P82")]
        [StringValue("P82")]
        ClaveUnidad_P82,

        /// <summary>
        /// standard atmosphere per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P83")]
        [StringValue("P83")]
        ClaveUnidad_P83,

        /// <summary>
        /// technical atmosphere per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P84")]
        [StringValue("P84")]
        ClaveUnidad_P84,

        /// <summary>
        /// torr per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P85")]
        [StringValue("P85")]
        ClaveUnidad_P85,

        /// <summary>
        /// psi per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P86")]
        [StringValue("P86")]
        ClaveUnidad_P86,

        /// <summary>
        /// cubic metre per second square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P87")]
        [StringValue("P87")]
        ClaveUnidad_P87,

        /// <summary>
        /// rhe
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P88")]
        [StringValue("P88")]
        ClaveUnidad_P88,

        /// <summary>
        /// pound-force foot per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P89")]
        [StringValue("P89")]
        ClaveUnidad_P89,

        /// <summary>
        /// pound-force inch per inch 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P90")]
        [StringValue("P90")]
        ClaveUnidad_P90,

        /// <summary>
        /// perm (0 ºC) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P91")]
        [StringValue("P91")]
        ClaveUnidad_P91,

        /// <summary>
        /// perm (23 ºC) 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P92")]
        [StringValue("P92")]
        ClaveUnidad_P92,

        /// <summary>
        /// byte per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P93")]
        [StringValue("P93")]
        ClaveUnidad_P93,

        /// <summary>
        /// kilobyte per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P94")]
        [StringValue("P94")]
        ClaveUnidad_P94,

        /// <summary>
        /// megabyte per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P95")]
        [StringValue("P95")]
        ClaveUnidad_P95,

        /// <summary>
        /// reciprocal volt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P96")]
        [StringValue("P96")]
        ClaveUnidad_P96,

        /// <summary>
        /// reciprocal radian
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P97")]
        [StringValue("P97")]
        ClaveUnidad_P97,

        /// <summary>
        /// pascal to the power sum of stoichiometric numbers
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P98")]
        [StringValue("P98")]
        ClaveUnidad_P98,

        /// <summary>
        /// mole per cubiv metre to the power sum of stoichiometric numbers
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("P99")]
        [StringValue("P99")]
        ClaveUnidad_P99,

        /// <summary>
        /// pascal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PAL")]
        [StringValue("PAL")]
        ClaveUnidad_PAL,

        /// <summary>
        /// pad
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PD")]
        [StringValue("PD")]
        ClaveUnidad_PD,

        /// <summary>
        /// proof litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PFL")]
        [StringValue("PFL")]
        ClaveUnidad_PFL,

        /// <summary>
        /// proof gallon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PGL")]
        [StringValue("PGL")]
        ClaveUnidad_PGL,

        /// <summary>
        /// pitch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PI")]
        [StringValue("PI")]
        ClaveUnidad_PI,

        /// <summary>
        /// degree Plato
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PLA")]
        [StringValue("PLA")]
        ClaveUnidad_PLA,

        /// <summary>
        /// pound per inch of length
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PO")]
        [StringValue("PO")]
        ClaveUnidad_PO,

        /// <summary>
        /// page per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PQ")]
        [StringValue("PQ")]
        ClaveUnidad_PQ,

        /// <summary>
        /// pair
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PR")]
        [StringValue("PR")]
        ClaveUnidad_PR,

        /// <summary>
        /// pound-force per square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PS")]
        [StringValue("PS")]
        ClaveUnidad_PS,

        /// <summary>
        /// dry pint (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PTD")]
        [StringValue("PTD")]
        ClaveUnidad_PTD,

        /// <summary>
        /// pint (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PTI")]
        [StringValue("PTI")]
        ClaveUnidad_PTI,

        /// <summary>
        /// liquid pint (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PTL")]
        [StringValue("PTL")]
        ClaveUnidad_PTL,

        /// <summary>
        /// portion
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("PTN")]
        [StringValue("PTN")]
        ClaveUnidad_PTN,

        /// <summary>
        /// joule per tesla
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q10")]
        [StringValue("Q10")]
        ClaveUnidad_Q10,

        /// <summary>
        /// erlang
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q11")]
        [StringValue("Q11")]
        ClaveUnidad_Q11,

        /// <summary>
        /// octet
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q12")]
        [StringValue("Q12")]
        ClaveUnidad_Q12,

        /// <summary>
        /// octet per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q13")]
        [StringValue("Q13")]
        ClaveUnidad_Q13,

        /// <summary>
        /// shannon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q14")]
        [StringValue("Q14")]
        ClaveUnidad_Q14,

        /// <summary>
        /// hartley
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q15")]
        [StringValue("Q15")]
        ClaveUnidad_Q15,

        /// <summary>
        /// natural unit of information
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q16")]
        [StringValue("Q16")]
        ClaveUnidad_Q16,

        /// <summary>
        /// shannon per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q17")]
        [StringValue("Q17")]
        ClaveUnidad_Q17,

        /// <summary>
        /// hartley per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q18")]
        [StringValue("Q18")]
        ClaveUnidad_Q18,

        /// <summary>
        /// natural unit of information per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q19")]
        [StringValue("Q19")]
        ClaveUnidad_Q19,

        /// <summary>
        /// second per kilogramm
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q20")]
        [StringValue("Q20")]
        ClaveUnidad_Q20,

        /// <summary>
        /// watt square metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q21")]
        [StringValue("Q21")]
        ClaveUnidad_Q21,

        /// <summary>
        /// second per radian cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q22")]
        [StringValue("Q22")]
        ClaveUnidad_Q22,

        /// <summary>
        /// weber to the power minus one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q23")]
        [StringValue("Q23")]
        ClaveUnidad_Q23,

        /// <summary>
        /// reciprocal inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q24")]
        [StringValue("Q24")]
        ClaveUnidad_Q24,

        /// <summary>
        /// dioptre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q25")]
        [StringValue("Q25")]
        ClaveUnidad_Q25,

        /// <summary>
        /// one per one
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q26")]
        [StringValue("Q26")]
        ClaveUnidad_Q26,

        /// <summary>
        /// newton metre per metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q27")]
        [StringValue("Q27")]
        ClaveUnidad_Q27,

        /// <summary>
        /// kilogram per square metre pascal second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q28")]
        [StringValue("Q28")]
        ClaveUnidad_Q28,

        /// <summary>
        /// microgram per hectogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q29")]
        [StringValue("Q29")]
        ClaveUnidad_Q29,

        /// <summary>
        /// meal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q3")]
        [StringValue("Q3")]
        ClaveUnidad_Q3,

        /// <summary>
        /// pH (potential of Hydrogen)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q30")]
        [StringValue("Q30")]
        ClaveUnidad_Q30,

        /// <summary>
        /// kilojoule per gram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q31")]
        [StringValue("Q31")]
        ClaveUnidad_Q31,

        /// <summary>
        /// femtolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q32")]
        [StringValue("Q32")]
        ClaveUnidad_Q32,

        /// <summary>
        /// picolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q33")]
        [StringValue("Q33")]
        ClaveUnidad_Q33,

        /// <summary>
        /// nanolitre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q34")]
        [StringValue("Q34")]
        ClaveUnidad_Q34,

        /// <summary>
        /// megawatts per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q35")]
        [StringValue("Q35")]
        ClaveUnidad_Q35,

        /// <summary>
        /// square metre per cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q36")]
        [StringValue("Q36")]
        ClaveUnidad_Q36,

        /// <summary>
        /// Standard cubic metre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q37")]
        [StringValue("Q37")]
        ClaveUnidad_Q37,

        /// <summary>
        /// Standard cubic metre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q38")]
        [StringValue("Q38")]
        ClaveUnidad_Q38,

        /// <summary>
        /// Normalized cubic metre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q39")]
        [StringValue("Q39")]
        ClaveUnidad_Q39,

        /// <summary>
        /// Normalized cubic metre per hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q40")]
        [StringValue("Q40")]
        ClaveUnidad_Q40,

        /// <summary>
        /// Joule per normalised cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q41")]
        [StringValue("Q41")]
        ClaveUnidad_Q41,

        /// <summary>
        /// Joule per standard cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Q42")]
        [StringValue("Q42")]
        ClaveUnidad_Q42,

        /// <summary>
        /// page - facsimile
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QA")]
        [StringValue("QA")]
        ClaveUnidad_QA,

        /// <summary>
        /// quarter (of a year)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QAN")]
        [StringValue("QAN")]
        ClaveUnidad_QAN,

        /// <summary>
        /// page - hardcopy
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QB")]
        [StringValue("QB")]
        ClaveUnidad_QB,

        /// <summary>
        /// quire
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QR")]
        [StringValue("QR")]
        ClaveUnidad_QR,

        /// <summary>
        /// dry quart (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QTD")]
        [StringValue("QTD")]
        ClaveUnidad_QTD,

        /// <summary>
        /// quart (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QTI")]
        [StringValue("QTI")]
        ClaveUnidad_QTI,

        /// <summary>
        /// liquid quart (US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QTL")]
        [StringValue("QTL")]
        ClaveUnidad_QTL,

        /// <summary>
        /// quarter (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("QTR")]
        [StringValue("QTR")]
        ClaveUnidad_QTR,

        /// <summary>
        /// pica
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("R1")]
        [StringValue("R1")]
        ClaveUnidad_R1,

        /// <summary>
        /// thousand cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("R9")]
        [StringValue("R9")]
        ClaveUnidad_R9,

        /// <summary>
        /// running or operating hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RH")]
        [StringValue("RH")]
        ClaveUnidad_RH,

        /// <summary>
        /// ream
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RM")]
        [StringValue("RM")]
        ClaveUnidad_RM,

        /// <summary>
        /// room
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ROM")]
        [StringValue("ROM")]
        ClaveUnidad_ROM,

        /// <summary>
        /// pound per ream
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RP")]
        [StringValue("RP")]
        ClaveUnidad_RP,

        /// <summary>
        /// revolutions per minute
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RPM")]
        [StringValue("RPM")]
        ClaveUnidad_RPM,

        /// <summary>
        /// revolutions per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RPS")]
        [StringValue("RPS")]
        ClaveUnidad_RPS,

        /// <summary>
        /// revenue ton mile
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("RT")]
        [StringValue("RT")]
        ClaveUnidad_RT,

        /// <summary>
        /// square foot per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("S3")]
        [StringValue("S3")]
        ClaveUnidad_S3,

        /// <summary>
        /// square metre per second
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("S4")]
        [StringValue("S4")]
        ClaveUnidad_S4,

        /// <summary>
        /// half year (6 months)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SAN")]
        [StringValue("SAN")]
        ClaveUnidad_SAN,

        /// <summary>
        /// score
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SCO")]
        [StringValue("SCO")]
        ClaveUnidad_SCO,

        /// <summary>
        /// scruple
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SCR")]
        [StringValue("SCR")]
        ClaveUnidad_SCR,

        /// <summary>
        /// second [unit of time]
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SEC")]
        [StringValue("SEC")]
        ClaveUnidad_SEC,

        /// <summary>
        /// set
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SET")]
        [StringValue("SET")]
        ClaveUnidad_SET,

        /// <summary>
        /// segment
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SG")]
        [StringValue("SG")]
        ClaveUnidad_SG,

        /// <summary>
        /// siemens
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SIE")]
        [StringValue("SIE")]
        ClaveUnidad_SIE,

        /// <summary>
        /// Standard cubic metre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SM3")]
        [StringValue("SM3")]
        ClaveUnidad_SM3,

        /// <summary>
        /// mile (statute mile)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SMI")]
        [StringValue("SMI")]
        ClaveUnidad_SMI,

        /// <summary>
        /// square
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SQ")]
        [StringValue("SQ")]
        ClaveUnidad_SQ,

        /// <summary>
        /// square, roofing
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SQR")]
        [StringValue("SQR")]
        ClaveUnidad_SQR,

        /// <summary>
        /// strip
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SR")]
        [StringValue("SR")]
        ClaveUnidad_SR,

        /// <summary>
        /// stick
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STC")]
        [StringValue("STC")]
        ClaveUnidad_STC,

        /// <summary>
        /// stone (UK)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STI")]
        [StringValue("STI")]
        ClaveUnidad_STI,

        /// <summary>
        /// stick, cigarette
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STK")]
        [StringValue("STK")]
        ClaveUnidad_STK,

        /// <summary>
        /// standard litre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STL")]
        [StringValue("STL")]
        ClaveUnidad_STL,

        /// <summary>
        /// ton (US) or short ton (UK/US)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STN")]
        [StringValue("STN")]
        ClaveUnidad_STN,

        /// <summary>
        /// straw
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("STW")]
        [StringValue("STW")]
        ClaveUnidad_STW,

        /// <summary>
        /// skein
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SW")]
        [StringValue("SW")]
        ClaveUnidad_SW,

        /// <summary>
        /// shipment
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SX")]
        [StringValue("SX")]
        ClaveUnidad_SX,

        /// <summary>
        /// syringe
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SYR")]
        [StringValue("SYR")]
        ClaveUnidad_SYR,

        /// <summary>
        /// telecommunication line in service
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("T0")]
        [StringValue("T0")]
        ClaveUnidad_T0,

        /// <summary>
        /// thousand piece
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("T3")]
        [StringValue("T3")]
        ClaveUnidad_T3,

        /// <summary>
        /// kiloampere hour (thousand ampere hour)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TAH")]
        [StringValue("TAH")]
        ClaveUnidad_TAH,

        /// <summary>
        /// total acid number
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TAN")]
        [StringValue("TAN")]
        ClaveUnidad_TAN,

        /// <summary>
        /// thousand square inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TI")]
        [StringValue("TI")]
        ClaveUnidad_TI,

        /// <summary>
        /// metric ton, including container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TIC")]
        [StringValue("TIC")]
        ClaveUnidad_TIC,

        /// <summary>
        /// metric ton, including inner packaging
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TIP")]
        [StringValue("TIP")]
        ClaveUnidad_TIP,

        /// <summary>
        /// tonne kilometre
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TKM")]
        [StringValue("TKM")]
        ClaveUnidad_TKM,

        /// <summary>
        /// kilogram of imported meat, less offal
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TMS")]
        [StringValue("TMS")]
        ClaveUnidad_TMS,

        /// <summary>
        /// tonne (metric ton)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TNE")]
        [StringValue("TNE")]
        ClaveUnidad_TNE,

        /// <summary>
        /// ten pack
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TP")]
        [StringValue("TP")]
        ClaveUnidad_TP,

        /// <summary>
        /// teeth per inch
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TPI")]
        [StringValue("TPI")]
        ClaveUnidad_TPI,

        /// <summary>
        /// ten pair
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TPR")]
        [StringValue("TPR")]
        ClaveUnidad_TPR,

        /// <summary>
        /// thousand cubic metre per day
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TQD")]
        [StringValue("TQD")]
        ClaveUnidad_TQD,

        /// <summary>
        /// trillion (EUR)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TRL")]
        [StringValue("TRL")]
        ClaveUnidad_TRL,

        /// <summary>
        /// ten set
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TST")]
        [StringValue("TST")]
        ClaveUnidad_TST,

        /// <summary>
        /// ten thousand sticks
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("TTS")]
        [StringValue("TTS")]
        ClaveUnidad_TTS,

        /// <summary>
        /// treatment
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("U1")]
        [StringValue("U1")]
        ClaveUnidad_U1,

        /// <summary>
        /// tablet
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("U2")]
        [StringValue("U2")]
        ClaveUnidad_U2,

        /// <summary>
        /// telecommunication line in service average
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("UB")]
        [StringValue("UB")]
        ClaveUnidad_UB,

        /// <summary>
        /// telecommunication port
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("UC")]
        [StringValue("UC")]
        ClaveUnidad_UC,

        /// <summary>
        /// volt - ampere per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("VA")]
        [StringValue("VA")]
        ClaveUnidad_VA,

        /// <summary>
        /// volt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("VLT")]
        [StringValue("VLT")]
        ClaveUnidad_VLT,

        /// <summary>
        /// percent volume
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("VP")]
        [StringValue("VP")]
        ClaveUnidad_VP,

        /// <summary>
        /// wet kilo
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("W2")]
        [StringValue("W2")]
        ClaveUnidad_W2,

        /// <summary>
        /// watt per kilogram
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WA")]
        [StringValue("WA")]
        ClaveUnidad_WA,

        /// <summary>
        /// wet pound
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WB")]
        [StringValue("WB")]
        ClaveUnidad_WB,

        /// <summary>
        /// cord
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WCD")]
        [StringValue("WCD")]
        ClaveUnidad_WCD,

        /// <summary>
        /// wet ton
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WE")]
        [StringValue("WE")]
        ClaveUnidad_WE,

        /// <summary>
        /// weber
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WEB")]
        [StringValue("WEB")]
        ClaveUnidad_WEB,

        /// <summary>
        /// week
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WEE")]
        [StringValue("WEE")]
        ClaveUnidad_WEE,

        /// <summary>
        /// wine gallon
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WG")]
        [StringValue("WG")]
        ClaveUnidad_WG,

        /// <summary>
        /// watt hour
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WHR")]
        [StringValue("WHR")]
        ClaveUnidad_WHR,

        /// <summary>
        /// working month
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WM")]
        [StringValue("WM")]
        ClaveUnidad_WM,

        /// <summary>
        /// standard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WSD")]
        [StringValue("WSD")]
        ClaveUnidad_WSD,

        /// <summary>
        /// watt
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("WTT")]
        [StringValue("WTT")]
        ClaveUnidad_WTT,

        /// <summary>
        /// Gunter's chain
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("X1")]
        [StringValue("X1")]
        ClaveUnidad_X1,

        /// <summary>
        /// square yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("YDK")]
        [StringValue("YDK")]
        ClaveUnidad_YDK,

        /// <summary>
        /// cubic yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("YDQ")]
        [StringValue("YDQ")]
        ClaveUnidad_YDQ,

        /// <summary>
        /// yard
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("YRD")]
        [StringValue("YRD")]
        ClaveUnidad_YRD,

        /// <summary>
        /// hanging container
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Z11")]
        [StringValue("Z11")]
        ClaveUnidad_Z11,

        /// <summary>
        /// page
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ZP")]
        [StringValue("ZP")]
        ClaveUnidad_ZP,

        /// <summary>
        /// mutually defined
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ZZ")]
        [StringValue("ZZ")]
        ClaveUnidad_ZZ
    }

}
