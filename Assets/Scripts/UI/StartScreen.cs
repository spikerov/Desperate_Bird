using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class StartScreen : Screen
{
    [SerializeField] private Score _score;
    [SerializeField] private TMP_Text _hightScoreText;
    [SerializeField] private Bird _bird;
    [SerializeField] private PlayScreen _playScreen;
    [SerializeField] private ChangeSkinScreen _changeSkinScreen;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private Image _buttonSoundImage;
    [SerializeField] private Sprite _spriteSoundOn;
    [SerializeField] private Sprite _spriteSoundOff;


    private const string _keyScore = "BestScore";
    private bool _isSoundOn = true;

    private void Start()
    {
        Time.timeScale = 0;
        Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);
        DisplayHightScore();
    }
    public void DisplayHightScore()
    {
        _hightScoreText.text = "Best: " + PlayerPrefs.GetInt(_keyScore);
    }

    public void OnPlayButtonClick()
    {
        _buttonClickSound.Play();
        gameObject.SetActive(false);
        _playScreen.Open();
        Time.timeScale = 1;
        _bird.ResetPlayer();
    }

    public void OnExitButtonClick()
    {
        _buttonClickSound.Play();
        Application.Quit();
    }

    public void OnSoundButtonClick()
    {
        _buttonClickSound.Play();

        if (_isSoundOn == false)
        {
            AudioListener.volume = 1f;
            _buttonSoundImage.sprite = _spriteSoundOn;
            _isSoundOn = true;
        }
        else
        {
            AudioListener.volume = 0f;
            _buttonSoundImage.sprite = _spriteSoundOff;
            _isSoundOn = false;
        }
    }

    public void OnClickButtonChangeSkin()
    {
        _buttonClickSound.Play();
        gameObject.SetActive(false);
        _changeSkinScreen.Open();
    }
}
