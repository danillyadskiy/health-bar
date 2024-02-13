using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthAnalogBarPresenter : HealthBarPresenter
{
    private IEnumerator _coroutine;
    
    protected override void UpdateHealthView()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = Coroutine();
        StartCoroutine(_coroutine);
    }

    private IEnumerator Coroutine()
    {
        float current = HealthView.value;
        float target = TargetHealth;
        
        while (current != target)
        {
            current = HealthView.value = Mathf.MoveTowards(current, target, Time.deltaTime);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}