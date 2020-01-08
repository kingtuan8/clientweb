using clientweb.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clientweb.Models
{
    public class DetailViewModel
    {
        public WEB_Thread Thread { get; set; }
        public List<WEB_Thread> LatesPost { get; set; }
    }
}