using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverDialog : MonoBehaviour
{
    public Text scoreText;
    public Text bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText)
        {
            scoreText.text = GameManager.Ins.Score.ToString();
        }

        if (bestScoreText)
        {
            bestScoreText.text = Prefs.BestScore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
