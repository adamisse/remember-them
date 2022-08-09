using Api.Services.Reminders;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/reminders")]
    public class ReminderController : ControllerBase
    {
        public ReminderController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IGetReminderHandler handler)
        {
            try
            {
                var result = await handler.QueryHandle();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReminderCommand command, [FromServices] ICreateReminderHandler handler)
        {
            try
            {
                await handler.Handle(command);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}