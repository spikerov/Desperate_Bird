using UnityEngine;
using UnityEngine.UI;

public class ChangeSkinScreen : MonoBehaviour
{
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private Button[] _buttonsSkin;

    private int _openSkin1 = 3;
    private int _openSkin2 = 6;
    private int _openSkin3 = 9;
    private int _openSkin4 = 12;
    private int _openSkin5 = 15;
    private int _openSkin6 = 18;
    private int _openSkin7 = 21;
    private const string _keyScore = "BestScore";

    public void Close()
    {
        _buttonClickSound.Play();
        gameObject.SetActive(false);
        _startScreen.Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    private void Start()
    {
        for (int i = 0; i < _buttonsSkin.Length; i++)
            _buttonsSkin[i].interactable = false;
    }

    private void Update()
    {
        for (int i = 0; i < _buttonsSkin.Length; i++)
        {
            if (_openSkin1 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[0].interactable = true;

            if (_openSkin2 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[1].interactable = true;

            if (_openSkin3 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[2].interactable = true;

            if (_openSkin4 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[3].interactable = true;

            if (_openSkin5 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[4].interactable = true;

            if (_openSkin6 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[5].interactable = true;

            if (_openSkin7 <= PlayerPrefs.GetInt(_keyScore))
                _buttonsSkin[6].interactable = true;
        }
    }
}
