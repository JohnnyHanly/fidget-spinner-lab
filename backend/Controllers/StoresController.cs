using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fidget_spinner_lab
{
    [Route("stores")]
    [ApiController]
    public class StoresController : ControllerBase
    {

        private StoreContext _context;

        public StoresController(StoreContext context)
        {
            _context = context;
        }


        // GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            if (_context.stores.ToList().Count == 0)
            {
                return NotFound();
            }
            return Ok(_context.stores.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Store store = _context.stores.Where(c => c.store_id == id).FirstOrDefault();

            if (store == null)
            {
                return NotFound();
            }
            return Ok(store);

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Store store)
        {
            if (store == null)
            {
                return NotFound();
            }
            _context.stores.Add(store);
            _context.SaveChanges();
            return Ok(store);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Store store)
        {
            Store delete = _context.stores.Where(c => c.store_id == id).FirstOrDefault();
            if (store == null || delete == null)
            {
                return NotFound();
            }

            _context.stores.Remove(delete);
            _context.stores.Add(store);
            _context.SaveChanges();

            return Ok(store);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Store delete = _context.stores.Where(c => c.store_id == id).FirstOrDefault();
            _context.stores.Remove(delete);
            _context.SaveChanges();
            return Ok(delete);
        }
    }
}
