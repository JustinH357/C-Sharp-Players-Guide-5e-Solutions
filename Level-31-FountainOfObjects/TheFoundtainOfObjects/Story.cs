namespace TheFoundtainOfObjects
{
    internal class Story
    {
        public string _intro { get; }
        public string _outro { get; }

        public Story()
        {
            // the author has a narrative that describes arriving and after the cavern so can use that as reference
            // for a better storytelling for the intro and outro. 
            _intro = "You wonder into this cavern because you heard the fountain is located here.";
            _outro = "You successfully activated the fountain and now getting ready for the your fight as you leave the cavern.";
        }
    }
}
