namespace _03.Raiding.Heroes
{
    public class Rogue : BaseHero
    {
        public override string Name { get; set; }
        public override int Power { get; set; }
        public Rogue(string name)
        {
            Name = name;
            Power = 80;
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
