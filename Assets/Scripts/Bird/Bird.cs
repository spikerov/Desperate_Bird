using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    [SerializeField] private AudioSource _pointSound;
    [SerializeField] private AudioSource _dieSound;

    private BirdMover _mover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _mover = GetComponent<BirdMover>(); 
    }

    public void IncreaseScore()
    {
        _score++;
        _pointSound.Play();
        ScoreChanged?.Invoke(_score); 
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score); 
        _mover.ResetBird();
    }

    public void Die()
    {
        _dieSound.Play();
        GameOver?.Invoke(); 
    }
}
