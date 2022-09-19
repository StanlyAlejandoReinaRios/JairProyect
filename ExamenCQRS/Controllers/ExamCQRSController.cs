using AutoMapper;
using ExamenCQRS.Library.Command;
using ExamenCQRS.Library.Models.Dto_s;
using ExamenCQRS.Library.Models.Entities;
using ExamenCQRS.Library.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamCQRSController : ControllerBase
    {
        private readonly IMediator _media;
        private readonly IMapper _mapper;

        public ExamCQRSController(IMediator media,IMapper mapper)
        {
            _media = media;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ExamenUsuarios>> UsuariosList()
        {
            return await _media.Send(new ExamenCQRSListQueries());
        }

        [HttpPost]

        public async Task<ExamenUsuarios> Add(ExamenUsuarioDTO usuarios)
        {
            var lol = _mapper.Map<ExamenUsuarios>(usuarios);
            return await _media.Send(new ExamenCQRSAddCommand(lol));
        }
    }
}
