namespace _03.Raiding.Heroes
{
    public class Paladin : BaseHero
    {
        public override string Name { get; set; }
        public override int Power { get; set; }
        public Paladin(string name)
        {
            Name = name;
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
