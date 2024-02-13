using System;
using UnityEngine;

public class HealthModel : MonoBehaviour
{
    public event Action Changed;
    
    public int MinValue => 0;
    public int MaxValue => 100;

    public int Value { get; private set; } = 100;
    
    public float RelativeValue => (float)Value / MaxValue;

    public void Increase(int value)
    {
        Value += value;
        ChangeValue();
    }

    public void Decrease(int value)
    {
        Value -= value;
        ChangeValue();
    }

    private void ChangeValue()
    {
        Value = Mathf.Clamp(Value, MinValue, MaxValue);
        Changed?.Invoke();
    }
}
