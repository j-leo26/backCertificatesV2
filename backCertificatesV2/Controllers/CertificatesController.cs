using backCertificatesV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backCertificatesV2.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificateController : ControllerBase
    {
        private readonly DbAb0bdeTalentseedsContext _context;

        public CertificateController(DbAb0bdeTalentseedsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var certificates = await _context.TfaCertificates.ToListAsync();
            return Ok(certificates);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var certificate = await _context.TfaCertificates.FindAsync(id);
            if (certificate == null) return NotFound();
            return Ok(certificate);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TfaCertificate certificate)
        {
            _context.TfaCertificates.Add(certificate);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = certificate.CertificatesId }, certificate);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TfaCertificate certificate)
        {
            if (id != certificate.CertificatesId) return BadRequest();

            _context.Entry(certificate).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificateExists(id)) return NotFound();
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var certificate = await _context.TfaCertificates.FindAsync(id);
            if (certificate == null) return NotFound();

            _context.TfaCertificates.Remove(certificate);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool CertificateExists(int id)
        {
            return _context.TfaCertificates.Any(c => c.CertificatesId == id);
        }
    }
}

