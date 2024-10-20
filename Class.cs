using AonFreelancing.Models;
using Microsoft.AspNetCore.Mvc;

namespace AonFreelancing.Controllers
{
   

        public class ProjectController : ControllerBase
    {
        
            private static List<project> projects = new List<project>();
        private static int nextId = 1;
        [ApiController]
        [Route("v1/[controller]")]
        public class ProjectssController : ControllerBase
        {
            
                [HttpPost]
                public IActionResult CreateProject([FromBody] project project)
                {
                    // Implementation
                }
            [HttpGet]
            public IActionResult GetAllProjects()
            {
                return Ok(projects);
            }
            [HttpPut("{id}")]
            public IActionResult UpdateProject(int id, [FromBody] Trainer updatedProject)
            {
                var project = projects.FirstOrDefault(t => t.Id == id);
                if (project == null)
                {
                    return NotFound();
                }
                // Update the trainer's details
                project.Title = updatedProject.Title;
                project.Description = updatedProject.Description;


                return NoContent(); // 204 No Content indicates a successful update
            }
            [HttpDelete("{id}")]
            public IActionResult DeleteProject(int id)
            {
                var project = projects.FirstOrDefault(t => t.Id == id);
                if (project == null)
                {
                    return NotFound();
                }

                projects.Remove(project);
                return NoContent(); // 204 No Content to indicate successful deletion
            }

            



































