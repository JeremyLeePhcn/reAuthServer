using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReAuthServer.Dtos;
using ReAuthServer.Models;
using ReAuthServer.Services;

namespace ReAuthServer.Controllers
{
  
    [Route("api/submit_reauth_form")]
    [ApiController]
    public class ReAuthsContoller : ControllerBase
    {
        Services.ReAuthService reAuthService = new ReAuthService();
        private readonly IMapper _mapper;

        public ReAuthsContoller(IMapper mapper)
        {
            _mapper = mapper;
        }
        ReAuthService  _reauthService;

        [HttpPost] 
       public ActionResult <ReadReAuthFormDataDto> Post(CreateReAuthFormDataDto formData)
       {
           var reAuthModel = _mapper.Map<ReAuthFormData>(formData);
           var name = reAuthModel.Name;
           reAuthService.sayHello(name);
           return Ok(reAuthModel);
       }
        
    }
}