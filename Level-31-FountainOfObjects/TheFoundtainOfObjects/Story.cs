namespace TheFoundtainOfObjects
{
    internal class Story
    {
        public string Intro { get; }
        public string Outro { get; }

        public Story()
        {
            // the author has a narrative that describes arriving and after the cavern so can use that as reference
            // for a better storytelling for the intro and outro. 
            Intro = "You wonder into this cavern because you heard the fountain is located here.";
            Outro = "You successfully activated the fountain and now getting ready for the your fight as you leave the cavern.";
        }
    }
}
