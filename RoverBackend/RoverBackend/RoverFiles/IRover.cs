using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoverBackend.RoverFiles
{
    public interface IRover
    {
        char Direction { get; }
        Tuple<int, int> Coords { get; }
        void InputCommands(List<char> command);
        bool Action(char Input);
    }
}
