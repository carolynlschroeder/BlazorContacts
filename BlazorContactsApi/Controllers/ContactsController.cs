using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorContactsApi;
using BlazorContactsApi.Data;

namespace BlazorContactsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsContext _context;

        public ContactsController(ContactsContext context)
        {
            _context = context;
        }

        // GET: /Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
            return await _context.Contacts.ToListAsync();
        }

        // GET: /Contacts/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}", Name = "GetContact")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public IActionResult Put(int id, [Microsoft.AspNetCore.Mvc.FromBody] Contact contact)
        {
            if (contact == null || contact.Id != id)
            {
                return BadRequest();
            }

            if (_context.Contacts.AsNoTracking().FirstOrDefault(c => c.Id == id) == null)
            {
                return NotFound();
            }

            try
            {
                var entry = _context.Entry(contact);
                entry.State = EntityState.Modified;
                _context.SaveChanges();
                return new NoContentResult();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Post([Microsoft.AspNetCore.Mvc.FromBody] Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }

            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                return CreatedAtRoute("GetContact", new { id = contact.Id }, contact);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE: /Contacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
