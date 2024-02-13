using UnityEngine;
using UnityEngine.UI;

public class HealthBarPresenter : MonoBehaviour
{
    [SerializeField] private Slider _healthView;
    [SerializeField] private HealthModel _healthModel;

    private void OnEnable()
    {
        _healthModel.Changed += UpdateHealthView;
    }
    
    private void OnDisable()
    {
        _healthModel.Changed -= UpdateHealthView;
    }

    private void Start()
    {
        UpdateHealthView();
    }

    private void UpdateHealthView()
    {
        _healthView.value = (float) _healthModel.Value / _healthModel.MaxValue;
    }
}