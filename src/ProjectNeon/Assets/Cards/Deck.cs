﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Deck : ScriptableObject
{
    [SerializeField]
    private List<Card> cards;

    public Deck(List<Card> cards)
    {
        this.cards = cards;
    }

    public void Shuffle()
    {
        cards.Sort((a, b) => (int)System.Math.Round(Random.value, 0));
    }

}