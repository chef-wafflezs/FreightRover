using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FRLoadXMLGenerator
{
    [Serializable]
    public class PostLoadsRequest
    {
        public Authentication Authentication { get; set; }
        public string TransactionID { get; set; }
        public string LoadVisibility { get; set; }

        [XmlArray(ElementName = "Loads")]
        [XmlArrayItem(ElementName = "Load")]
        public List<Load> Loads { get; set; }
    }
    [Serializable]
    public class Authentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    [Serializable]
    public class Load
    {
        public int NumOfLoads { get; set; }
        public string LoadId { get; set; }
        public string DocumentPurposeCode { get;set;}
        public string MustResponseByDateTime { get; set; }
        public string LastUpdateDateTime { get; set; }
        public string Currency { get; set; }
        public string DeclaredValue { get; set; }
        public LoadEntity Shipper { get; set; }
        public LoadEntity BillTo { get; set; }
        public LoadEntity Origin { get; set; }
        public LoadEntity Dest { get; set; }
        public string Equipment { get; set; }
        public string ServiceType { get; set; }
        public string Miles { get; set; }
        public string Rate { get; set; }
        public string Commodity { get; set; }
        public string Weight { get; set; }
        public string WeightUOM { get; set; }
        public string LoadVisibility { get; set; }
        public string LoadNotes { get; set; }
        public string SegmentsInfo { get; set; }
        public string ShipmentInfo { get; set; }
        public string EquipmentType { get; set; }
    }
    [Serializable]
    public class LoadEntity
    {
        public string RefId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Notes { get; set; }
        public string ApptStartDateTime { get; set; }
        public string ApptEndDateTime { get; set; }
    }
}
