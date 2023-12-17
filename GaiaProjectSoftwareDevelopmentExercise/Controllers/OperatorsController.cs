using GaiaProjectSoftwareDevelopmentExercise.Services;
using Microsoft.AspNetCore.Mvc;
namespace GaiaProjectSoftwareDevelopmentExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperatorsController : ControllerBase
    {
        private readonly NumbersOperationService numbersOperationService;
        private DataBaseManager dataBaseManager = new DataBaseManager();
        public OperatorsController()
        {
            this.numbersOperationService = new NumbersOperationService();
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
                dataBaseManager.addValues("AddNumbers", first.ToString(), second.ToString(), result.ToString());
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
                dataBaseManager.addValues("SubtractNumbers", first.ToString(), second.ToString(), result.ToString());
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
                dataBaseManager.addValues("MultiplyNumbers", first.ToString(), second.ToString(), result.ToString());
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
                dataBaseManager.addValues("DivideNumbers", first.ToString(), second.ToString(), result.ToString());
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
                dataBaseManager.addValues("ConcatenateStrings", first.ToString(), second.ToString(), result.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
