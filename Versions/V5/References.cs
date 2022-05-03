﻿using System;
using System.Collections.Generic;


namespace RetailCRMCore.Versions.V5
{
    public partial class Client
    {
        /// <summary>
        /// Costs groups
        /// </summary>
        /// <returns></returns>
        public Response CostGroups()
        {
            return Request.MakeRequest(
                "/reference/cost-groups",
                Request.MethodGet
            );
        }

        /// <summary>
        /// Costs
        /// </summary>
        /// <returns></returns>
        public Response CostItems()
        {
            return Request.MakeRequest(
                "/reference/cost-items",
                Request.MethodGet
            );
        }

        /// <summary>
        /// Legal entities
        /// </summary>
        /// <returns></returns>
        public Response LegalEntities()
        {
            return Request.MakeRequest(
                "/reference/legal-entities",
                Request.MethodGet
            );
        }

        /// <summary>
        /// Cost group edit
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public Response CostGroupsEdit(Dictionary<string, object> group)
        {
            if (!group.ContainsKey("code"))
            {
                throw new ArgumentException("Parameter `code` is missing");
            }

            if (!group.ContainsKey("name"))
            {
                throw new ArgumentException("Parameter `name` is missing");
            }

            if (!group.ContainsKey("color"))
            {
                throw new ArgumentException("Parameter `color` is missing");
            }

            return Request.MakeRequest(
                $"/reference/cost-groups/{@group["code"]}/edit",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "costGroup", Newtonsoft.Json.JsonConvert.SerializeObject(group) }
                }
            );
        }

        /// <summary>
        /// Cost items edit
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Response CostItemsEdit(Dictionary<string, object> item)
        {
            if (!item.ContainsKey("code"))
            {
                throw new ArgumentException("Parameter `code` is missing");
            }

            if (!item.ContainsKey("name"))
            {
                throw new ArgumentException("Parameter `name` is missing");
            }

            if (!item.ContainsKey("group"))
            {
                throw new ArgumentException("Parameter `group` is missing");
            }

            List<string> types = new List<string>
            {
                "const",
                "var"
            };

            if (item.ContainsKey("type") && !types.Contains(item["type"].ToString()))
            {
                throw new ArgumentException("Parameter `type` should be one of `const|var`");
            }

            return Request.MakeRequest(
                $"/reference/cost-items/{item["code"]}/edit",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "costItem", Newtonsoft.Json.JsonConvert.SerializeObject(item) }
                }
            );
        }

        /// <summary>
        /// Legal entities edit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Response LegalEntitiesEdit(Dictionary<string, object> entity)
        {
            if (!entity.ContainsKey("code"))
            {
                throw new ArgumentException("Parameter `code` is missing");
            }

            if (!entity.ContainsKey("legalName"))
            {
                throw new ArgumentException("Parameter `legalName` is missing");
            }

            if (!entity.ContainsKey("countryIso"))
            {
                throw new ArgumentException("Parameter `countryIso` is missing");
            }

            if (!entity.ContainsKey("contragentType"))
            {
                throw new ArgumentException("Parameter `contragentType` is missing");
            }

            return Request.MakeRequest(
                $"/reference/legal-entities/{entity["code"]}/edit",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "legalEntity", Newtonsoft.Json.JsonConvert.SerializeObject(entity) }
                }
            );
        }

        /// <summary>
        /// Couriers list
        /// </summary>
        /// <returns></returns>
        public Response Couriers()
        {
            return Request.MakeRequest(
                "/reference/couriers",
                Request.MethodGet
            );
        }

        /// <summary>
        /// Create a courier
        /// </summary>
        /// <param name="courier"></param>
        /// <returns></returns>
        public Response CouriersCreate(Dictionary<string, object> courier)
        {
            return Request.MakeRequest(
                "/reference/couriers/create",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "courier", Newtonsoft.Json.JsonConvert.SerializeObject(courier) }
                }
            );
        }

        /// <summary>
        /// Edit a courier
        /// </summary>
        /// <param name="courier"></param>
        /// <returns></returns>
        public Response CouriersEdit(Dictionary<string, object> courier)
        {
            if (!courier.ContainsKey("id"))
            {
                throw new ArgumentException("Parameter `id` is missing");
            }

            return Request.MakeRequest(
                $"/reference/couriers/{courier["id"]}/edit",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "courier", Newtonsoft.Json.JsonConvert.SerializeObject(courier) }
                }
            );
        }
    }
}
