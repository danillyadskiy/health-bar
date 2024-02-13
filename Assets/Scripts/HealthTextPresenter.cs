using TMPro;
using UnityEngine;

public class HealthTextPresenter : HealthPresenter
{
    [SerializeField] private TMP_Text _currentHealthView;
    [SerializeField] private TMP_Text _maxHealthView;

    private void Start()
    {
        UpdateHealthView();
        UpdateMaxHealthView();
    }

    protected override void UpdateHealthView()
    {
        _currentHealthView.text = HealthModel.Value.ToString();
    }
    
    private void UpdateMaxHealthView()
    {
        _maxHealthView.text = HealthModel.MaxValue.ToString();
    }
}