namespace TheFoundtainOfObjects
{
    internal static class State
    {
        public static bool isFountainEnable { get; set; }
        public static bool isAtEntrance { get; set; }

        public static bool OutcomeCheck()
        {
            if (isFountainEnable && isAtEntrance)
            {
                return true;
            }

            return false;
        }
    }
}
