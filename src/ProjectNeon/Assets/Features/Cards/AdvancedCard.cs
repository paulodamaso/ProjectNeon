﻿using System;
using System.Linq;
using UnityEngine;

public class AdvancedCard : ScriptableObject
{
    [SerializeField] private Sprite art;
    [SerializeField] private string description;
    [SerializeField] private string typeDescription;
    [SerializeField] private StringVariable onlyPlayableByClass;
    [SerializeField] private ResourceCost cost;
    [SerializeField] private AdvancedCardAction cardAction1;
    [SerializeField] private AdvancedCardAction cardAction2;

    public string Name => name.WithSpaceBetweenWords();
    public ResourceCost Cost => cost;
    public Sprite Art => art;
    public string Description => description;
    public string TypeDescription => typeDescription;
    public Maybe<string> LimitedToClass => new Maybe<string>(onlyPlayableByClass.Value.Length > 0 ? onlyPlayableByClass.Value : null);

    public ICardAction[] Actions => Array.Empty<ICardAction>()
        .ConcatIf(cardAction1, c => c.HasEffects())
        .ConcatIf(cardAction2, c => c.HasEffects())
        .ToArray();
}