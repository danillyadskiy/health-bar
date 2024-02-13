using System.Collections;
using UnityEngine;

public class HealthAnalogBarPresenter : HealthBarPresenter
{
    private Coroutine _coroutine;
    
    protected override void UpdateHealthView()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(UpdateHealthViewSmoothly());
    }

    private IEnumerator UpdateHealthViewSmoothly()
    {
        float current = HealthView.value;
        float target = HealthModel.RelativeValue;
        
        while (current != target)
        {
            current = HealthView.value = Mathf.MoveTowards(current, target, Time.deltaTime);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}