public enum EffectType
{
    Nothing = 0,
    HealFlat = 1,
    PhysicalDamage = 2,
    BuffAttackFlat = 3,
    RemoveDebuffs = 4,
    BuffMaxHp = 5,
    ShieldFlat = 6,
    ResourceFlat = 7,
    DamageOverTimeFlat = 8,
    BuffAttackMultiplier = 9,
    ApplyVulnerable = 10,
    ShieldToughness = 11,
    ArmorFlat = 12,
    Stun = 13,
    ShieldAttackedOnAttack = 14,
    DamageAttackerOnAttack = 15,
    StealLifeNextAttack = 16,
    Attack = 17,
    InterceptAttackForTurns = 18,
    EvadeAttacks = 19,
    HealFlatForTurnsOnTurnStart = 20,
    BuffStrengthFlat = 21,
    BuffToughnessFlat = 22,
    RandomizeTarget = 23,
    RepeatEffect = 24,
    AnyTargetHealthBelowThreshold = 25,
    OnAttacked = 26,
    CostPrimaryResourceEffect = 27,
    ForNumberOfTurns = 28,
    //FeedOnEffect = 29, unused effect
    ShieldBasedOnShieldValue = 30,
    ExcludeSelfFromEffect = 31,
    RepeatUntilPrimaryResourceDepleted = 32,
    SpellFlatDamageEffect = 33,
    OnNextTurnEffect = 34,
    QueueEffect = 35,
    EffectOnTurnStart = 36,
    TriggerFeedEffects = 37,
    SetFeedUpEffect = 38,
    HealPrimaryResource = 39,
    ApplyOnShieldBelowValue = 40,
    ApplyOnChance = 41,
    ReplayLastCard = 42
}
