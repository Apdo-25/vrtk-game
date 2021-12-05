using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public GameObject TimerText;
    public float resetDelay;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)

        {
            SceneManager.LoadScene("MenuScene");
        }
    }


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

    }
    public void Win()
    {
        Time.timeScale = 0;
        TimerText.SetActive(false);
        Invoke("Reset", resetDelay);
    }

    void Reset()
    {
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}