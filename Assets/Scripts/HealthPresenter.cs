using UnityEngine;

public abstract class HealthPresenter : MonoBehaviour
{
    [SerializeField] protected HealthModel HealthModel;
    
    protected abstract void UpdateHealthView();

    private void OnEnable()
    {
        HealthModel.Changed += UpdateHealthView;
    }
    
    private void OnDisable()
    {
        HealthModel.Changed -= UpdateHealthView;
    }
}