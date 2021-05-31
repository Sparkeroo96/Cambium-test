using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoverBackend.RoverFiles;
using RoverBackend.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoverBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoverController : ControllerBase
    {

        IList<IRover> _rovers;
        Func<string, List<char>> SplitCommand = x =>
        {
            x = x.Trim()
                    .Replace(" ", "")
                    .Replace("|", "");

            return new List<char>(x.ToCharArray());
        };

        Func<IList<char>, IList<char>> CleanList = x =>
        {
            x.RemoveAt(0);
            x.RemoveAt(0);
            x.RemoveAt(0);

            return x;
        };

        public RoverController()
        {
            _rovers = new List<IRover>();
        }

        // GET: api/<RoverController>
       [HttpGet]
        public List<IRover> Get()
        {
            //return new List<IRover>(_rovers);
            return (List<IRover>)_rovers;
        }


        // POST api/<RoverController>
        [HttpPost]
        public IRover Post(CreateRoverRequest request)
        {
            List<char> commands = SplitCommand(request.InputString);
            Tuple<int, int> startingCoords = new Tuple<int, int>(
                                    (int) Char.GetNumericValue(commands[0]), (int)Char.GetNumericValue(commands[1])
                                );

            IRover rover = new Rover(startingCoords, commands[2]);

            commands.RemoveRange(0,3);

            rover.InputCommands(commands);

            return rover;

        }


    }
}
