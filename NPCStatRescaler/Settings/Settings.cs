using System.Collections.Generic;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace NPCStatRescaler.Settings
{
    public enum Races
    {
        Argonian,
        Breton,
        DarkElf,
        HighElf,
        Imperial,
        Khajiit,
        Nord,
        Orc,
        Redguard,
        WoodElf
    }
    public class Config
    {
        public CommonStats CommonStats { get; set; } = new();
        
        public Dictionary<Races, Stats> RacesStats { get; set; } = new()
        {
            {Races.Argonian, new Stats()},
            {Races.Breton, new Stats()},
            {Races.DarkElf, new Stats()},
            {Races.HighElf, new Stats()},
            {Races.Imperial, new Stats()},
            {Races.Khajiit, new Stats()},
            {Races.Nord, new Stats()},
            {Races.Orc, new Stats()},
            {Races.Redguard, new Stats()},
            {Races.WoodElf, new Stats()}
        };
        
        public Dictionary<ChildVampire, StatScales> StatScales { get; set; } = new()
        {
            {ChildVampire.Child, new StatScales
            {
                HealthScale = 0.75f, 
                MagickaScale = 0.5f, 
                StaminaScale = 1f, 
                CarryWeightScale = 0.5f
            }},
            {ChildVampire.Vampire, new StatScales
            {
                HealthScale = 1f,
                MagickaScale = 1.5f,
                StaminaScale = 1.25f,
                CarryWeightScale = 1f
            }}
        };

        public List<FormLink<IRaceGetter>> RacesToExclude { get; set; } = new(); 
        public ClassScales Class { get; set; } = new();
        public NpcOffsetMults NpcOffsetMults { get; set; } = new();
        public int NpcHealthBonusPerLevel { get; set; } = 0;
        public HealthRegen HealthRegen { get; set; } = new();
        public StaminaRegen StaminaRegen { get; set; } = new();
        public MagickaRegen MagickaRegen { get; set; } = new();
        public PlayerRegenPenalties PlayerCombatRegenPenalties { get; set; } = new();


    }
}