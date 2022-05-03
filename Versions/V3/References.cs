using RetailCRMCore.Helpers;
using RetailCRMCore.Models;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RetailCRMCore.Versions.V3
{
  public class Response<T>
  {
    public bool Success { get; set; }
    public Pagination? Pagination { get; set; }
    public T[]? Array { get; set; }

    public static implicit operator Response<T>(RetailCRMCore.Response response)
    {
      var options = new JsonSerializerOptions
      {
        PropertyNamingPolicy = new ArrayNamingProlicy<T>(),
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
      };
      options.Converters.Add(new JsonDateTimeConverter());

      var result = new Response<T>();

      if (typeof(T).Name == "DeliveryType" || typeof(T).Name == "PaymentType")
      {
        Regex regex = new Regex("(?<!,){\"name.+?}|{\"isDynamicCostCalculation.+?}");
        var matches = regex.Matches(response.GetRawResponse());

        if (matches.Count == 0) return result;

        result = new Response<T>();
        int index = 0;
        foreach (Match match in matches)
        {
          result.Array ??= new T[matches.Count];
          var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(match.Value);
          result.Array[index++] = obj!;
        }
        result.Success = true;
      }
      else
      {
        //var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Response<T>>(response.GetRawResponse());

        //System.Text.Json.Serialization.JsonConverter jsonConverter = new DateTimeConverter();



        result = System.Text.Json.JsonSerializer.Deserialize<Response<T>>(
        response.GetRawResponse()!
         .Replace("productGroup", "productGroups")
         .Replace(@"\", "")
         .Replace("u0022", "'"),
         options
         )!;
      }
      return result;
    }
  }

  public partial class Client
  {
    /// <summary>
    /// Countries
    /// </summary>
    /// <returns></returns>
    public Response Countries()
    {
      return Request.MakeRequest(
          "/reference/countries",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Delivery services
    /// </summary>
    /// <returns></returns>
    public Response DeliveryServices()
    {
      return Request.MakeRequest(
          "/reference/delivery-services",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Delivery types
    /// </summary>
    /// <returns></returns>
    public Response DeliveryTypes()
    {
      return Request.MakeRequest(
          "/reference/delivery-types",
          Request.MethodGet
      );
    }

    public Response<T> GetResponse<T>()
    {
      var options = new JsonSerializerOptions
      {
        PropertyNamingPolicy = new ArrayNamingProlicy<T>(),
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
      };
      options.Converters.Add(new JsonDateTimeConverter());

      Response<T> response = new Response<T>();
      var request = Request.MakeRequest("/reference/delivery-types", Request.MethodGet);

      if (typeof(T).Name == "DeliveryType" || typeof(T).Name == "PaymentType")
      {
        Regex regex = new Regex("(?<!,){\"name.+?}|{\"isDynamicCostCalculation.+?}");
        var matches = regex.Matches(request.GetRawResponse());

        if (matches.Count == 0) return response;

        int index = 0;
        foreach (Match match in matches)
        {
          response.Array ??= new T[matches.Count];
          var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(match.Value);
          response.Array[index++] = obj!;
        }
        response.Success = true;
      }
      else
      {
        response = System.Text.Json.JsonSerializer.Deserialize<Response<T>>(
        request.GetRawResponse()!
         .Replace("productGroup", "productGroups")
         .Replace(@"\", "")
         .Replace("u0022", "'"),
         options
         )!;
      }
      return response;
    }

    /// <summary>
    /// Order methods
    /// </summary>
    /// <returns></returns>
    public Response OrderMethods()
    {
      return Request.MakeRequest(
          "/reference/order-methods",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Order types
    /// </summary>
    /// <returns></returns>
    public Response OrderTypes()
    {
      return Request.MakeRequest(
          "/reference/order-types",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Payment statuses
    /// </summary>
    /// <returns></returns>
    public Response PaymentStatuses()
    {
      return Request.MakeRequest(
          "/reference/payment-statuses",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Payment types
    /// </summary>
    /// <returns></returns>
    public Response PaymentTypes()
    {
      return Request.MakeRequest(
          "/reference/payment-types",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Product statuses
    /// </summary>
    /// <returns></returns>
    public Response ProductStatuses()
    {
      return Request.MakeRequest(
          "/reference/product-statuses",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Sites
    /// </summary>
    /// <returns></returns>
    public Response Sites()
    {
      return Request.MakeRequest(
          "/reference/sites",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Statuses groups
    /// </summary>
    /// <returns></returns>
    public Response StatusGroups()
    {
      return Request.MakeRequest(
          "/reference/status-groups",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Statuses
    /// </summary>
    /// <returns></returns>
    public Response Statuses()
    {
      return Request.MakeRequest(
          "/reference/statuses",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Stores
    /// </summary>
    /// <returns></returns>
    public Response Stores()
    {
      return Request.MakeRequest(
          "/reference/stores",
          Request.MethodGet
      );
    }

    /// <summary>
    /// Delivery services edit
    /// </summary>
    /// <param name="service"></param>
    /// <returns></returns>
    public Response DeliveryServicesEdit(Dictionary<string, object> service)
    {
      if (!service.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!service.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/delivery-services/{service["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "deliveryService", Newtonsoft.Json.JsonConvert.SerializeObject(service) }
          }
      );
    }

    /// <summary>
    /// Delivery types edit
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Response DeliveryTypesEdit(Dictionary<string, object> type)
    {
      if (!type.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!type.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      if (!type.ContainsKey("defaultCost"))
      {
        throw new ArgumentException("Parameter `defaultCost` is missing");
      }

      if (!type.ContainsKey("defaultNetCost"))
      {
        throw new ArgumentException("Parameter `defaultCost` is missing");
      }

      return Request.MakeRequest(
          $"/reference/delivery-types/{type["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "deliveryType", Newtonsoft.Json.JsonConvert.SerializeObject(type) }
          }
      );
    }

    /// <summary>
    /// Orders methods edit
    /// </summary>
    /// <param name="method"></param>
    /// <returns></returns>
    public Response OrderMethodsEdit(Dictionary<string, object> method)
    {
      if (!method.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!method.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/order-methods/{method["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "orderMethod", Newtonsoft.Json.JsonConvert.SerializeObject(method) }
          }
      );
    }

    /// <summary>
    /// Order types edit
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Response OrderTypesEdit(Dictionary<string, object> type)
    {
      if (!type.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!type.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/order-types/{type["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "orderType", Newtonsoft.Json.JsonConvert.SerializeObject(type) }
          }
      );
    }

    /// <summary>
    /// Payment statuses edit
    /// </summary>
    /// <param name="status"></param>
    /// <returns></returns>
    public Response PaymentStatusesEdit(Dictionary<string, object> status)
    {
      if (!status.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!status.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/payment-statuses/{status["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "paymentStatus", Newtonsoft.Json.JsonConvert.SerializeObject(status) }
          }
      );
    }

    /// <summary>
    /// Payment types edit
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Response PaymentTypesEdit(Dictionary<string, object> type)
    {
      if (!type.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!type.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/payment-types/{type["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "paymentType", Newtonsoft.Json.JsonConvert.SerializeObject(type) }
          }
      );
    }

    /// <summary>
    /// Product statuses edit
    /// </summary>
    /// <param name="status"></param>
    /// <returns></returns>
    public Response ProductStatusesEdit(Dictionary<string, object> status)
    {
      if (!status.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!status.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      return Request.MakeRequest(
          $"/reference/product-statuses/{status["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "productStatus", Newtonsoft.Json.JsonConvert.SerializeObject(status) }
          }
      );
    }

    /// <summary>
    /// Sites edit
    /// </summary>
    /// <param name="site"></param>
    /// <returns></returns>
    public Response SitesEdit(Dictionary<string, object> site)
    {
      if (!site.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!site.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      if (!site.ContainsKey("url"))
      {
        throw new ArgumentException("Parameter `url` is missing");
      }

      return Request.MakeRequest(
          $"/reference/sites/{site["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "site", Newtonsoft.Json.JsonConvert.SerializeObject(site) }
          }
      );
    }

    /// <summary>
    /// Statuses edit
    /// </summary>
    /// <param name="status"></param>
    /// <returns></returns>
    public Response StatusesEdit(Dictionary<string, object> status)
    {
      if (!status.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!status.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      if (!status.ContainsKey("ordering"))
      {
        throw new ArgumentException("Parameter `ordering` is missing");
      }

      if (!status.ContainsKey("group"))
      {
        throw new ArgumentException("Parameter `group` is missing");
      }

      return Request.MakeRequest(
          $"/reference/statuses/{status["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "status", Newtonsoft.Json.JsonConvert.SerializeObject(status) }
          }
      );
    }

    /// <summary>
    /// Stores edit
    /// </summary>
    /// <param name="store"></param>
    /// <returns></returns>
    public Response StoresEdit(Dictionary<string, object> store)
    {
      if (!store.ContainsKey("code"))
      {
        throw new ArgumentException("Parameter `code` is missing");
      }

      if (!store.ContainsKey("name"))
      {
        throw new ArgumentException("Parameter `name` is missing");
      }

      List<string> types = new List<string>
            {
                "store-type-online",
                "store-type-retail",
                "store-type-supplier",
                "store-type-warehouse"
            };

      if (store.ContainsKey("type") && !types.Contains(store["type"].ToString()))
      {
        throw new ArgumentException("Parameter `type` should be equal to one of `store-type-online|store-type-retail|store-type-supplier|store-type-warehouse`");
      }

      return Request.MakeRequest(
          $"/reference/stores/{store["code"].ToString()}/edit",
          Request.MethodPost,
          new Dictionary<string, object>
          {
                    { "store", Newtonsoft.Json.JsonConvert.SerializeObject(store) }
          }
      );
    }
  }
}