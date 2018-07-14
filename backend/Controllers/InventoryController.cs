using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fidget_spinner_lab
{
    [Route("inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private StoreContext _context;

        public InventoryController(StoreContext context)
        {
            _context = context;
        }


        // GET api
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            if (_context.store_inventory.ToList().Count == 0)
            {
                return NotFound();
            }
            return Ok(_context.store_inventory.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Store_Inventory store = _context.store_inventory.Where(c => c.store_id == id).FirstOrDefault();

            if (store == null)
            {
                return NotFound();
            }
            return Ok(store);

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Store_Inventory inventory)
        {
            if (inventory == null)
            {
                return NotFound();
            }
            _context.store_inventory.Add(inventory);
            _context.SaveChanges();
            return Ok(inventory);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Store_Inventory inventory)
        {
            Store_Inventory delete = _context.store_inventory.Where(c => c.store_id == id).FirstOrDefault();
            if (inventory == null || delete == null)
            {
                return NotFound();
            }

            _context.store_inventory.Remove(delete);
            _context.store_inventory.Add(inventory);
            _context.SaveChanges();

            return Ok(inventory);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Store_Inventory delete = _context.store_inventory.Where(c => c.store_id == id).FirstOrDefault();
            _context.store_inventory.Remove(delete);
            _context.SaveChanges();
            return Ok(delete);
        }
    }
}
