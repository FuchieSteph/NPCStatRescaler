namespace NPCStatRescaler.Settings
{
    public enum ChildVampire
    {
        Child,
        Vampire
    }

    public class CommonStats
    {
        public int HealthShift { get; set; } = 50;
        public float HealthScale { get; set; } = 0.5f;
        public int StaminaShift { get; set; } = 0;
        public float StaminaScale { get; set; } = 1;
        public int MagickaShift { get; set; } = 0;
        public float MagickaScale { get; set; } = 1;
    }

    public record Stats
    {
        public int Health { get; set; } = 100;
        public int Stamina { get; set; } = 100;
        public int Magicka { get; set; } = 100;
        public int CarryWeight { get; set; } = 200;
    }
    public record StatScales
    {
        public float HealthScale { get; set; }
        public float StaminaScale { get; set; }
        public float MagickaScale { get; set; }
        public float CarryWeightScale { get; set; }
    }
    public record ClassScales
    {
        public float HealthScale { get; set; } = 1f;
        public float StaminaScale { get; set; } = 1.5f;
        public float MagickaScale { get; set; } = 1.5f;
    }
    public record NpcOffsetMults
    {
        public float HealthOffsetMult { get; set; } = 0.2f;
        public float StaminaOffsetMult { get; set; } = 1f;
        public float MagickaOffsetMult { get; set; } = 1f;
    }

    public record HealthRegen
    {
        public float Scale { get; set; } = 1f;
        public int Shift { get; set; } = 0;
        public float PlayableRaceHealthRegenDebuff { get; set; } = 1f;
        public bool DebuffVampires { get; set; } = false;
    }

    public record StaminaRegen
    {
        public float Scale { get; set; } = 1f;
        public int Shift { get; set; } = 0;
    }

    public record MagickaRegen
    {
        public float Scale { get; set; } = 0.3f;
        public int Shift { get; set; } = 0;
        //public bool ScaleMagickaRegenBuffs { get; set; } = true;
    }

    public record PlayerRegenPenalties
    {
        public float HealthCombatRegenPenalty { get; set; } = 1;
        public float StaminaCombatRegenPenalty { get; set; } = 1;
        public float MagickaCombatRegenPenalty { get; set; } = 1;
    }
}