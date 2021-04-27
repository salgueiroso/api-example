using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace api_example
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroCOntroller : ControllerBase
    {
        private readonly DbContextApp _ctx;
        public CadastroCOntroller(DbContextApp ctx)
        {
            this._ctx = ctx;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _ctx.Entidades.Add(new Entidade
            {
                Valor = Faker.Name.FullName(Faker.NameFormats.WithPrefix)
            });

            _ctx.SaveChanges();

            return _ctx.Entidades.OrderByDescending(e => e.Id).Select(e => e.Valor).ToList();
        }

    }
}


