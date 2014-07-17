﻿using System;
using Thinktecture.IdentityServer.Core.Configuration;

namespace Thinktecture.IdentityServer.WsFederation.Configuration
{
    public class WsFederationPluginOptions
    {
        public const string CookieName = "IdSvr.WsFedTracking";

        public string LogoutUrl
        {
            get
            {
                return MapPath + "/signout";
            }
        }
        public WsFederationServiceFactory Factory { get; set; }
        public IDataProtector DataProtector { get; set; }

        public string MapPath { get; set; }

        public WsFederationPluginOptions()
        {
            MapPath = "/wsfed";
        }

        public void Validate()
        {
            if (Factory == null)
            {
                throw new ArgumentNullException("Factory");
            }
            if (DataProtector == null)
            {
                throw new ArgumentNullException("DataProtector");
            }
        }
    }
}