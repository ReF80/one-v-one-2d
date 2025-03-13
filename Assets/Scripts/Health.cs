using System;
using UnityEngine;

[Serializable]
public class Health
{
    [field: SerializeField]
    public float Value { get; private set; } = 100f;
        
    [field: SerializeField]
    [field: Range(0.01f, 100f)]
    public float MaxValue { get; set; } = 100f;
        
    [field: SerializeField]
    public float MinValue { get; set; } = 0f;

    public delegate void Respawn();
    public delegate void AddH(float a, float b);
    public event Respawn OnDeath;
    public event AddH OnAdd;
    
        
    public void Add(float amount)
    {
        float newValue = Value + amount;
        if (newValue > MaxValue)
        {
            newValue = MaxValue;
        }
        Value = newValue;
        OnAdd?.Invoke(Value, MaxValue);
    }

    public void Remove(float amount)
    {
        float newValue = Value - amount;
        if (newValue < MinValue)
        {
            OnDeath?.Invoke();
        }
        else
        {
            Value = newValue;
        }
    }

    public void SetMaxValue() => Value = MaxValue;
}