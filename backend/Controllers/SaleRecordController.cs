using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fidget_spinner_lab
{
    [Route("records")]
    [ApiController]
    public class SaleRecordController : ControllerBase
    {

        private StoreContext _context;

        public SaleRecordController(StoreContext context)
        {
            _context = context;
        }


        // GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            if (_context.sales_records.ToList().Count == 0)
            {
                return NotFound();
            }
            return Ok(_context.sales_records.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Sale_Record store = _context.sales_records.Where(c => c.store_id == id).FirstOrDefault();

            if (store == null)
            {
                return NotFound();
            }
            return Ok(store);

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Sale_Record inventory)
        {
            if (inventory == null)
            {
                return NotFound();
            }
            _context.sales_records.Add(inventory);
            _context.SaveChanges();
            return Ok(inventory);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Sale_Record sale)
        {
            Sale_Record delete = _context.sales_records.Where(c => c.sale_id == id).FirstOrDefault();
            if (sale == null || delete == null)
            {
                return NotFound();
            }

            _context.sales_records.Remove(delete);
            _context.sales_records.Add(sale);
            _context.SaveChanges();

            return Ok(sale);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Sale_Record delete = _context.sales_records.Where(c => c.store_id == id).FirstOrDefault();
            _context.sales_records.Remove(delete);
            _context.SaveChanges();
            return Ok(delete);
        }
    }
}
