namespace CSharp___POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou com seu cajado ";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " atacou com seu cajado com um bonus super efetivo de " + Bonus;
            }
            return this.Name + " atacou com seu cajado com um bonus de " + Bonus;
        }


    }
}