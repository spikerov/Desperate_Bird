using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ChangeBirdSkin : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteToChange;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private Animator _animator;
    [SerializeField] private Sprite _spriteSkinBase;
    [SerializeField] private Sprite _spriteSkin1;
    [SerializeField] private Sprite _spriteSkin2;
    [SerializeField] private Sprite _spriteSkin3;
    [SerializeField] private Sprite _spriteSkin4;
    [SerializeField] private Sprite _spriteSkin5;
    [SerializeField] private Sprite _spriteSkin6;
    [SerializeField] private Sprite _spriteSkin7;

    private const string _animatoinBird0 = "Bird0";
    private const string _animatoinBird1 = "Bird1";
    private const string _animatoinBird2 = "Bird2";
    private const string _animatoinBird3 = "Bird3";
    private const string _animatoinBird4 = "Bird4";
    private const string _animatoinBird5 = "Bird5";
    private const string _animatoinBird6 = "Bird6";
    private const string _animatoinBird7 = "Bird7";

    public void ChangeSkin(int skinNumber)
    {
        _buttonClickSound.Play();

        switch (skinNumber)
        {
            case 0:
                _spriteToChange.sprite = _spriteSkinBase;
                _animator.Play(_animatoinBird0);
                break;
            case 1:
                _spriteToChange.sprite = _spriteSkin1;
                _animator.Play(_animatoinBird1);
                break;
            case 2:
                _spriteToChange.sprite = _spriteSkin2;
                _animator.Play(_animatoinBird2);
                break;
            case 3:
                _spriteToChange.sprite = _spriteSkin3;
                _animator.Play(_animatoinBird3);
                break;
            case 4:
                _spriteToChange.sprite = _spriteSkin4;
                _animator.Play(_animatoinBird4);
                break;
            case 5:
                _spriteToChange.sprite = _spriteSkin5;
                _animator.Play(_animatoinBird5);
                break;
            case 6:
                _spriteToChange.sprite = _spriteSkin6;
                _animator.Play(_animatoinBird6);
                break;
            case 7:
                _spriteToChange.sprite = _spriteSkin7;
                _animator.Play(_animatoinBird7);
                break;
            default:
                Debug.Log("Wrang skin number");
                break;
        }
    }
}
