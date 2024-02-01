using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(1 / (365.25 * 1.89)) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
