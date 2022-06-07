using System.Xml.Serialization;

namespace RetailCRMCore.Models.Base
{
  public interface IDeliveryModule
  {
    public string Code { get; set; }

    public IDeliveryModule Initialize()
    {
      return this;
    }

    //public List<IPVZList> GetPVZList(Address address = null, List<string> partners = null);
  }

  public interface IPVZList
  {
    [XmlElement(ElementName = "point")]
    public List<IPVZPoint> Points { get; set; }

    [XmlAttribute(AttributeName = "partner")]
    public string Partner { get; set; }

    [XmlAttribute(AttributeName = "count")]
    public int Count { get; set; }
  }

  public interface IPVZPoint
  {
    [XmlElement(ElementName = "address")]
    public string Address { get; set; }

    [XmlElement(ElementName = "town")]
    public string Town { get; set; }

    [XmlAttribute(AttributeName = "code")]
    public string Code { get; set; }
  }


}