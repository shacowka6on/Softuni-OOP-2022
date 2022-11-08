namespace _03.Raiding.Heroes
{
    public class Druid : BaseHero
    {
        public override string Name { get; set; }
        public override int Power { get; set; }

        public Druid(string name)
        {
            Name = name;
            Power = 80;
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
