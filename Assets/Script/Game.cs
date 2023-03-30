using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Game : MonoBehaviour
{
    public Player player;
    public Truckmanager truckmanager;
    public Gui gui;
    private float totalTime = 10f;
    private float curentTime;
    private bool isOver = false;
    private int score = 0;
    public SceneOver sceneOver;

    // Start is called before the first frame update
    void Start()
    {
        curentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOver) return;
        curentTime -= Time.deltaTime;
        gui.SetBar(curentTime / totalTime);
       
        if(curentTime<=0)
        {
            isOver = true;
            player.Die();
            sceneOver.gameObject.SetActive(true);
        }
    }
    public void OnTap(string diretion)
       
    {
        if (isOver) return;
       player.changeDirection(diretion);
        player.showcutAnimation();
        if(diretion==truckmanager.getDirectionFirstTruck())
        {
            player.Die();
            isOver = true;
            sceneOver.gameObject.SetActive(true);
        }
        else
        {
           truckmanager.cutFirstTruck();
            if(diretion == truckmanager.getDirectionFirstTruck())
            {
                player.Die();
                isOver = true;
                sceneOver.gameObject.SetActive(true);

            }
            else
            {
                score++;
                gui.setScore(score);
                curentTime += 0.15f;
            }
        }
        
    }
    public void ReSet()
    {
        isOver = false;
        score = 0;
        curentTime = totalTime;
        player.respawn();
        truckmanager.ReSet();
    }
}
