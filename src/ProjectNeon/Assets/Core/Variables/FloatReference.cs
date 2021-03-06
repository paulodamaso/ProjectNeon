﻿using System;

[Serializable]
public class FloatReference
{
    public bool UseConstant = true;
    public float ConstantValue;
    [DTValidator.Optional] public FloatVariable FloatVariable;

    public float Value => UseConstant ? ConstantValue : FloatVariable != null ? FloatVariable.Value : 0;

    public FloatReference() { }

    public FloatReference(float value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
