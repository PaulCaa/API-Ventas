using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ventas.Models;
using Ventas.Repository;

namespace Ventas.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerController : ControllerBase{
        private SellerRepositoryMock RepositoryMock;

        public SellerController()
        {
            this.RepositoryMock = new SellerRepositoryMock();
        }
    
        // GET: /api/seller
        [HttpGet]
        public List<Seller> GetAll(){
            return RepositoryMock.GetAllSellers();
        }

        // GET /api/seller/123
        [HttpGet("{id}")]
        public Seller GetById(int id)
        {
            Seller result = null;
            List<Seller> Sellers = RepositoryMock.GetAllSellers();
            foreach(Seller s in Sellers){
                if(s.Id == id)
                    result = s;
            }
            return result;
        }

        // GET: /api/seller/document/123456
        [HttpGet("/api/seller/document/{doc:int}")]
        //[ActionName("/document/{doc:int?}")]
        public Seller GetByDocument(int doc)
        {
            Seller result = null;
            List<Seller> Sellers = RepositoryMock.GetAllSellers();
            foreach(Seller s in Sellers){
                if(s.Document == doc.ToString())
                    result = s;
            }
            return result;
        }

    }
}
