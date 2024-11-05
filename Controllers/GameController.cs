using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JRMTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace JRMTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController: ControllerBase
    {
        private static Game _fizzBuzzGame = new Game();
        private static int _randomNumber=0;

        private static Score _score = new Score();

        private static List<Rule> rules = new List<Rule>()
        {
            new Rule()
                {
                    Divisor = 3,
                    Replacement="Fizz"
                },
            
            new Rule()
                {
                    Divisor = 5,
                    Replacement = "Buzz"

                }

        
        };

        private static string _userInput = "";

        [HttpGet("GameInformation")]

        public ActionResult<Game> GetGameInformation(){


            return Ok(_fizzBuzzGame);
        }

        [HttpGet("RandomNumber")]
        public ActionResult<int> GetRandomNumber(){
            
             _randomNumber = new Random().Next(0, 100);


             return Ok (_randomNumber);




        }

        [HttpPost ("UserInput")]

        public ActionResult<bool> ReceiveUserInput (string userInput){

            _userInput = userInput.Replace(" ","").ToLower();
            bool answer = true;


            if(_userInput.Equals(GetReplacedString(_randomNumber,rules).ToLower())){


                _score.CorrectAnswer++;
            }

            else{

                answer = false;
                _score.InCorrectAnswer++;

            }


            
            return  Ok(answer);
        }

        [HttpGet]

        public string GetReplacedString(int randomNumber, List<Rule> rules){

            var result = string.Join("",
                rules.Where(rule => randomNumber % rule.Divisor ==0)
                    .Select(rule => rule.Replacement)
            );

            return string.IsNullOrEmpty(result)? randomNumber.ToString("") : result;


        }


        [HttpGet("Score")]

        public ActionResult<Score> GetUserScore(){



            return Ok(_score);
        }
        
    }
}