using UnityEngine;

public class SceneManager : MonoBehaviour
{
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
