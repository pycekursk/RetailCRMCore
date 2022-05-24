using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailCRMCore.Models
{
  public class IntegrationModule
  {
    public string externalId { get; set; }
    public string code { get; set; }
    public string integrationCode { get; set; }
    public bool active { get; set; }
    public bool freeze { get; set; }
    public string name { get; set; }
    public string logo { get; set; }
    public bool native { get; set; }
    public string baseUrl { get; set; }
    public Dictionary<string, string> actions { get; set; }
    public string[] availableCountries { get; set; }
    public string accountUrl { get; set; }
    public Integrations integrations { get; set; }
    public string clientId { get; set; }
    public string apiKey { get; set; }
  }

  public class Integrations
  {
    public IntegrationModuleDelivery delivery { get; set; }
  }

  public class IntegrationModuleDelivery
  {
    public string description { get; set; }
    public Dictionary<string, string> actions { get; set; }
    public string[] payerType { get; set; }
    public int platePrintLimit { get; set; }
    public bool rateDeliveryCost { get; set; }
    public bool allowPackages { get; set; }
    public bool codAvailable { get; set; }
    public bool selfShipmentAvailable { get; set; }
    public bool duplicateOrderProductSupported { get; set; }
    public bool allowTrackNumber { get; set; }
    public string[] availableCountries { get; set; }
    public string[] requiredFields { get; set; }
    public Statuslist[] statusList { get; set; }
    public Platelist[] plateList { get; set; }
    public Deliverydatafieldlist[] deliveryDataFieldList { get; set; }
    public IntegrationModuleSettings settings { get; set; }
  }

  public class IntegrationModuleSettings
  {
    public string costCalculateBy { get; set; }
    public bool nullDeclaredValue { get; set; }
    public bool lockedByDefault { get; set; }
    public Paymenttype[] paymentTypes { get; set; }
    public Shipmentpoint[] shipmentPoints { get; set; }
    public Status[] statuses { get; set; }
    public Deliveryextradata deliveryExtraData { get; set; }
  }

  public class Deliveryextradata
  {
    public string[] services { get; set; }
    public string additional_cost_type { get; set; }
    public int additional_cost { get; set; }
  }

  public class Paymenttype
  {
    public string code { get; set; }
    public bool active { get; set; }
    public bool cod { get; set; }
  }

  public class Shipmentpoint
  {
    public string code { get; set; }
    public string shipmentPointId { get; set; }
    public string shipmentPointLabel { get; set; }
  }

  //public class Status
  //{
  //  public string trackingStatusCode { get; set; }
  //  public string code { get; set; }
  //}

  public class Statuslist
  {
    public string code { get; set; }
    public string name { get; set; }
    public bool isEditable { get; set; }
    public bool isError { get; set; }
    public bool isPreprocessing { get; set; }
  }

  public class Platelist
  {
    public string type { get; set; }
    public string code { get; set; }
    public string label { get; set; }
  }

  public class Deliverydatafieldlist
  {
    public string code { get; set; }
    public string label { get; set; }
    public string hint { get; set; }
    public string type { get; set; }
    public bool multiple { get; set; }
    public bool visible { get; set; }
    public bool required { get; set; }
    public bool affectsCost { get; set; }
    public bool editable { get; set; }
    public Choice[] choices { get; set; }
  }

  public class Choice
  {
    public string label { get; set; }
    public string value { get; set; }
  }
}
