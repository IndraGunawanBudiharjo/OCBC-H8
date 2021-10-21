using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentDetails.Data;
using PaymentDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace PaymentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentDetailController : ControllerBase
    {

        private readonly ApiDbContext _context;

        public PaymentDetailController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var PaymentDetails = await _context.PaymentDetail.ToListAsync();
            return Ok(PaymentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(PaymentDetail data)
        {
            if (ModelState.IsValid)
            {
                await _context.PaymentDetail.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.PaymentDetailId }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{PaymentDetailId}")]
        public async Task<IActionResult> GetItem(int PaymentDetailId)
        {
            var PaymentDetail = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.PaymentDetailId == PaymentDetailId);

            if (PaymentDetail == null)
                return NotFound();

            return Ok(PaymentDetail);
        }

        [HttpPut("{PaymentDetailId}")]
        public async Task<IActionResult> UpdateItem(int PaymentDetailId, PaymentDetail paymentDetail)
        {
            if (PaymentDetailId != paymentDetail.PaymentDetailId)
                return BadRequest();

            var existItem = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.PaymentDetailId == PaymentDetailId);

            if (existItem == null)
                return NotFound();

            existItem.CardOwnerName = paymentDetail.CardOwnerName;
            existItem.CardNumber = paymentDetail.CardNumber;
            existItem.ExpirationDate = paymentDetail.ExpirationDate;
            existItem.SecurityCode = paymentDetail.SecurityCode;

            // Implement the changes on the database level
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{PaymentDetailId}")]
        public async Task<IActionResult> DeleteItem(int PaymentDetailId)
        {
            var existItem = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.PaymentDetailId == PaymentDetailId);

            if (existItem == null)
                return NotFound();

            _context.PaymentDetail.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}
