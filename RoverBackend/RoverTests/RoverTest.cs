using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverBackend;
using RoverBackend.Controllers;
using RoverBackend.RoverFiles;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RoverTests
{
    [TestClass]
    public class RoverTest
    {

        [TestMethod]
        public void TestSingleRover()
        {
            string inputCommand = "LMLMLMLMM";

            Tuple<int, int> expectedCoords = new Tuple<int, int>(1,3);
            char expectedDirection = 'N';

            Tuple<int, int> startingCoords = new Tuple<int, int>(1, 2);

            IRover rover = new Rover(startingCoords, 'N');

            rover.InputCommands(new List<char>(inputCommand.ToCharArray()));

            Assert.AreEqual(expectedCoords, rover.Coords);
            Assert.AreEqual(expectedDirection, rover.Direction);


        }

        [TestMethod]
        public void TestSingleRover2()
        {
            string inputCommand = "MMRMMRMRRM";

            Tuple<int, int> expectedCoords = new Tuple<int, int>(5, 1);
            char expectedDirection = 'E';

            Tuple<int, int> startingCoords = new Tuple<int, int>(3, 3);

            IRover rover = new Rover(startingCoords, 'E');

            rover.InputCommands(new List<char>(inputCommand.ToCharArray()));

            Assert.AreEqual(expectedCoords, rover.Coords);
            Assert.AreEqual(expectedDirection, rover.Direction);
        }

        /**
         * Next steps would be controller tests
         * 
         * */
    }
}
