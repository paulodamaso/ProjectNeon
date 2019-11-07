
using System;
using UnityEngine;

public sealed class ConditionalEffect : Effect
{
    private Func<bool> _condition;
    private Effect _effect;

    public ConditionalEffect(Effect effect, Func<bool> condition)
    {
        _condition = condition;
        _effect = effect;
    }

    public void Apply(Member source, Target target)
    {
        if (_condition())
            _effect.Apply(source, target);
    }
}