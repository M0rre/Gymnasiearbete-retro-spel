using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreOneText.text = scoreOne;
        scoreTwoText.text = scoreTwo;
        UpdateScore(0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int PlayerOneScore; 
    public int PlayerTwoScore;
