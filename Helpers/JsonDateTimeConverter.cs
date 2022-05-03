using System.Text.Json;

namespace RetailCRMCore.Helpers
{
  public class JsonDateTimeConverter : System.Text.Json.Serialization.JsonConverter<DateTime>
  {
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      
      using (var jsonDoc = JsonDocument.ParseValue(ref reader))
      {
        return DateTime.SpecifyKind(
            DateTime.Parse(jsonDoc.RootElement.GetRawText().Trim('"').Trim('\'')),
            DateTimeKind.Utc
        );
      }
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
      var val = value.ToString("yyyy-MM-dd HH:mm:ss");
      writer.WriteStringValue(val);
    }
  }
}