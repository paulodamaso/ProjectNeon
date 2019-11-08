public interface ICardAction

{
    void Apply(Member source, Target target);

    Scope Scope();
    Group Group();
    bool HasEffects();

    EffectData[] Effects();
}