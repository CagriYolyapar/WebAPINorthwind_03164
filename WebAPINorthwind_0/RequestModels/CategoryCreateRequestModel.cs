using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINorthwind_0.RequestModels
{
    //Kullanıcı bir Kategori eklemek icin  nasıl bir veri göndermeli bunu tasarlıyoruz
    public class CategoryCreateRequestModel
    {
      
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }
}