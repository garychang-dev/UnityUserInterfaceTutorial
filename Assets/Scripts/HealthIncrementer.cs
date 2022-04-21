using UnityEngine;

public class HealthIncrementer : MonoBehaviour
{
    [SerializeField]
    private Health healthComponent;

    private float incrementValue;

    public void OnValueChanged(float value)
    {
        incrementValue = value;
    }

    public void OnIncrementClicked()
    {
        healthComponent.IncrementHealth(incrementValue);
    }
}
