using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPINorthwind_0.Models;

namespace WebAPINorthwind_0.ResponseModels
{
    //API icerisindeki Response modellerde kompleks yapılar barındıran bir Response Model olusturmamaya cok dikkat ediniz...Serialize konusunda sorun yasanır...
    public class CategoryResponseModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

     


    }
}