namespace GearTrackerApp
{
    public class GearItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Condition { get; set; }

        public GearItem(string name, string type, string condition)
        {
            Name = name;
            Type = type;
            Condition = condition;
        }

        public override string ToString()
        {
            return $"{Name} - {Type} - {Condition}";
        }
    }
}
