using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseModelAndController.Models.BaseModels
{
    public class Site : BaseModel
    {
        public int SiteID { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
    }
}