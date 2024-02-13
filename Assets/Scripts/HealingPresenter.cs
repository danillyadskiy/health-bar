using UnityEngine;
using UnityEngine.UI;

public class HealingPresenter : MonoBehaviour
{
    private readonly int _healingAmount = 10;
    
    [SerializeField] private Button _healthHealingView;
    [SerializeField] private HealthModel _healthModel;
    
    private void OnEnable()
    {
        _healthHealingView.onClick.AddListener(Heal);
    }
    
    private void OnDisable()
    {
        _healthHealingView.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _healthModel.Increase(_healingAmount);
    }
}