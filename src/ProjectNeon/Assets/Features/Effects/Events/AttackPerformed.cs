﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class AttackPerformed
{
    public Attack Attack { get; }

    public AttackPerformed(Attack attack, Member attacker, Target target)
    {
        Attack = attack;
    }
}

