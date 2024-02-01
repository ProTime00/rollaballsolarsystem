using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(27.3 / 365.25) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
