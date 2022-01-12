﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace MyTransportApp.Klassen
{
    public class IpAufruf
    {
        public static string GetUserLocationyByIp(string ip)
        {
            IpInfo ipInfo = new();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.Region;
        }
        public static string GetUserCoordinatesByIp(string ip)
        {
            IpInfo ipInfo = new();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.Loc;
        }
    }
}
