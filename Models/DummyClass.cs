using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication35.Models
{
    public class DummyClass
    {      
        public string Status { get; set; }
        public string Message { get; set; }
        
        public List<IdName> data { get; set; }
    }
    public class IdName
    {
        public string Name;

        public string Address;
    }
}