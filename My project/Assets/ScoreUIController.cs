using UnityEngine;
using UnityEngine.UI;

public class ScoreUIController : MonoBehaviour
{
    public PlayerController playerController;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + playerController.model.score;
    }
}