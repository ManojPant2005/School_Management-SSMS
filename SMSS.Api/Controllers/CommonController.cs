using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSS.Api.Models.Interface;

namespace SMSS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly ICommonService commonService;

        public CommonController(ICommonService commonService)
        {
            this.commonService = commonService;
        }

        [HttpGet]
        public async Task<ActionResult> GetStates()
        {
            try
            {
                return Ok(await commonService.GetStates());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while retriving the data from database");
            }
        }
    }
}
