using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Account Get()
        {
            return new Account {
                id = 2,
                title = "Mr.",
                firstName = "Lucas",
                lastName = "Werner",
                email = "lucas@werner.wtf",
                role = "god",
                createdAt = new DateTime(),
                updatedAt = new DateTime(),
                isVerified = true
            };
        }
    }
}
