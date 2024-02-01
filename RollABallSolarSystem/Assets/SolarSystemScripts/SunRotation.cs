using UnityEngine;

public class SunRotation : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = 1/27f * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
