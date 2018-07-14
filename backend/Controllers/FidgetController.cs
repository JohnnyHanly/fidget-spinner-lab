using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fidget_spinner_lab
{
    [Route("spinners")]
    [ApiController]
    public class FidgetController : ControllerBase
    {

        private StoreContext _context;

        public FidgetController(StoreContext context)
        {
            _context = context;
        }


        // GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            if (_context.fidget_spinners.ToList().Count == 0)
            {
                return NotFound();
            }
            return Ok(_context.fidget_spinners.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Fidget_Spinner spinner = _context.fidget_spinners.Where(c => c.fidget_id == id).FirstOrDefault();

            if (spinner == null)
            {
                return NotFound();
            }
            return Ok(spinner);

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Fidget_Spinner spinner)
        {
            if (spinner == null)
            {
                return NotFound();
            }
            _context.fidget_spinners.Add(spinner);
            _context.SaveChanges();
            return Ok(spinner);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Fidget_Spinner spinner)
        {
            Fidget_Spinner delete = _context.fidget_spinners.Where(c => c.fidget_id == id).FirstOrDefault();
            if (spinner == null || delete == null)
            {
                return NotFound();
            }

            _context.fidget_spinners.Remove(delete);
            _context.fidget_spinners.Add(spinner);
            _context.SaveChanges();

            return Ok(spinner);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Fidget_Spinner delete = _context.fidget_spinners.Where(c => c.fidget_id == id).FirstOrDefault();
            _context.fidget_spinners.Remove(delete);
            _context.SaveChanges();
            return Ok(delete);
        }
    }
}
