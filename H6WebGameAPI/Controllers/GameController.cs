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
    public class GameController : Controller
    {
        [HttpGet]
        [Route("api/game/getplayer")]
        public ActionResult<Player> Getplayer(string UserID)
        {
            return SingleTon.GetSQLAccessor().GetPlayer(UserID);
        }
    }
}
