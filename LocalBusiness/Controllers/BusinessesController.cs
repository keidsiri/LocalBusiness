using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusiness.Models;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessContext _db;

    public BusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    // GET api/Businesses (Search parameter: type,location and rating)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string type, string location, int rating, string sortBy)
    {
      var query = _db.Businesses.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (rating != 0 )
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if (sortBy != null)
      {
        if ( sortBy == "rating")
        {
        query = query.OrderByDescending(entry => entry.Rating);
        }
        if (sortBy == "type")
        {
          query = query.OrderBy(entry => entry.Type);
        }
        if (sortBy == "location")
        {
          query = query.OrderBy(entry => entry.Location);
        }  
      }

      return await query.ToListAsync();
    }


    // GET: api/businesses/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
        var business = await _db.Businesses.FindAsync(id);

        if (business == null)
        {
            return NotFound();
        }

        return business;
    }

    // POST api/Businesses
    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    // PUT: api/business/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
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

    // DELETE: api/Businesses/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }
  }
}