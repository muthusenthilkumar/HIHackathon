using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthWeb.Models
{
    public class Mission
    {
        public int MissionId { get; set; }

        public string Name { get; set; }

        public string VehicalName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ExpectedLaunchDate { get; set; }

        public string Details { get; set; }
    }
}