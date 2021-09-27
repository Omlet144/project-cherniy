namespace project_cherniy
{
    class Marker
    {
       string text;
        System.ConsoleColor color;
        public Marker(System.ConsoleColor color, string text)
        {
            this.color = color;
            this.text = text;
        }
         public System.ConsoleColor ColorProperty
        {
            get { return color; }
        }
        public string TextProperty
        {
            get { return text; }
        }
        public void GetInfo()
        {
        
            Console.WriteLine($"{text}");
        }
    }
}