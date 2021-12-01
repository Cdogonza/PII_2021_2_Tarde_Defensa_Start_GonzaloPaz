namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }

        public bool IsOrganic{
            get
            {
                return Type.IsOrganic;
            }
            set
            {
                this.IsOrganic = Type.IsOrganic;
            }
        }

        public ResidueType Type { get; set; }

        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}