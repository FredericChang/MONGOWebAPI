using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MONGOWebAPI.Models
{
    public class EditMemberResponse
    {
        public bool oK { get; set; }
        public string errMsg { get; set; }

        public EditMemberResponse()
        {
            this.oK = true;
            this.errMsg = "";
        }
    }
}