using EphemeralEnvironments.Domain.Models;
using EphemeralEnvironments.Domain.Models.Requests;
using EphemeralEnvironments.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EphemeralEnvironments.Domain.Controllers
{
    [ApiController]
    [Route("api/domain")]
    public class DomainController : ControllerBase
    {
        private readonly MongoRepository _mongoRepository;

        public DomainController(MongoRepository mongoRepository)
        {
            _mongoRepository = mongoRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateVibeRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var document = new CreateVibeDocument()
            {
                Payload = new CreateVibePayload()
                {
                    Type = "VibeCreated",
                    Value = request.Value,
                    TimeAdded = DateTime.Now,
                }
            };

            _mongoRepository.InsertDocument(document);

            return Ok();
        }
    }
}
