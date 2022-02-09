namespace game.src.Entities
{
    public class Wizard : Hero
    {

    public Wizard(string Name, int Level, string Herotype)  
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = Herotype;
    }
    public override string Attack()
    {
      return this.Name + " Atacou com a sua magia";
    }

  }
}