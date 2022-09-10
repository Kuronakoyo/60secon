using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class oppai : MonoBehaviour
{
    public Text ScoreText;
    int score;
   
    // Use this for initialization
    void Start()
    {
        score = Click.getscore();
        ScoreText.text = string.Format("‚ ‚È‚½‚ªƒ{ƒ^ƒ“‰Ÿ‚µ‚½‰ñ”‚Í{0}‰ñ", score);
    }

    // Update is called once per frame
    void Update()
    {

       

    }
    public void chinchin()
    {
        SceneManager.LoadScene("Tillte");
    }
}
