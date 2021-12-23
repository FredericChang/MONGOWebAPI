using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MONGOWebAPI.Models
{
    public class MemberCollection
    {

        public ObjectId id { get; set; }

        public string uid { get; set; }
        
        public string name { get; set; }

        public string phone { get; set; }

    }
}