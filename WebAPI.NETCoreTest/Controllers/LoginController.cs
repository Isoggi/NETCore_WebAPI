using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.NETCoreTest.Models;
using WebAPI.NETCoreTest.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.NETCoreTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserInterface _userInterface;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public LoginController(IUserInterface userInterface)
        {
           _userInterface = userInterface;
        }

        //[HttpPost]
        //public ActionResult<bool> CheckLogin(UserLogin userLogin)
        //{
        //    var result = _userInterface.GetUserAccess(userLogin);

        //    //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //    return CreatedAtAction(nameof(userLogin), new { status = result });
        //}

        //[HttpPost("add")]
        //public ActionResult<bool> AddUser(User userLogin)
        //{
        //    var result = _userInterface.AddUser(userLogin);

        //    //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //    return CreatedAtAction(nameof(userLogin), new { status = result });
        //}

        //// PUT api/<LoginController>/5
        //[HttpGet("{id}")]
        //public ActionResult<string> GetName(UserLogin userLogin)
        //{
        //    var data = _userInterface.GetUserName(userLogin);
        //    if (true)
        //    {

        //        return CreatedAtAction(nameof(userLogin), new { status = Ok(), result = data });
        //    }
        //}

        //// DELETE api/<LoginController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        [HttpPost("add")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                bool status  = _userInterface.AddUser(user);
                if (status)
                {
                    return Ok();
                }
                else
                {
                    return Ok(new { message = "Already exist" } );
                }
            }
            return BadRequest();
        }

        [HttpPost]
        public string Login(UserLogin userLogin)
        {
            return _userInterface.GetUserName(userLogin);
        }

        //[HttpPut]
        //public IActionResult Edit([FromBody] Patient patient)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _userInterface.UpdatePatientRecord(patient);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteConfirmed(string id)
        //{
        //    var data = _userInterface.GetPatientSingleRecord(id);
        //    if (data == null)
        //    {
        //        return NotFound();
        //    }
        //    _userInterface.DeletePatientRecord(id);
        //    return Ok();
        //}
    }
}
