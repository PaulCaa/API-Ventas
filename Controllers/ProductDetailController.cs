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
    public class ProductDetailController : ControllerBase{

        private ProductDetailRepositoryMock RepositoryMock;

        public ProductDetailController(){
            this.RepositoryMock = new ProductDetailRepositoryMock();
        }

        [HttpGet("/api/detail/all")]
        public RestResponse GetAllDetails(){
            RestResponse response;
            try{
                List<ProductDetail> result = RepositoryMock.GetAllDetails();
                response = new RestResponse(result);
                response.Header = RestUtil.GenerateHeaderOk("'GET_/api/detail/all'");
                return response;
            }catch(Exception exception){
                response = new RestResponse();
                Error error = new Error(exception.GetType().ToString(), exception.Message, exception);
                response.Header = RestUtil.GenerateHeaderError(error,"'GET_/api/detail/all'");
                return response;
            }
        }

        [HttpGet("/api/detail/{id:int?}")]
        public RestResponse GetProductDetailBy(int? id){
            RestResponse response;
            try{
                if(id < 1 || id == null){
                    throw new BadRequestParameterException("El Id ingresado es incorrecto");
                }
                ProductDetail detail = RepositoryMock.GetDetailBy(id.Value);
                response = new RestResponse(detail);
                response.Header = RestUtil.GenerateHeaderOk("'GET_/api/detail/" + id.Value + "'");
                return response;
            }catch(Exception exception){
                response = new RestResponse();
                Error error = new Error(exception.GetType().ToString(), exception.Message, exception);
                response.Header = RestUtil.GenerateHeaderError(error,"'GET_/api/detail/" + id.Value + "'");
                return response;
            }
        }

        [HttpPost("/api/detail/add")]
        public RestResponse AddProductDetail(ProductDetail detail){
            RestResponse response;
            try{
                ProductDetail result = RepositoryMock.AddDetail(detail);
                response = new RestResponse(result);
                response.Header = RestUtil.GenerateHeaderOk("'POST_/api/detail/add'");
                return response;
            }catch(Exception exception){
                response = new RestResponse();
                Error error = new Error(exception.GetType().ToString(), exception.Message, exception);
                response.Header = RestUtil.GenerateHeaderError(error,"'POST_/api/detail/add'");
                return response;
            }
        }

        [HttpPut("/api/detail/update")]
        public RestResponse UpdateProductDetail(ProductDetail detail){
            RestResponse response;
            try{
                ProductDetail result = RepositoryMock.UpdateDetail(detail);
                if(result == null) throw new RepositoryOperationException("No se realizo actualizacion en repositorio");
                response = new RestResponse(result);
                response.Header = RestUtil.GenerateHeaderOk("'PUT_/api/detail/update'");
                return response;
            }catch(Exception exception){
                response = new RestResponse();
                Error error = new Error(exception.GetType().ToString(), exception.Message, exception);
                response.Header = RestUtil.GenerateHeaderError(error,"'PUT_/api/detail/update'");
                return response;
            }
        }
    }
}