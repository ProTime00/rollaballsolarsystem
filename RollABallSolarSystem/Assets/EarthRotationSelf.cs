using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotationSelf : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
