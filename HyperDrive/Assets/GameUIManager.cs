using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : Singleton<GameUIManager>
{
    public GameObject gameUi;
    public GameObject homeUi;
    public Text countingText;
    public Text scoreCountingText;
    public GameObject gameOverDialog;
    public GameObject pauseDialog;

    private void Awake()
    {
        MakeSingleton(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameUI(bool isShow)
    {
        if (gameUi)
        {
            gameUi.SetActive(isShow);
        }

        if (homeUi)
        {
            homeUi.SetActive(!isShow);
        }
    }

    public void UpdateTimeCounting(float time)
    {
        if (countingText)
        {
            countingText.gameObject.SetActive(true);
            countingText.text = time.ToString();
            if(time <= 0)
            {
                countingText.gameObject.SetActive(false);
            }
        }
    }

    public void UpdateScoreCounting(int score)
    {
        if (scoreCountingText)
        {
            scoreCountingText.text = "Score : " + score.ToString();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        if (pauseDialog)
        {
            pauseDialog.SetActive(true);
        }
    }
}
