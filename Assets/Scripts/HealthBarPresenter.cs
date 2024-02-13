using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBarPresenter : MonoBehaviour
{
    [SerializeField] protected Slider HealthView;
    [SerializeField] protected HealthModel HealthModel;

    protected float TargetHealth => (float)HealthModel.Value / HealthModel.MaxValue;
    
    protected abstract void UpdateHealthView();

    private void OnEnable()
    {
        HealthModel.Changed += UpdateHealthView;
    }
    
    private void OnDisable()
    {
        HealthModel.Changed -= UpdateHealthView;
    }

    private void Start()
    {
        UpdateHealthView();
    }
}