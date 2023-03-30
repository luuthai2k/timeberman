using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tap : MonoBehaviour
{
    public string direction;
    public Game game;

   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.RightArrow)&& direction=="RIGHT")
        {

            game.OnTap(direction);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)&& direction=="LEFT")
        {

            game.OnTap(direction);
        }

    }
     private void OnMouseDown()
     {
        game.OnTap(direction);
        Debug.Log("TAP");
     }
}
