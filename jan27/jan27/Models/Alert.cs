using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jan27.Models
{
    public class Alert
    {
        public const string AlertKey = "TempDataAlerts";
        public string Message { get; set; }
        public string Debug { get; set; }
    }
}