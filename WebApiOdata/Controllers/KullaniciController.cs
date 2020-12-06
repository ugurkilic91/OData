using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiOdata.Entities;

namespace WebApiOdata.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly EFContext.EFContext _context;

        public KullaniciController(EFContext.EFContext context)
        {
            _context = context;
        }
        [HttpGet()]
        [EnableQuery()]
        public IQueryable<Kullanici> Get()
        {
            var s = _context.Kullanicis;
                return s;
                //var kullanicis = ct.Kullanicis.ToList();
                //return new ActionResult<IEnumerable<Kullanici>>(kullanicis);
            

        }
        [HttpGet("aa")]
        public async Task<IEnumerable<Kullanici>> get2()
        {
            


                _context.Add(new Kullanici { ID = 2, Adi = "Veli", Sehir = "İzmir" });
                await _context.SaveChangesAsync();
                var kullanicis = await _context.Kullanicis.ToListAsync();

                return kullanicis;
            
        }
    }
}
