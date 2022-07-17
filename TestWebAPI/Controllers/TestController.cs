using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;
using TestWebAPI.ViewModel;


namespace TestWebAPI.Controllers
{
    public class TestController : ApiController
    {
        TestContext oTestContext = new TestContext();

        [HttpGet]
        [Route("api/Test/GetProduct")]
        public IHttpActionResult GetProduct()
        {
            var Productresult = oTestContext.Product.ToList();
            return Ok(Productresult);
        }
        [HttpGet]
        [Route("api/Test/GetCategory")]
        public IHttpActionResult GetCategory()
        {
            var Categoryresult = oTestContext.Category.ToList();
            return Ok(Categoryresult);
        }
        [HttpPost]
        [Route("api/Test/CreateCategory")]
        public IHttpActionResult CreateCategory(Category category)
        {
            oTestContext.Category.Add(category);
            var result = oTestContext.SaveChanges();
            if (result == 1)
                return Ok(category);
            else
                return InternalServerError();
        }
        [HttpPost]
        [Route("api/Test/CreateProduct")]
        public IHttpActionResult CreateProduct(Product Product)
        {
            oTestContext.Product.Add(Product);
            var result = oTestContext.SaveChanges();
            if (result == 1)
                return Ok(Product);
            else
                return InternalServerError();
        }
        [HttpDelete]
        [Route("api/Test/DeleteCategory/{Id:long}")]
        public IHttpActionResult DeleteCategory(long Id)
        {
            var Categoryresult = oTestContext.Category.Where(x => x.Id == Id).FirstOrDefault();
            oTestContext.Category.Remove(Categoryresult);
            var result = oTestContext.SaveChanges();
            if (result == 1)
                return Ok(Categoryresult);
            else
                return InternalServerError();
        }
        [HttpPost]
        [Route("api/Test/Addition")]
        public IHttpActionResult Addition(receiveData receiveData)
        {
            if (receiveData != null)
            {
                var num1 = receiveData.num1;
                var num2 = receiveData.num2;
                var result = num1 + num2;
                return Ok(result);
            }
            return InternalServerError();
        }

    }
}
