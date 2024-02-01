using UnityEngine;

public class Neptune : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(1 / (365.25 * 164.79)) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
