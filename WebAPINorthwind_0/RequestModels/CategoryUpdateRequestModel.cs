using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINorthwind_0.RequestModels
{
    public class CategoryUpdateRequestModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
       

    }
}