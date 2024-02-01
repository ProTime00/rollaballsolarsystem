using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(1 / 365.25) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
