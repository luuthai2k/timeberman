using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gui : MonoBehaviour
{
    public Text txtScore;
    public Image barRed;
    void Start()
    {
        SetBar(0f);
    }
    public void setScore(int value)
    {
        txtScore.text = value + "";
    }
    public void SetBar(float percent)
    {
        float total = 94.2f;
        float p = total - (percent * total);
        barRed.transform.localPosition = new Vector3(0.2f- p, barRed.transform.localPosition.y, barRed.transform.localPosition.z);
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
