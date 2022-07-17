using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailCRMCore.Models
{
    public class CreateOrderObject
    {
        private DateTime _createdAt;
        public string externalId { get; set; }
        public DateTime createdAt { get => _createdAt; set => _createdAt = value; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public List<OrderProduct> items { get; set; } = new List<OrderProduct>();
        public Address address { get; set; }
        public string deliveryType { get; set; }
        public string paymentType { get; set; }
        public string comment { get; set; }
        public double price { get; set; }
        public string patronymic { get; set; }
        public int managerId { get; set; }
        public Customer? customer { get; set; }
        public Delivery? delivery { get; set; }

        public double? discountManualAmount { get; set; }
        public double? discountManualPercent { get; set; }
    }
}
