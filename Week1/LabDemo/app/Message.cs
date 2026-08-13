namespace HelloWorld //declare a scope, contain a set of related objects
{
    public class Message
    {
        private string _text;

        public Message(string txt)
        {
            _text = txt;
        }

        public void Print()
        {
            Console.WriteLine(_text);
        }
        public string GetMessage()
        {
            return this._text;
        }
    }
}