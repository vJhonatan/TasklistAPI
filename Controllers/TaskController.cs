using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskListAPI.Models;

namespace TaskListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        
        private static List<TaskModel> tasks = new List<TaskModel>();

        [HttpPost]
        public ActionResult<List<TaskModel>> AddTask (TaskModel newTask)
        {   
            if (newTask.Description.Length < 10) return BadRequest("The description must be at least 10 characters long.");

            tasks.Add(newTask);

            return Ok(tasks);
        }

        [HttpGet]
        public ActionResult<List<TaskModel>> GetAllTasks ()
        {
            if (tasks.Count == 0) return NotFound("no tasks were added.");

            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public ActionResult TaskModel (int id)
        {
            var findId = tasks.Find(x => x.Id == id);

            if (findId == null) return NotFound("ID not found.");

            return Ok(findId);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTask (int id)
        {
            var findId = tasks.Find(x => x.Id == id);

            if (findId == null) return NotFound("ID not found.");

            tasks.Remove(findId);

            return Ok($"Task '{findId.Title}' successfully removed.");
        }
    }
}
