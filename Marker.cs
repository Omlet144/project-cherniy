namespace project_cherniy
{
    using System;
    class Marker
    {
        public Marker(System.ConsoleColor color, string text)
        {
            this.ColorProperty = color;
            this.TextProperty = text;
        }
        public System.ConsoleColor ColorProperty {set; get;}
        public string TextProperty {set; get;}
        public string GetInfo()
        {
            System.Console.ForegroundColor = this.ColorProperty;
            return $"{ColorProperty.ToString()}\n{TextProperty}";
        }
    }
}