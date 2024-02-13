using UnityEngine;
using UnityEngine.UI;

public class HealthDiscreteBarPresenter : HealthBarPresenter
{
    protected override void UpdateHealthView()
    {
        HealthView.value = TargetHealth;
    }
}