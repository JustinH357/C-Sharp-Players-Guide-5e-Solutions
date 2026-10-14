namespace TheFoundtainOfObjects
{
    internal class Room
    {
        public int row {  get; private set; }
        public int column { get; private set; }

        private int[,] rooms;

        public Room()
        {
            rooms = new int[4, 4]; // 2d array size is 4,4 not 3,3 from my design 
            //fountain = rooms[0,2];
        }

        public void Move(string input)
        {
            Player player = new Player(input);

            if (player._input == "move east")
            {
                column++;
            }

            if (player._input == "move north")
            {
                row--;
            }

            if (player._input == "move west")
            {
                column--;
            }

            if (player._input == "move south")
            {
                row++; // can be confusing but moving up a row means going to the next row below since row starts at 0
            }
        }

        public void Details()
        {
            //State state = new State();

            int fountain = rooms[0, 2]; // lets say fountain is 4
            int entrance = rooms[0, 0]; // entrance can be 1, and all the others can be default value of 0

            if (rooms[row, column] == fountain) // all the rooms are default value so they all equal the same which makes this condition true
            {
                State.isFountainEnable = true;
                Console.WriteLine($"You found the fountain and enable it! Time to head back to the entrance!");
            }

            if (rooms[row, column] == entrance)
            {
                // can do a count check to know if user went back to the entrance
                State.isAtEntrance = true; 
            }
        }

        public bool OutOfBoundCheck()
        {
            return row >= rooms.GetLength(0) || row < 0 || column >= rooms.GetLength(1) || column < 0;
        }

        public void OutOfBoundComeback()
        {
            if (row < 0) 
            { 
                row++; 
            }
            if (row >= rooms.GetLength(0))
            {
                row--;
            }
                
            if (column < 0)
            {
                column++;
            }
            if (column >= rooms.GetLength(1))
            {
                column--;
            }
        }
    }
}
