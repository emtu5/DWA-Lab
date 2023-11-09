using AutoMapper;
using daw_lab4.ContextModels;
using daw_lab4.Models;
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
        public StiriController(StiriContext stiri, IMapper mapper)
        {
            _stiriContext = stiri;
            _mapper = mapper;
        }

        [HttpGet]
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
        }

        [HttpGet("{id}")]
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
        }

        [HttpPost]
        public ActionResult<Stire> AddStire(Stire s)
        {
            _stiriContext.Stire.Add(s);
            _stiriContext.SaveChanges();
            return Ok();
        }


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
