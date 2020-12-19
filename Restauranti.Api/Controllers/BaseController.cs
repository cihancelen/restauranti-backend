using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restauranti.BLL.Services.Abstract.Base;
using Restauranti.Dto.Models;
using Restauranti.Entities.Models.Authentication;

namespace Restauranti.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        private string GetCurrentToken()
        {
            var authorizationHeaders = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorizationHeaders)) return string.Empty;

            var header = authorizationHeaders.FirstOrDefault()?.Trim();
            if (!header.StartsWith("Bearer")) return string.Empty;

            var value = header.Substring("Bearer".Length).Trim();
            return !string.IsNullOrEmpty(value) ? value : string.Empty;
        }

        public int GetApplicationUserId()
        {
            string token = GetCurrentToken();

            if (!string.IsNullOrEmpty(token))
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(token);
                var tokenClaims = jwtSecurityToken.Claims;

                return int.Parse(tokenClaims.FirstOrDefault(r => r.Type.Equals("userId"))?.Value);
            }

            return 0;
        }
    }

    public class BaseController<IService, Dto> : BaseController
        where IService : IBaseService<Dto>
        where Dto : IDto
    {
        private readonly IService _service;

        public BaseController(IService service)
        {
            _service = service;
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public virtual async Task<Dto> GetById(long id) => await _service.GetById(id);

        [Route("GetAll")]
        [HttpGet]
        public virtual async Task<List<Dto>> GetAll() => await _service.GetAll(x => x.IsActive);

        [Route("Create")]
        [HttpPost]
        public virtual async Task<Dto> Create(Dto dto) => await _service.Create(dto);

        [Route("Update")]
        [HttpPut]
        public virtual async Task<Dto> Update(Dto dto) => await _service.Update(dto);

        [Route("Remove")]
        [HttpDelete]
        public virtual async Task<bool> Remove(Dto dto) => await _service.Remove(dto);
    }
}
