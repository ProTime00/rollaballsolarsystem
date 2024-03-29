using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturne : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(1 / (365.25 * 29.45)) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
