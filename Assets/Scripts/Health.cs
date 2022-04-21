using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float HealthPoints = 100;

    public float HealthChangeSpeed;

    private Slider healthSlider;
    private bool healthChanged = false;

    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        // Adjust health by pressing Left or Right arrow keys
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0.1f)
        {
            healthChanged = true;
            HealthPoints += HealthChangeSpeed * Time.deltaTime;
        }

        if (horizontal < -0.1f)
        {
            healthChanged = true;
            HealthPoints -= HealthChangeSpeed * Time.deltaTime;
        }

        // Clamp HP between 0 and 100
        if (healthChanged)
        {
            HealthPoints = Mathf.Clamp(HealthPoints, 0, 100);
        }
    }

    public void IncrementHealth(float increment)
    {
        HealthPoints = Mathf.Clamp(HealthPoints + increment, 0, 100);
        healthSlider.value = HealthPoints / 100f;
    }


    void LateUpdate()
    {
        // Optimization to only change the UI if the health value changed
        if (healthChanged)
        {
            healthChanged = false;
            healthSlider.value = HealthPoints / 100f;
        }
    }
}
