using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public float angularSpeed;

    // Update is called once per frame
    void Update()
    {
        float xRotation = x * angularSpeed * Time.deltaTime;
        float yRotation = y * angularSpeed * Time.deltaTime;
        float zRotation = z * angularSpeed * Time.deltaTime;
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
