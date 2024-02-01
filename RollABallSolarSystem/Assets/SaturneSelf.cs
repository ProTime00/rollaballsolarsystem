using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturneSelf : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)2.2 * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
