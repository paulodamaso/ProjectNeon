using System;
using System.Linq;
using UnityEngine;

[Serializable]
public sealed class AdvancedCardAction : ICardAction

{
    [SerializeField] private Scope targetScope;
    [SerializeField] private Group targetGroup;
    [SerializeField] private EffectData[] effects;

    public EffectData[] Effects() => effects;

    public void Apply(Member source, Target target)
    {
        Effects().ForEach(
            effect => AllEffects.Apply(effect, source, target)
        );
    }

    public Scope Scope() => targetScope;
    public Group Group() => targetGroup;
    public bool HasEffects() => Effects() != null && Effects().Length > 0;
}
