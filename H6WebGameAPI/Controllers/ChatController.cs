using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H6WebGameAPI.Entity;
using H6WebGameAPI.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H6WebGameAPI.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        [HttpGet]
        [Route("api/chat/send")]
        public ActionResult SendMessage(string userID, string message)
        {
            try
            {
                SingleTon.GetSQLAccessor().AddNewMessage(userID, message);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/chat/get")]
        public ActionResult<List<Message>> GetMessages(int id)
        {
            if(id < 0) //just get the newest
            {

            }
            else
            {

            }
            return Ok(new List<Message>());
        }
        //GetMessage(From ID)
    }
}
