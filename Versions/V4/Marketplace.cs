﻿using System;
using System.Collections.Generic;


namespace RetailCRMCore.Versions.V4
{
    public partial class Client
    {
        /// <summary>
        /// Edit marketplace module settings
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public Response MarketplaceSettingsEdit(Dictionary<string, object> configuration)
        {
            if (configuration.Count < 1)
            {
                throw new ArgumentException("Parameter `configuration` must contain data");
            }

            if (!configuration.ContainsKey("code"))
            {
                throw new ArgumentException("Parameter `configuration` should contain `code`");
            }

            if (!configuration.ContainsKey("name"))
            {
                throw new ArgumentException("Parameter `configuration` should contain `name`");
            }

            return Request.MakeRequest(
                $"/marketplace/external/setting/{configuration["code"].ToString()}/edit",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "configuration", Newtonsoft.Json.JsonConvert.SerializeObject(configuration) }
                }
            );
        }
    }
}
