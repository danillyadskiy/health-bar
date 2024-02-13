using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBarPresenter : HealthPresenter
{
    [SerializeField] protected Slider HealthView;

    private void Start()
    {
        UpdateHealthView();
    }
}