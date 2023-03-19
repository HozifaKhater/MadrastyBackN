using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AbsenceCaseController : ControllerBase
    {
        private readonly IAbsenseCaseService _service;
        private readonly IAbsenceCaseDetailsService _detailsService;

        public AbsenceCaseController(IAbsenseCaseService service, IAbsenceCaseDetailsService detailsService)
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
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetDetailsById(int id)
        {
            return Ok(await _detailsService.GetById(id));
        }

        [HttpGet("absenceCaseId")]
        public async Task<IActionResult> GetDetailsByAbsenceCaseId(int absenceCaseId)
        {
            return Ok(await _detailsService.GetByAbsenceCaseId(absenceCaseId));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AbsenceCaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPost]
        public async Task<IActionResult> SaveDetails([FromBody] AbsenceCaseDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _detailsService.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AbsenceCaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDetails([FromBody] AbsenceCaseDetailsViewModel model)
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
        public async Task<IActionResult> DeleteDetailsById(int id)
        {
            return Ok(await _detailsService.Delete(id));
        }

        [HttpDelete("absenceCaseid")]
        public async Task<IActionResult> DeleteByAbsenceCaseId(int absenceCaseid)
        {
            return Ok(await _detailsService.DeleteByAbsenceCaseId(absenceCaseid));
        }
    }
}
