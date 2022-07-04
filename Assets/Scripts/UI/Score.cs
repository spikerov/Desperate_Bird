using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _scoreText;

    private int _score;
    private const string _keyScore = "BestScore";

    public int PointsScored => _score;

    private void OnEnable()
    {
        _bird.ScoreChanged += OnScoreChange;
    }

    private void OnDisable()
    {
        _bird.ScoreChanged -= OnScoreChange;
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey(_keyScore) == false)
            PlayerPrefs.SetInt(_keyScore, 0);
    }

    private void OnScoreChange(int score)
    {
        _score = score;
        _scoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt(_keyScore))
        {
            PlayerPrefs.SetInt(_keyScore, score);
        }
    }
}
