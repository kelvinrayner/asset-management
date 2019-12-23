using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using API.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        AccountService _accountService = new AccountService();

        // GET: api/Accounts
        [HttpGet]
        public IActionResult Get()
        {
            var data = _accountService.Get();
            if(data == null)
            {
                return NotFound("No Data Found");
            }
            return Ok(data);
        }

        // GET: api/Accounts/5
        [HttpGet("{username}/{password}", Name = "GetAccounts")]
        public IActionResult Get(string username, string password)
        {
            var data = _accountService.GetAccount(username, password);
            if (data == null)
            {
                return NotFound("No Data Found");
            }
            return Ok(data);
        }

        // POST: api/Accounts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Accounts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
