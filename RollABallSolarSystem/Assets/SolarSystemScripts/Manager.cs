using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Manager : MonoBehaviour
{
    public int speedOfTime;
    public static Manager instance;

    private void Awake()
    {
        instance = this;
        speedOfTime = 10;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
    }
}
