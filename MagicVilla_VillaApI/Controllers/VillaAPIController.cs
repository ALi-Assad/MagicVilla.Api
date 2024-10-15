using MagicVilla_VillaApI.Data;
using MagicVilla_VillaApI.Logging;
using MagicVilla_VillaApI.Models;
using MagicVilla_VillaApI.Models.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController(ILogging logger, ApplicationDBContext dBContext) : ControllerBase
    {
        private readonly ILogging _logger = logger;
        private readonly ApplicationDBContext _dbContext = dBContext;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return Ok(_dbContext.Villas.ToList());
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDto))] when use ActionResult as it without general type

        public ActionResult<VillaDto> GetVilla(int id)
        {
            _logger.Log("test log");
            if (id <= 0)
            {
                _logger.Log("test log", "error");
                return BadRequest();
            }
            var villa = _dbContext.Villas.FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }


        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> AddVilla([FromBody] VillaDto villaDto)
        {

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (VillaStore.VillaList.FirstOrDefault(v => v.Name.ToLower() == villaDto.Name.ToLower())  != null)
            //{
            //    ModelState.AddModelError("", "Name should be unique");
            //    return BadRequest(ModelState);
            //}

            if (villaDto == null)
            {
                return BadRequest(villaDto);
            }

            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Villa newVilla = new()
            {
                Name = villaDto.Name,
                Detials = villaDto.Details,
                Occupancy = villaDto.Occupancy,
                Sqft = villaDto.Sqft,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
                ImageUrl = villaDto.ImageUrl,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            _dbContext.Villas.Add(newVilla);
            _dbContext.SaveChanges();

            return CreatedAtRoute("GetVilla", new { id = newVilla.Id }, newVilla);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteVilla(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }

            var villa = _dbContext.Villas.AsNoTracking().FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            _dbContext.Villas.Remove(villa);
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDto VillaDto)
        {
            if (VillaDto == null || id == 0 || VillaDto.Id != id)
            {
                return BadRequest();
            }

            Villa newVilla = new()
            {
                Id = VillaDto.Id,
                Name = VillaDto.Name,
                Detials = VillaDto.Details,
                Occupancy = VillaDto.Occupancy,
                Sqft = VillaDto.Sqft,
                Rate = VillaDto.Rate,
                Amenity = VillaDto.Amenity,
                ImageUrl = VillaDto.ImageUrl,
                UpdatedDate = DateTime.Now,
            };

            _dbContext.Villas.Update(newVilla);
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDto> patchDto)
        {

            if (id == 0 || patchDto == null)
            {
                return BadRequest();
            }

            var villa = _dbContext.Villas.AsNoTracking().FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            VillaDto villaDto = new(
                villa.Id,
                villa.Name,
                villa.Sqft,
                villa.Occupancy,
                villa.Detials,
                villa.Rate,
                villa.ImageUrl,
                villa.Amenity
                );

            patchDto.ApplyTo(villaDto, ModelState);

            Villa newVilla = new()
            {
                Id = villaDto.Id,
                Name = villaDto.Name,
                Detials = villaDto.Details,
                Occupancy = villaDto.Occupancy,
                Sqft = villaDto.Sqft,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
                ImageUrl = villaDto.ImageUrl,
                UpdatedDate = DateTime.Now,
            };
            _dbContext.Villas.Update(newVilla);
            _dbContext.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();

        }

    }
}
