namespace PathfinderRPG
{
    public class Equipment : Item
    {
        public int MinDamage { get; protected set; }
        public int MaxDamage { get; protected set; }
        public string DamageType { get; protected set; }
        public bool RequiresTwoHands { get; protected set; }
    }
}