using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public static int currentCount;
    public int highScore;
    public Text textHighScore;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        currentCount = 0;
        textScore.text = currentCount.ToString();
        highScore = PlayerPrefs.GetInt("highScore");
        textHighScore.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCount > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", currentCount);
        }
        textHighScore.text = highScore.ToString();
        textScore.text = currentCount.ToString();
    }

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void resetScore()
    {
        PlayerPrefs.SetInt("highScore", 0);
        highScore = 0;
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
