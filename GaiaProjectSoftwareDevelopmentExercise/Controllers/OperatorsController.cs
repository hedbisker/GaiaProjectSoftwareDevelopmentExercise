using GaiaProjectSoftwareDevelopmentExercise.Services;
using Microsoft.AspNetCore.Mvc;
namespace GaiaProjectSoftwareDevelopmentExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperatorsController : ControllerBase
    {
        private readonly NumbersOperationService numbersOperationService;

        public OperatorsController()
        {
            this.numbersOperationService = new NumbersOperationService();
        }

        [HttpGet("[action]")]
        public int Get()
        {
            return 2;
        }

        [HttpGet("[action]")]
        public int xxx()
        {
                return 1;
          
        }


        [HttpGet("[action]")]
        public IActionResult GetListOfOperators()
        {
            try
            {
                return Ok(new List<string>() 
                {   "AddNumbers", 
                    "SubtractNumbers",
                    "MultiplyNumbers",
                    "DivideNumbers",
                    "ConcatenateStrings" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddNumbers(double first, double second)
        {
            try
            {
                double result = numbersOperationService.Add(first, second);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult SubtractNumbers(double first, double second)
        {
            try
            {
                double result = numbersOperationService.Subtract(first, second);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult MultiplyNumbers(double first, double second)
        {
            try
            {
                double result = numbersOperationService.Multiply(first, second);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult DivideNumbers(double first, double second)
        {
            try
            {
                double result = numbersOperationService.Divide(first, second);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult ConcatenateStrings(string first, string second)
        {
            try
            {
                string result = string.Concat(first, second);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
