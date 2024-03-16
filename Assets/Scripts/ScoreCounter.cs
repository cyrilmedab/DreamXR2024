using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    [SerializeField] private TextMeshPro scoreText;
    [SerializeField] private int score;

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
    }

    public void IncreaseScore()
    {
        score += 1;
        DisplayScore();
    }

    public void ResetScore()
    {
        score = 0;
        DisplayScore();
    }

    private void DisplayScore()
    {
        scoreText.text = $"Combo: {score}";
    }
}
