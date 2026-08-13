internal class Program //
    {
        public static void nameCheck(string name)
        {
            string coolName = "Ashley"; //asigns the cool name to my name "Ashley"
            if(coolName == name) //checks 'name' with the cool name "Ashley"
            {
                Console.WriteLine(name + " is an awesome name"); //if true, print awesome name
     
            }
            else
            {
                Console.WriteLine(name + " is a silly name"); // if false, print silly name
            }
        }

        public static void Main(string[] args)
        {
            string name = "Ashley"; //input name here
            nameCheck(name); //pass name to function nameCheck
        }
    }