using System;
using System.Collections.Generic;

namespace RoverBackend.RoverFiles

{
    public class Rover : IRover
    {
        public char Direction { get; private set; }
        //Given as (x, y) coords
        public Tuple<int, int> Coords { get; private set; }

        Func<int, int> Add = x => (x + 1);
        Func<int, int> Subtract = x => (x - 1);

        public Rover(Tuple<int, int> startingCoords, char startingDirection)
        {
            Direction = startingDirection;
            Coords = startingCoords;
        }

        public void InputCommands(List<char> commands)
        {
            commands.ForEach(c => Action(c));
        }

        /**
         * Takes in the command from the CSV and "actions" it
         * Returns true for success
         */
        public bool Action(char input)
        {
            if (input.Equals('M'))
            {
                Move();
            }
            else if (input.Equals('L'))
            {
                RotateLeft();
            }
            else if (input.Equals('R'))
            {
                RotateRight();
            }

            return true;
        }

        private char RotateLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;

                case 'W':
                    Direction = 'S';
                    break;

                case 'S':
                    Direction = 'E';
                    break;

                case 'E':
                    Direction = 'N';
                    break;
            }

            return Direction;
        }

        private char RotateRight()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'E';
                    break;

                case 'E':
                    Direction = 'S';
                    break;

                case 'S':
                    Direction = 'W';
                    break;

                case 'W':
                    Direction = 'N';
                    break;
            }

            return Direction;
        }

        private void Move()
        {
            switch (Direction)
            {
                case 'N':
                    Coords = Tuple.Create(Coords.Item1, Add(Coords.Item2)); ;
                    break;

                case 'E':
                    Coords = Tuple.Create(Add(Coords.Item1), Coords.Item2); ;
                    break;

                case 'S':
                    Coords = Tuple.Create(Coords.Item1, Subtract(Coords.Item2)); ;
                    break;

                case 'W':
                    Coords = Tuple.Create(Subtract(Coords.Item1), Coords.Item2); ;
                    break;
            }
        }

    }
}
