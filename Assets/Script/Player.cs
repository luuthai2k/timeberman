using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator m_animator;
    public GameObject player;
    public GameObject rip;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeDirection(string direction)
    {
        if(direction=="LEFT")
        {
            gameObject.transform.localPosition=new Vector3(-2.52f,gameObject.transform.localPosition.y,gameObject.transform.localPosition.z);
            gameObject.transform.rotation = Quaternion.AngleAxis(0f, Vector3.up);
        }
        if(direction=="RIGHT")
        {
            gameObject.transform.localPosition=new Vector3(1.68f,gameObject.transform.localPosition.y,gameObject.transform.localPosition.z);
            gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }
    }
    public void showcutAnimation()
    {
        m_animator.Play("Cut", 0, 0);
    }
    public void Die()
    {
        rip.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
    }
    public void respawn()
    {
        rip.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
    }
}
