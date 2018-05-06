namespace RPG_Editor.Character
{
    public class Stat
    {
        public enum StatType { Regular, Calculated};

        private string name;
        private string abbreviation;
        private string description;
        private StatType type;

        public string Name
        {
            get { return name; }
        }

        public string Abbreviation
        {
            get { return abbreviation; }
        }

        public string Description
        {
            get { return description; }
        }

        public StatType Type
        {
            get { return type; }
        }

        public Stat(string _name, StatType _type, string _abbreviation, string _description)
        {
            name = CheckString(_name);
            type = _type;
            abbreviation = CheckString(_abbreviation);
            description = CheckString(_description);
        }

        public void Update(StatType _type, string _abbreviation, string _description)
        {
            type = _type;
            abbreviation = CheckString(_abbreviation);
            description = CheckString(_description);
        }

        private string CheckString(string data)
        {
            if(string.IsNullOrWhiteSpace(data))
            {
                data = "Error";
            }

            return data;
        }
    }
}
