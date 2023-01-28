using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Rigidbody ballin;
    public int TotalRings;
    public int ringsCollected;
    public bool isDesertGoalTileActivated;
    public bool gameover;

    public TMP_Text ringsCollectedText;
    private GameObject goalTile;
    private GameObject mountainRing;


    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Start()
    {
        ringsCollectedText.text = "Rings collected : " + ringsCollected;
        isDesertGoalTileActivated = false;
        ringsCollected = 0;
        ballin = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        goalTile = GameObject.FindGameObjectWithTag("GoalTile");
        TotalRings = GameObject.FindObjectsOfType<PickupTriggerWorking>().Length;
        mountainRing = GameObject.FindGameObjectWithTag("Ring");

    }

    public bool desertGoal()
    {
        isDesertGoalTileActivated = true;
        return isDesertGoalTileActivated;
    }
    public void pickup()
    {
        if (gameover) return;

        ringsCollected++;
        ringsCollectedText.text = "Rings collected : " + ringsCollected; 
    }

    public bool endGame()
    {
        if (ringsCollected >= 3) gameover = true;  
        return gameover;   
    }

    public void goalreached()
    {
        endGame();
      
    }

    // Is it game over
    public bool isGameOver()
    {
        return gameover;
    }

    // Set the game over state to true
    public void setGameOver()
    {
        gameover = true;
        
    }
    private static GameManager instance = null;
    void Awake()
    {
        if (instance)
        {
            Debug.Log("already an instance so destroying new one");
            DestroyImmediate(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
