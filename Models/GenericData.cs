namespace RetailCRMCore.Models
{
    public class GenericData
    {
        public string externalId { get; set; }
        public string trackNumber { get; set; }
        public string statusText { get; set; }
        public string tariff { get; set; }
        public string tariffName { get; set; }
        public string pickuppointId { get; set; }
        public string pickuppointSchedule { get; set; }
        public string pickuppointPhone { get; set; }
        public string pickuppointAddress { get; set; }

        public string pickuppointCoordinateLatitude { get; set; }
        public string pickuppointCoordinateLongitude { get; set; }
        public string statusComment { get; set; }

        public double cost { get; set; }
        public double declaredSum { get; set; }

        public DeliveryExtraData extraData { get; set; }

        public bool locked { get; set; }

        public string shipmentpointId { get; set; }
        public string shipmentpointSchedule { get; set; }
        public string shipmentpointPhone { get; set; }
        public string shipmentpointAddress { get; set; }

        public DeliveryService service { get; set; }
    }
}