using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobMasterController : ControllerBase
    {
        private readonly IJobMasterService _service;
        private readonly IJobDetailsService _detailsService;


        public JobMasterController(IJobMasterService service, IJobDetailsService detailsService)
        {
            _service = service;
            _detailsService = detailsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet]
        public async Task<IActionResult> GetDetails()
        {
            return Ok(await _detailsService.Get());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("jobId")]
        public async Task<IActionResult> GetEmpWithJobId(int jobId)
        {
            return Ok(await _service.GetEmpWithJobId(jobId));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetDetailsById(int id)
        {
            return Ok(await _detailsService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] JobMasterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPost]
        public async Task<IActionResult> SaveDetails([FromBody] JobDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _detailsService.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] JobMasterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDetails([FromBody] JobDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _detailsService.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteDetails(int id)
        {
            return Ok(await _detailsService.Delete(id));
        }



    }
}
