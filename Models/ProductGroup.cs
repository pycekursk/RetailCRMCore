

namespace RetailCRMCore.Models
{
    public class ProductGroup
    {
        public override bool Equals(object? obj)
        {
            return (obj as ProductGroup)?.id == id ? true : false;
        }

        [TableAttribute("Id")]
        public int id { get; set; }
        public int parentId { get; set; }


        [TableAttribute("Название")]
        public string name { get; set; }

        [TableAttribute("Описание")]
        public string description { get; set; }
        //public string externalId { get; set; }
        public string nameWithDepth { get; set; }
        public string site { get; set; }
        public string lvl { get; set; }
        //public ProductGroup parent { get; set; }
        public Catalog catalog { get; set; }

        [TableAttribute("Активность")]
        public bool active { get; set; }
        public ProductGroup[]? SubGroups { get; set; }
    }
}




