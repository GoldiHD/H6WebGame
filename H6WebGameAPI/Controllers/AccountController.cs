using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H6WebGameAPI.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using H6WebGameAPI.Tools;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace H6WebGameAPI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [Route("api/auth/login/")]
        public ActionResult<string> GetAuthToken(User LoginData)
        {
            foreach(User element in SingleTon.GetSQLAccessor().GetUser())
            {
                if(element.username == LoginData.username)
                {
                    if (SingleTon.GetCryptoHashing().VerifyHash(LoginData.password, element.password))
                    {
                        Claim[] claims = new[] { new Claim(JwtRegisteredClaimNames.Sub, element.userID) };
                        SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SingleTon.readSetting("secret")));
                        string Algo = SecurityAlgorithms.HmacSha256;
                        SigningCredentials signingCredentials = new SigningCredentials(key, Algo);

                        JwtSecurityToken token = new JwtSecurityToken(SingleTon.readSetting("issuer"), SingleTon.readSetting("audiance"), claims, notBefore: DateTime.Now, expires: DateTime.Now.AddDays(1), signingCredentials);
                        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                    }
                }
            }
            return BadRequest();
        }

        [Route("api/auth/createaccount/")]
        public ActionResult CreateAccount(User newAccount)
        {
            foreach(User element in SingleTon.GetSQLAccessor().GetUser())
            {
                if(element.username == newAccount.username)
                {
                    return BadRequest();
                }
            }
            SingleTon.GetSQLAccessor().CreateAccount(newAccount);
            return Ok();
        }
    }
}
