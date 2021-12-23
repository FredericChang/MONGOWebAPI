using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MONGOWebAPI.Models
{
    public class GetMemberListResponse
    {
        public bool oK { get; set; }
        public string errMsg { get; set; }
        public List<MemberInfo> List{ get; set; }

        public GetMemberListResponse()
        {
            this.oK = true;
            this.errMsg = "";
            this.List = new List<MemberInfo> ();
        }
    }
    public class MemberInfo
    {
        public string uid { get; set; }

        public string name { get; set; }

        public string phone { get; set; }
    }
}