using Fuelled.ClientTracker.Api.Data;
using Fuelled.ClientTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fuelled.ClientTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ClientTrackerDbContext _context;

        public ClientsController(ClientTrackerDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        //Endpoint for retrieving all clients
        // This method handles GET requests to "api/clients"
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            try
            {
                var clients = await _context.Clients.ToListAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                // This will help you see database errors if they occur
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost]
        // Endpoint for adding a new client
        // This method handles POST requests to "api/clients"
        public async Task<ActionResult<Client>> AddClient([FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            // Return a 201 Created response with the new client object
            return CreatedAtAction(nameof(GetClients), new { id = client.Id }, client);
        }

        [HttpGet("{id}")]
        // Endpoint for retrieving a specific client by ID
        // This method handles GET requests to "api/clients/{id}"
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        [HttpPut("{id}")]
        // Endpoint for updating a client
        // This method handles PUT requests to "api/clients/{id}"
        public async Task<IActionResult> UpdateClient(int id, [FromBody] Client client)
        {
            if (id != client.Id)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Clients.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        // Endpoint for deleting a client
        // This method handles DELETE requests to "api/clients/{id}"
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}