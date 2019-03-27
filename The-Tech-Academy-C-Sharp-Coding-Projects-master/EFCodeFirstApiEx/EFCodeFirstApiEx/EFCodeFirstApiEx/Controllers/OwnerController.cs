using System;
using Microsoft.AspNetCore.Mvc;
using Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCodeFirstApiEx.Controllers
{
    [Route("api/[owner]")]
    public class OwnerController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public OwnerController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //[HttpGet("{id}")]
        //public IActionResult GetOwnerById(Guid id)
        //{
        //    try
        //    {
        //        var owner = _repository.Owner.GetOwnerById(id);

        //        if (owner.Id.Equals(Guid.Empty))
        //        {
        //            _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //            return NotFound();
        //        }
        //        else
        //        {
        //            _logger.LogInfo($"Returned owner with id: {id}");
        //            return Ok(owner);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        //[HttpGet("{id}")]
        //public iactionresult getownerbyid(guid id)
        //{
        //    try
        //    {
        //        var owner = _repository.owner.getownerbyid(id);

        //        if (owner == null)
        //        {
        //            _logger.logerror($"owner with id: {id}, hasn't been found in db.");
        //            return notfound();
        //        }
        //        else
        //        {
        //            _logger.loginfo($"returned owner with id: {id}");
        //            return ok(owner);
        //        }
        //    }
        //    catch (exception ex)
        //    {
        //        _logger.logerror($"something went wrong inside getownerbyid action: {ex.message}");
        //        return statuscode(500, "internal server error");
        //    }
        //}

        //[HttpGet("{id}/account")]
        //public IActionResult GetOwnerWithDetails(Guid id)
        //{
        //    try
        //    {
        //        var owner = _repository.Owner.GetOwnerWithDetails(id);

        //        if (owner.Id.Equals(Guid.Empty))
        //        {
        //            _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //            return NotFound();
        //        }
        //        else
        //        {
        //            _logger.LogInfo($"Returned owner with details for id: {id}");
        //            return Ok(owner);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside GetOwnerWithDetails action: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var owners = _repository.Owner.GetAllOwners();

                _logger.LogInfo($"Returned all owners from database.");

                return Ok(owners);
            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");

                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
