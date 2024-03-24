using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls: MonoBehaviour
{
    //Timer text object
    private Text timerText;
    //Time counter for adding score
    private int timerCount;
    // Start is called before the first frame update
    void Start()
    {
        //game is at a playing state
        Time.timeScale = 1f;
        //executing a courtine
        StartCoroutine(CountTime());
        //time text equals finding
        //the score object and using
        //the text component
        timerText = GameObject.Find("Score").GetComponent<Text>();
    }

   IEnumerator CountTime() 
    {
        //After one second 1 point is added to the score and will repeat the function
        yield return new WaitForSeconds(1f);
        timerCount++;
        timerText.text = "Score: " + timerCount;
        StartCoroutine(CountTime());
    }
}
