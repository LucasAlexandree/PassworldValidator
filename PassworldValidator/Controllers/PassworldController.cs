using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace PassworldValidator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassworldController : ControllerBase
    {
        

        private readonly ILogger<PassworldController> _logger;

        public PassworldController(ILogger<PassworldController> logger)
        {
            _logger = logger;
        }

        
        [HttpPost(Name = "PostValidator")]
        public IActionResult ValidatePassword(string password)
        {
            var validator = new PasswordValidator();
            var validationResult = validator.PasswordRequestValidator(password);

            if (string.IsNullOrEmpty(validationResult))
            {
                // A senha é válida
                return Ok(new { IsValid = true });
            }

            // A senha é inválida, retorna os erros
            return BadRequest(new { IsValid = false, Errors = validationResult.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries) });
        }



    }
}
