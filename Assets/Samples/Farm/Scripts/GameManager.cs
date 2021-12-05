using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public GameObject TimerText;
    public GameObject keyText;
    public GameObject youWinText;
    public float resetDelay;

    void Update()
    {

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
        keyText.SetActive(false);
        youWinText.SetActive(true);

        Invoke("Reset", resetDelay);
    }

    void Reset()
    {
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}