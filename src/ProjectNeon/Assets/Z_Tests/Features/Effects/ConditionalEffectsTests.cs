using NUnit.Framework;

public sealed class ConditionalEffectsTests 
{

    [Test]
    public void ConditionalEffect_ApplyEffect_ApplyWhenConditionIsTrue()
    {
        Member attacker = TestMembers.Create(
            s => s.With(StatType.Attack, 1f).With(StatType.MaxHP, 10).With(StatType.Damagability, 1f)
        );

        Member target = TestMembers.Create(s => s.With(StatType.MaxHP, 10).With(StatType.Damagability, 1f));

        new ConditionalEffect(new Attack(1), () => true ).Apply(attacker, new MemberAsTarget(target));

        Assert.AreEqual(9, target.State[TemporalStatType.HP]);
    }

    [Test]
    public void ConditionalEffect_ApplyEffect_DoesNotApplyWhenConditionIsFalse()
    {
        Member attacker = TestMembers.Create(
            s => s.With(StatType.Attack, 1f).With(StatType.MaxHP, 10).With(StatType.Damagability, 1f)
        );

        Member target = TestMembers.Create(s => s.With(StatType.MaxHP, 10).With(StatType.Damagability, 1f));

        new ConditionalEffect(new Attack(1), () => false).Apply(attacker, new MemberAsTarget(target));

        Assert.AreEqual(10, target.State[TemporalStatType.HP]);
    }
}