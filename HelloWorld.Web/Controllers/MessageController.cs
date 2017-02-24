using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;
using HelloWorld.Repo;

namespace HelloWorld.Web.Controllers
{
    public class MessageController : ApiController
    {
        private readonly IMessageRepo _messageRepo;

        public MessageController()
        {
            _messageRepo = new MessageRepo();
        }

        
        public IHttpActionResult Get()
        {
            return Ok(_messageRepo.GetMessage());
        }
    }
}
