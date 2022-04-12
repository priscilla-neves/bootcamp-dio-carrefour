namespace POO.src.entities
{
    public class Knight : Hero
    {
        public Knight (string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;
        
    }
        
    }
}