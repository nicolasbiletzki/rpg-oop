namespace CSharp___POO.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public string Attack(){
            return this.Name + " atacou com sua espada ";
        }


        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

    }
}