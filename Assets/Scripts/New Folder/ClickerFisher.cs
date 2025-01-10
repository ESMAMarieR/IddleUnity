using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClikerFish : MonoBehaviour
{
    //Texte score poisson
    public int score = 0;
    [SerializeField]        
    public TMP_Text scoreText;


    public int bonus1Cost = 10;
    public int bonus2Cost = 10;
    public int bonus3Cost = 10;
    private int bonusMultiplier = 1;


    public void OnButtonClick()
    {
        score++;
        UpdateScoreText();
    }

    public void BuyBonus1()
    {
        if (score >= bonus1Cost)
        {
            score -= bonus1Cost;
            bonusMultiplier++;
            UpdateScoreText();
            Debug.Log("b1 acheté");
        }
        else
        {
            Debug.Log("pas assez)");
        }
    }
    public void BuyBonus2()
    {
        if (score >= bonus2Cost)
        {
            score -= bonus2Cost;
            bonusMultiplier += 2;
            UpdateScoreText();
            Debug.Log("b2 acheté");
        }
        else
        {
            Debug.Log("pas assez)");
        }
    }

    public void BuyBonus3()
    {
        if (score >= bonus3Cost)
        {
            score -= bonus3Cost;
            bonusMultiplier += 5;
            UpdateScoreText();
            Debug.Log("b3 acheté");
        }
        else
        {
            Debug.Log("pas assez)");
        }
    }
    void UpdateScoreText()
    {
        scoreText.text = score + " ";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
