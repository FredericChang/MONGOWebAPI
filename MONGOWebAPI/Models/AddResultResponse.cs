using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MONGOWebAPI.Models
{
    public class AddResultResponse
    {
        public bool oK { get; set; }
        public string errMsg { get; set; }

        public AddResultResponse()
        {
            this.oK = true;
            this.errMsg = "";
        }
        
    }
}