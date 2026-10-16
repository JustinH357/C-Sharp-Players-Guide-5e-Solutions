namespace TheFoundtainOfObjects
{
    internal class Room
    {
        public int Row {  get; private set; }
        public int Column { get; private set; }
        State state;

        private int[,] _rooms;

        public Room()
        {
            _rooms = new int[4, 4]; // 2d array size is 4,4 not 3,3 from my design 
            state = new State();
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
        }

        public void Detail()
        {
            // could move these two to the construtor i guess?
            _rooms[0, 2] = 4; // fountain location
            _rooms[0, 0] = 1; // entrance location

            if (_rooms[Row, Column] == 4)
            {
                state.IsFountainEnable = true;
                Console.WriteLine($"You found the fountain and enable it! Time to head back to the entrance!");
            }

            if (_rooms[Row, Column] == 1)
            {
                // can do a count check to know if user went back to the entrance
                state.IsAtEntrance = true;
            }
        }

        public bool OutcomeCheck()
        {
            if (state.IsFountainEnable && state.IsAtEntrance)
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
