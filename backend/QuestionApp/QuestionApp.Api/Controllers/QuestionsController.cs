using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionApp.Application.DTOs;
using QuestionApp.Application.Services;
using QuestionApp.Models;

namespace QuestionApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuestionService _service;

        public QuestionsController(QuestionService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<QuestionDto>>> Questions()
        {
            // var questions = new Question[] 
            // { 
            //      new Question { Id = 1, Title = "Sample Question 1", Choice1 = "Red", Choice2 = "Blue", Choice3 = "Green", Choice4 = "Yellow" },
            //     new Question { Id = 2, Title = "Sample Question 2", Choice1 = "Cat", Choice2 = "Dog", Choice3 = "Bird", Choice4 = "Fish" }
            // };
            // return Ok(questions);
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // [HttpPost]
        // public ActionResult<Question> Question([FromBody] Question question)
        // {
        //     if (question == null)
        //     {
        //     return BadRequest("Question cannot be null");
        //     }
        //     return CreatedAtAction(nameof(Questions), question);
        // }
        [HttpPost]
        public async Task<ActionResult<QuestionDto>> Question([FromBody] QuestionDto question)
        {
            var created = await _service.CreateAsync(question);
            return Ok(created);
        }


        // [HttpDelete("{id}")]
        // public ActionResult DeleteQuestion(int id)
        // {
        //     if (id <= 0)
        //     {
        //         return BadRequest("Invalid question id");
        //     }
        //     return Ok($"Question with id {id} deleted successfully");
        // }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }

    }
}
