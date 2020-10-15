using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public Text lives;
   public Text score;
    public int livesNum = 0;
    public int scoreNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        lives.text = $"{lives.text} {livesNum}";
        score.text = $"{score.text} {scoreNum}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Success()   
    {
        
        scoreNum++;
        score.text = ("Score: ");
        score.text = score.text + scoreNum;  
        
    }
    public void Success2()
    {

        scoreNum++;
        score.text = ("Score: ");
        score.text = score.text + scoreNum;

    }
    public void Fail()
    {
        livesNum = livesNum - 1;
        lives.text = ("Lives: ");  
        lives.text = lives.text + livesNum;
        if (livesNum <= 0)
        {
            // End Game
            lives.text = ("GAME OVER");
            GameObject spawn = GameObject.FindGameObjectWithTag("Spawn");
            Destroy(spawn);
        }
        

    }
}
