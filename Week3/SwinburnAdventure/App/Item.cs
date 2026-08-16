namespace SwinburneAdventure
{
    
    public class Item
    {
        private List<string> _identifiers ;
        private string _name;
        private string _description;


        public Item(string[] idents, string name, string description)
        {
            _identifiers = new List<string>();
            foreach (string s in idents)
            {
                _identifiers.Add(s.ToLower());
            }
            _name = name;
            _description = description;
        }

        public string Name
        {
            get { return _name; }
        }
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }
public string FirstID
        {
            get
            {
                if (_identifiers.Count > 0)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }

        public string ShortDescription
        {
            get
            {
                
                return _name + " " + FirstID;
            }
        }

        public string LongDescription
        {
            get
            {
                return _description;
            }
        }

          public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public void RemoveIdentifier(string id)
        {
            _identifiers.Remove(id.ToLower());
        }

        public void PrivilgeEscalation(string pin)
        {
            if (pin == "9611") // the last 4 digits of your ID
            {
                _identifiers[0] = "Class Thursday morning";
            }
        }
    }
}