using UnityEngine;
using UnityEngine.UI;

public class PlayScreen : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameOverScreen _gameOverScreen;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private Image _buttonPauseImage;
    [SerializeField] private Sprite _spritePauseOn;
    [SerializeField] private Sprite _spritePauseOff;

    private bool _isPauseOn = true;

    private void OnEnable()
    {
        _bird.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _bird.GameOver -= OnGameOver;
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void OnButtonClickPause()
    {
        _buttonClickSound.Play();

        if (_isPauseOn == false)
        {
            Time.timeScale = 1;
            _buttonPauseImage.sprite = _spritePauseOff;
            _isPauseOn = true;
        }
        else
        {
            Time.timeScale = 0;
            _buttonPauseImage.sprite = _spritePauseOn;
            _isPauseOn = false;
        }
    }

    private void OnGameOver()
    {
        Time.timeScale = 0;
        gameObject.SetActive(false);
        _gameOverScreen.Open();
    }
}
