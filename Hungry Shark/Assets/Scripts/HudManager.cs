using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HudManager : MonoBehaviour {
    //Initializing variables
    public Text playerScore;
    string scoreFormat = "0#";
    public int scoreCountPlayer;

    private void Update()
    {
        UpdateHud();
    }

    void UpdateHud()
    {
        //Storing the text for hud
        playerScore.text = "Player: " + scoreCountPlayer.ToString(scoreFormat);
    }

    public void IncreasePlayerScore()
    {
        //Increase score if player gets a Sphere.
        scoreCountPlayer++;
        UpdateHud();
    }

}
