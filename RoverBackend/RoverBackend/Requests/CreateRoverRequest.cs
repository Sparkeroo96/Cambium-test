using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoverBackend.Requests
{
    public class CreateRoverRequest
    {
        //Input string, aka Command, should be in the format: 1 2 N | LMLMLMLMM
        public string InputString { get; set; }
    }
}
