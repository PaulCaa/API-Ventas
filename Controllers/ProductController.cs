using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ventas.Models;
using Ventas.Models.Rest;
using Ventas.Repository;
using Ventas.Exceptions;
using Ventas.Utils;

namespace Ventas.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase{

        private ProductRepositoryMock RepositoryMock;

        public ProductController(){
            this.RepositoryMock = new ProductRepositoryMock();
        }

        [HttpGet("/api/product/category/{id:int?}")]
        public RestResponse GetProductByCategory(int? id){
            RestResponse response;
            try{
                if(id < 1 || id == null){
                    throw new BadRequestParameterException("El Id de categoria es incorrecto");
                }
                List<Product> products = RepositoryMock.GetProductsByCategory(id.Value);
                response = new RestResponse(products);
                response.Header = RestUtil.GenerateHeaderOk("'GET_/api/product/category/" + id.Value + "'");
                return response;
            }catch(Exception exception){
                response = new RestResponse();
                Error error = new Error(exception.GetType().ToString(), exception.Message, exception);
                response.Header = RestUtil.GenerateHeaderError(error,"'GET_/api/product/category/" + id.Value + "'");
                return response;
            }
        }


    }
}