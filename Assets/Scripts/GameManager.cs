using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int score;
    public bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

}
