namespace TheFoundtainOfObjects
{
    internal class Room
    {
        public int row {  get; set; }
        public int column { get; set; }

        private int[,] rooms;
        private int entrance;
        private int fountain;
        private int[,] matrix;


        public Room()
        {
            rooms = new int[4, 4]; // 2d array size is 4,4 not 3,3 from my design 
            entrance = rooms[0,0];
            fountain = rooms[0,2];
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

        public void Location() // might remove this since I don't see a use for this method
        {
            if (rooms[row, column] == entrance)
            {
                Console.WriteLine($"You are in the room at (Row={row}, Column={column})");
            }
        }

        public bool OutofBound()
        {
            return row >= rooms.GetLength(0) || row < 0 || column >= rooms.GetLength(1) || column < 0;
        }

        public void DecrementOrIncrementRowOrColumn()
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
