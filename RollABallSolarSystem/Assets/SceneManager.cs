using System;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 120;
        Screen.SetResolution(2560, 1600, FullScreenMode.FullScreenWindow);
    }

    public void LoadSolarSystem()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SolarSystem");
    }

    public void LoadRollABall()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/RollABall");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
