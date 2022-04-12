namespace POO.src.entities
{
    public abstract class Hero
    {
       public Hero (string Name, int Level, string HeroType, int HealthPoints, int MagicPoints){
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.HealthPoints = HealthPoints;
           this.MagicPoints = MagicPoints;
       }
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoints;
        public int MagicPoints;


        public override string ToString (){
            return this.Name + " " + this.Level + " " + this.HeroType;

        }

        public virtual string Attack (){
            return this.Name + "Atacou com a sua espada";
        }

  

    }
}