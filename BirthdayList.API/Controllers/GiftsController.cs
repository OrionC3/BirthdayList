using BirthdayList.API.Context;
using BirthdayList.API.Entities;
using BirthdayList.API.Mappers;
using BirthdayList.API.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftsController : ControllerBase
    {
        private readonly BirthdayListContext _context;

        public GiftsController(BirthdayListContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Add(GiftCreateDto gift)
        {
            var entity = gift.ToEntity();
            if(gift == null)
            {
                return BadRequest("Gift can't not empty.");
            }
            _context.Add(gift);
            _context.SaveChanges();
            return Ok();
        }
    }
}
