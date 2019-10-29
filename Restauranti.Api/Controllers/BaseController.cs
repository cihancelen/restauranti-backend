using System;
using Microsoft.AspNetCore.Mvc;

namespace Restauranti.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        public long GetApplicationUserId()
        {
            return 0;
        }
    }
}
