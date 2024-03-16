using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    [SerializeField] private TextMeshPro scoreText;
    [SerializeField] private TextMeshPro highScoreText;

    [SerializeField] private int score;
    [SerializeField] private int highScore;

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;

        UpdateScoreDisplay();
        UpdateHighScoreDisplay();
    }

    public void IncreaseScore()
    {
        score += 1;
        UpdateScoreDisplay();

        if (score > highScore)
        {
            highScore = score;
            UpdateHighScoreDisplay();
        }
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = $"Combo: {score}";
    }

    private void UpdateHighScoreDisplay()
    {
        highScoreText.text = $"High Score: {highScore}";
    }
}
