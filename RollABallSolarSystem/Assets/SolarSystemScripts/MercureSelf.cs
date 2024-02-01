using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercureSelf : MonoBehaviour
{
    private Manager instance;
    private void Start()
    {
        instance = Manager.instance;
    }

    void FixedUpdate()
    {
        float angle = (float)(1 / 59) * instance.speedOfTime;
        transform.Rotate(Vector3.up, angle);
    }
}
