namespace POO.src.entities
{
    public class Wizard : Hero
    {

    public Wizard (string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;
        
    }
            
    public override string Attack (){
         return this.Name + "Lançou Magia";
        }

    public string Attack (int Bonus){

        if (Bonus > 6){
            return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
        }else{
            return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
        }

    
    }
    }
}