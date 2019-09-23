﻿using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public Sprite Art;
    public string Description;
    public string TypeDescription;
    public List<CardAction> actions;
    public Scope scope;
    public Group group;
}
