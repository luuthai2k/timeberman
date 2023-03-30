using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startgame : MonoBehaviour
{
    public Game game;
    // Start is called before the first frame update
    void Start()
    {
        game.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        gameObject.SetActive(false);
        game.gameObject.SetActive(true);
    }
}
