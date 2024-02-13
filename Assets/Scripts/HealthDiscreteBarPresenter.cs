public class HealthDiscreteBarPresenter : HealthBarPresenter
{
    protected override void UpdateHealthView()
    {
        HealthView.value = HealthModel.RelativeValue;
    }
}