using System.ComponentModel;
using System.Text.Json.Serialization;


namespace RetailCRMCore.Models
{
  public class Product
  {
    public override bool Equals(object? obj)
    {
      var other = obj as Product;
      if (other == null) return false;
      return this.id == other.id ? true : false;
    }

    public int[] offersPriceRange { get; set; }
    public int minPrice { get; set; }
    public int maxPrice { get; set; }

    public int minPurchasePrice { get; set; }
    public int maxPurchasePrice { get; set; }
    public string externalId { get; set; }
    public double weight { get; set; }
    public int minWeight { get; set; }
    public int maxWeight { get; set; }

    public int id { get; set; }
    public string article { get; set; }
    public string name { get; set; }
    public string displayName { get; set; }
    public int quantity { get; set; }
    public string? imageUrl { get; set; }

    [JsonIgnore]
    public List<Product> analogs { get; set; } = new List<Product>();

    public ProductGroup[]? groups { get; set; }

    [JsonIgnore]
    public List<Model> models { get; set; } = new List<Model>();

    Offer[]? _offers;
    public Offer[]? offers
    {
      get => _offers;
      set
      {
        var images = value?.FirstOrDefault(o => o.images.Length != 0)?.images;

        foreach (var offer in value!)
        {
          if (models.Contains(offer.Model)) continue;
          models.Add(offer.Model);
        }

        if (images != null)
        {
          foreach (var image in images)
          {
            try
            {
              ImageSide side = (ImageSide)Enum.Parse(typeof(ImageSide), image.Split("_")[3].Split('.')[0]);
              ImageSize size = (ImageSize)Enum.Parse(typeof(ImageSize), image.Split("_")[2]);

              string fileName = image.Replace(image.Split("_")[0], "");
              if (this.images?.FirstOrDefault(i => i.Url == image) == null) this.images?.Add(new Image { Side = side, Url = image, Size = size, FileName = fileName });
            }
            catch (Exception exc)
            {

            }
          }
          this.images = this.images?.OrderBy(o => o.Side).ToList();
        }
        _offers = value;
      }
    }
    public List<Image>? images { get; set; } = new List<Image> { };
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public string abcClass { get; set; }
    public string xyzClass { get; set; }
    [DisplayName("Активен")]
    public bool active { get; set; }
    public bool markable { get; set; }

    public bool popular { get; set; }
    public bool stock { get; set; }
    public bool novelty { get; set; }
    public bool recommended { get; set; }

    [JsonIgnore]
    public string? modelPath { get; set; }
    public Unit unit { get; set; }

    public string description { get; set; }
    public string manufacturer { get; set; }

    public string sostav { get; set; }

    public string model { get; set; }
  }

  public class Image
  {
    public ImageSide Side { get; set; }
    public ImageSize Size { get; set; }
    public string? FileName { get; set; }
    public string? Url { get; set; }
  }

  public enum ImageSide
  {
    front = 1,
    left = 2,
    rear = 3,
    right = 4,
    @case = 5,
    unknown = 0
  }

  public enum ImageSize
  {
    s = 1,
    m = 2,
    l = 3,
    xl = 4,
    unknown = 0
  }
}


//public class ProductsViewModel
//{

//}



