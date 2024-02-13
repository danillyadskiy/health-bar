using UnityEngine;
using UnityEngine.UI;

public class DamagePresenter : MonoBehaviour
{
    private readonly int _damageAmount = 10;
    
    [SerializeField] private Button _healthDamageView;
    [SerializeField] private HealthModel _healthModel;
    
    private void OnEnable()
    {
        _healthDamageView.onClick.AddListener(Damage);
    }
    
    private void OnDisable()
    {
        _healthDamageView.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        _healthModel.Decrease(_damageAmount);
    }
}