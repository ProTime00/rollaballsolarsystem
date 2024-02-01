using UnityEngine;

public class Manager : MonoBehaviour
{
    public int speedOfTime;
    public static Manager instance;

    private void Awake()
    {
        instance = this;
        speedOfTime = 10;
    }
    
}
