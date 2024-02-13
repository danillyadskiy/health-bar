using TMPro;
using UnityEngine;

public class HealthTextPresenter : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentHealthView;
    [SerializeField] private TMP_Text _maxHealthView;
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
        UpdateMaxHealthView();
    }

    private void UpdateHealthView()
    {
        _currentHealthView.text = _healthModel.Value.ToString();
    }
    
    private void UpdateMaxHealthView()
    {
        _maxHealthView.text = _healthModel.MaxValue.ToString();
    }
}