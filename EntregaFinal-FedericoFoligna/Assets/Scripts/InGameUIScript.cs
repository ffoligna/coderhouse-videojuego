using UnityEngine;
using UnityEngine.UI;

public class InGameUIScript : MonoBehaviour
{
    public Text playerScore;
    public Text playerHealth;

    void Start()
    {
        
    }

    void Update()
    {
        playerScore.text = "Score: " + AmyCharacter.score.ToString();
        playerHealth.text = "HP: " + AmyCharacter.health.ToString();
    }
}
