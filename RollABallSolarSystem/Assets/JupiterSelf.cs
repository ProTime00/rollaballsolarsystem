using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterSelf : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)2.25 * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
