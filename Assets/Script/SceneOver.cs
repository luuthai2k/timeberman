using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneOver : MonoBehaviour
{
    public Text bestScore;
    public Text xtxScore;
    public Game Game;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int scoreValue, bestScoreValue;
        if (int.TryParse(score.text, out scoreValue) && int.TryParse(bestScore.text, out bestScoreValue))
        {
            if (scoreValue > bestScoreValue)
            {
                bestScoreValue = scoreValue;
            }
            xtxScore.text = score.text;
            bestScore.text = bestScoreValue.ToString();
        }

    }
    public void PlayAgain()
    {
        Game.ReSet();
        hide();
        score.text = 0 +"";
    }
    public void show()
    {
        gameObject.SetActive(true);
    }
    public void hide()
    {
        gameObject.SetActive(false);
    }
}
