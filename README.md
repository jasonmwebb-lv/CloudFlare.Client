# CloudFlare.Client

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=zgmode%40gmail.com&currency_code=USD&source=url)
[![Nuget](https://img.shields.io/nuget/v/CloudFlare.Client.svg)](https://www.nuget.org/packages/CloudFlare.Client/)
[![Nuget](https://img.shields.io/nuget/dt/Cloudflare.Client.svg)](https://www.nuget.org/packages/CloudFlare.Client/)
[![Codacy grade](https://img.shields.io/codacy/grade/0ad1b06d9bbd4c849715223677667ddf.svg)](#)
[![GitHub issues](https://img.shields.io/github/issues-raw/zingz0r/Cloudflare.Client.svg)](https://github.com/zingz0r/CloudFlare.Client/issues)
[![Licence](https://img.shields.io/badge/licanse-CC%20BY--NC--ND%204.0-yellowgreen.svg)](https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode.txt)

.NET client for communication with the CloudFlare service API.

## Install through nuget

```bash
    PM> Install-Package CloudFlare.Client -Version 1.1.0
```

## Usage

```csharp
    using (var client = new CloudFlareClient("address@example.com","globalApiKeyFromCF"))
    {
        var zones = client.GetZonesAsync().Result;

        foreach (var zone in zones.Result)
        {
            Console.WriteLine(zone.Name);
        }
    }
```

## Implemented functionality

### Zone

-   [x] List Zones
-   [x] Create Zone
-   [x] Zone Details
-   [x] Edit Zone
-   [x] Delete Zone
-   [ ] Zone Activation Check
-   [ ] Purge All Files
-   [ ] Purge Files by URL
-   [ ] Purge Files by Cache-Tags or Host  

### DNS Records for a Zone

-   [x] List DNS Records
-   [x] Create DNS Record
-   [x] DNS Record Details
-   [x] Update DNS Record
-   [x] Delete DNS Record
-   [x] Import DNS Records
-   [x] Export DNS Records