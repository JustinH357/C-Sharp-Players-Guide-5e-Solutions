using System.Numerics;

namespace TheFoundtainOfObjects
{
    internal class Room
    {
        public int Row {  get; private set; }
        public int Column { get; private set; }

        private State _state;
        private int[,] _rooms;

        public Room()
        {
            _rooms = new int[4, 4]; // 2d array size is 4,4 not 3,3 from my design 
            _state = new State();
        }

        public void Move(string input)
        {
            Player player = new Player(input);

            if (player.Input == "move east")
            {
                Column++;
            }

            if (player.Input == "move north")
            {
                Row--;
            }

            if (player.Input == "move west")
            {
                Column--;
            }

            if (player.Input == "move south")
            {
                Row++; // can be confusing but moving up a row means going to the next row below since row starts at 0
            }

            EnableOrDisableFountain(player.Input);
        }

        private void EnableOrDisableFountain(string input)
        {
            Player player = new Player(input); // either make this a field above for more access or leave it like this

            if (player.Input == "enable fountain") // could just move it to the Move method instead but may need to change the Move method name
            {
                Console.WriteLine("You enable the fountain! Water started rising out of it!");
            }
        }

        public void Detail()
        {
            int entranceCount = 0;
            // could move these two to the construtor i guess?
            _rooms[0, 2] = 4; // fountain location
            _rooms[0, 0] = 1; // entrance location
            _rooms[0, 1] = 2; // pitfall

            if (_rooms[Row, Column] == 4)
            {
                _state.IsFountainEnable = true;
                Console.WriteLine($"You found the fountain and enable it! Time to head back to the entrance!");
            }

            if (_rooms[Row, Column] == 1)
            {
                //int entranceCount = 0;
                // can do a count check to know if user went back to the entrance

                    Console.WriteLine("You see the cavern entrance and you have now enter it.");
                

                if (entranceCount > 1)
                {
                    Console.WriteLine("You came back to the entrance of the cavern and see light.");
                    _state.IsAtEntrance = true;
                }

                //entranceCount++; // flag as unnessary assignment need to find another way
            }
        }

        public bool PitfallLocation()
        {
            // 2 is the number that will be considered pitfall that stops the player
            // may include other numbers for Detail method where player hears something and goes but it was a pitfall
            _rooms[0, 1] = 2;
            _rooms[1, 2] = 2;
            _rooms[3, 0] = 2;

            if (_rooms[Row, Column] == 2)
            {
                // can do a count check to know if user went back to the entrance
                Console.WriteLine("You fallen into a pitfall!");
                return true;
            }

            return false;
        }

        public bool OutcomeCheck()
        {
            if (_state.IsFountainEnable && _state.IsAtEntrance)
            {
                return true;
            }

            return false;
        }

        public bool OutOfBoundCheck()
        {
            return Row >= _rooms.GetLength(0) || Row < 0 || Column >= _rooms.GetLength(1) || Column < 0;
        }

        public void OutOfBoundComeback()
        {
            if (Row < 0) 
            { 
                Row++; 
            }
            if (Row >= _rooms.GetLength(0))
            {
                Row--;
            }
                
            if (Column < 0)
            {
                Column++;
            }
            if (Column >= _rooms.GetLength(1))
            {
                Column--;
            }
        }
    }
}
