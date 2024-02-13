using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothBarPresenter : MonoBehaviour
{
    [SerializeField] private Slider _healthView;
    [SerializeField] private HealthModel _healthModel;
    
    private void Update()
    {
        float current = _healthView.value;
        float target = (float) _healthModel.Value / _healthModel.MaxValue;
        
        _healthView.value = Mathf.MoveTowards(current, target, Time.deltaTime);
    }
}