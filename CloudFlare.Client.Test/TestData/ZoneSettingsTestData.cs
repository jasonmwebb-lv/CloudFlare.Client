﻿using System;
using System.Collections.Generic;
using System.Text;
using CloudFlare.Client.Api.Zones;
using CloudFlare.Client.Enumerators;

namespace CloudFlare.Client.Test.TestData
{
    public static class ZoneSettingsTestData
    {
        public static List<FeatureStatus> AlwaysUseHttpsValues { get; set; } = new()
        {
            FeatureStatus.Off, FeatureStatus.On
        };

        public static List<MinifySetting> MinifySettings { get; set; } = new()
        {
            new MinifySetting
            {
                Html = FeatureStatus.Off,
                Css = FeatureStatus.Off,
                Js = FeatureStatus.Off
            },
            new MinifySetting
            {
                Html = FeatureStatus.On,
                Css = FeatureStatus.On,
                Js = FeatureStatus.On
            }
        };

        public static List<BrowserCacheTTLSetting> BrowserCacheTTLSettings { get; set; } = new()
        {
            new BrowserCacheTTLSetting
            {
                Id = "browser_cache_ttl",
                Value = 0,
                Editable = true,
                ModifiedOn = DateTime.Now,
            },
            new BrowserCacheTTLSetting
            {
                Id = "browser_cache_ttl",
                Value = 30,
                Editable = true,
                ModifiedOn = DateTime.UtcNow,
            }
        };
    }
}
