using AutoMapper;
using daw_lab4.ContextModels;
using daw_lab4.Models;
using daw_lab4.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace daw_lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StiriController : ControllerBase
    {
        private readonly StiriContext _stiriContext;
        private readonly IMapper _mapper;
        private readonly INewsRepository _repository;
        public StiriController(StiriContext stiri, IMapper mapper, INewsRepository repository)
        {
            _stiriContext = stiri;
            _mapper = mapper;
            _repository = repository;
        }

        /*[HttpGet]
        public IQueryable<GetStireDto> Index()
        {
            var stiri = _stiriContext.Stire.Select(s => new GetStireDto()
            {
                Titlu = s.Titlu,
                Lead = s.Lead,
                Continut = s.Continut,
                Autor = s.Autor,
                CategorieId = s.CategorieId
            });
                 
            return stiri;
        }*/

        [HttpGet]
        public async Task<ActionResult<List<GetStireDto>>> IndexAsync()
        {
            var stiri = _mapper.Map<List<GetStireDto>>(await _repository.GetStiriAsync());
            if (stiri == null)
            {
                return NotFound();
            }


            return stiri;
        }


        /*[HttpGet("{id}")]
        public ActionResult<GetStireDto> Detalii(int id)
        {
            var Stire = _stiriContext.Stire.Find(id);
            if(Stire == null)
            {
                return NotFound();
            }
            else
            {
                return _mapper.Map<GetStireDto>(Stire);
            }
        }*/

        [HttpGet("{id}/{includeCategories}")]
        public async Task<ActionResult> Detalii(int id, bool includeCategories)
        {
            var Stire = await _repository.GetStireAsync(id, includeCategories);
            if (Stire == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Stire);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Stire>> AddStire(PostStireDto s)
        {
            var Stire = await _repository.PostAsync(_mapper.Map<Stire>(s));
            return Ok(Stire);
        }

        //TODO: change these to DTO's
        [HttpPut("{id}")]
        public ActionResult<Stire> PutStire(int id, string titlu)
        {
            var Stire = _stiriContext.Stire.Find(id);
            if (Stire == null)
            {
                return NotFound();
            }
            else
            {
                Stire.Titlu = titlu;
                _stiriContext.SaveChanges();
                return Stire;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Stire> DeleteStire(int id)
        {
            var Stire = _stiriContext.Stire.Find(id);
            if (Stire == null)
            {
                return NotFound();
            }
            else
            {
                _stiriContext.Stire.Remove(Stire);
                _stiriContext.SaveChanges();
                return Stire;
            }
        }
    }
}
