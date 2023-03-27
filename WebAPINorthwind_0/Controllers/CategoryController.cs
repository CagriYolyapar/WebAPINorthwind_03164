using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPINorthwind_0.DesignPatterns.SingletonPattern;
using WebAPINorthwind_0.Models;
using WebAPINorthwind_0.ResponseModels;

namespace WebAPINorthwind_0.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities _db;


        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }

        //Veritabanına gidip Categories tablomuzdaki Kategorileri CategoryReponseModel tipinde almak istiyoruz...
        List<CategoryResponseModel> ListCategories()
        {
            return _db.Categories.Select(x => new CategoryResponseModel
            {
                ID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();
        }


        [HttpGet]
        public List<CategoryResponseModel> BringCategories()
        {
            return ListCategories();
        }

    }
}
