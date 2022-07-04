using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    [SerializeField] private Bird _bird;
    [SerializeField] private PlayScreen _playScreen;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private Score _score;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _hightScoreText;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private PipeGenerator _pipeGenerator;

    private const string _keyScore = "BestScore";

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void Open()
    {
        gameObject.SetActive(true);
        DisplayHightScore();
    }

    public void DisplayHightScore()
    {
        _scoreText.text = "Score: " + _score.PointsScored;
        _hightScoreText.text = "Best: " + PlayerPrefs.GetInt(_keyScore);
    }

    public void OnRestartButtonClick()
    {
        _buttonClickSound.Play();
        Time.timeScale = 1;
        _pipeGenerator.ResetTool();
        _bird.ResetPlayer();
        gameObject.SetActive(false);
        _playScreen.Open();
    }

    public void OnMainMenuButtonClick()
    {
        _buttonClickSound.Play();
        gameObject.SetActive(false);
        _startScreen.Open();
    }
}
