﻿using System.Xml.Serialization;

namespace DKP.Data.MonDKP.Entities.Xml
{
    [XmlType("dkptable")]
    public class DkpTable
    {
        [XmlElement("dkpentry", typeof(DkpEntry))]
        public DkpEntry[] DkpEntries { get; set; }
    }
}