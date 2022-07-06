using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float investors = 50; // 0-100
    public float newOldMoney = 50;
    public float averageJoes = 50;
    public float hopefuls = 50;
    public float deniers = 50;
    public float averageApprovalRating = 0;
    public float budget = 20000;
    public Text AAR;
    public Text Budget;
    public Text InvestorsR;
    public Text NewOldMoneyR;
    public Text AverageJoesR;
    public Text HopefulsR;
    public Text DeniersR;
    public GameObject CEO;
    public GameObject Air;
    public GameObject Waste;
    public GameObject Library;
    public GameObject Land;
    public GameObject GameOver;
    public GameObject GameWin;


    //events
    public int choiceMade = 0;
    public int round = 1;
    public int dangerCount = 0;
    public bool dangerZone = false;
    public bool gameOver = false;


//a choice is prompted to the user that they have to decide whether they go along with the task or do something else. this will change the ratings from each group of people negatively or positively. 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // minor = rnd.Next(16) + 5;
    // middle = rnd.Next(16) + 20;
    // major = rnd.Next(16) + 40;
        if (investors < 1)
        {
            investors = 0;
        } else if (investors > 100)
        {
            investors = 100;
        }
        if (newOldMoney < 1)
        {
            newOldMoney = 0;
        } else if (newOldMoney > 100)
        {
            newOldMoney = 100;
        }
        if (averageJoes < 1)
        {
            averageJoes = 0;
        } else if (averageJoes > 100)
        {
            averageJoes = 100;
        }
        if (hopefuls < 1)
        {
            hopefuls = 0;
        } else if (hopefuls > 100)
        {
            hopefuls = 100;
        }
        if (deniers < 1)
        {
            deniers = 0;
        } else if (deniers > 100)
        {
            deniers = 100;
        }
        if (choiceMade > 0)
        {
            averageApprovalRating = (investors + newOldMoney + averageJoes + hopefuls + deniers)/5;
            AAR.text = "Overall Approval Rating: " + averageApprovalRating;
            Budget.text = "Budget: $" + budget;
            dangerCount = 0;
            if (investors < 21)
            {
                dangerCount++;
            }
            if (newOldMoney < 21)
            {
                dangerCount++;
            }
            if (averageJoes < 21)
            {
                dangerCount++;
            }
            if (hopefuls < 21)
            {
                dangerCount++;
            }
            if (deniers < 21)
            {
                dangerCount++;
            }
            if (dangerCount == 2)
            {
                dangerZone = true;
            }
            if (dangerZone == true && round < 6)
            {
                CEO.SetActive(false);
                Air.SetActive(false);
                Waste.SetActive(false);
                Library.SetActive(false);
                Land.SetActive(false);
                GameOver.SetActive(true);
            }
            if (round == 6)
            {
                GameWin.SetActive(true);
            }
            if ( dangerCount >= 3)
            {
                gameOver = true;
            }
            choiceMade = 0;
        }
        InvestorsR.text = "Investors: " + investors;
        NewOldMoneyR.text = "New Old Money: " + newOldMoney;
        AverageJoesR.text = "Average Joes: " + averageJoes;
        HopefulsR.text = "Hopefuls: " + hopefuls;
        DeniersR.text = "Deniers: " + deniers;

        
        
    }

    private int PickRandomNumber(int maxInt){
        int randomNum = Random.Range(1, maxInt);
        return randomNum;
    }

    public void CEOOptionOne()
    {
        budget -= (PickRandomNumber(16000) + 5000);
        investors += (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void CEOOptionTwo()
    {
        budget -= (PickRandomNumber(16000) + 5000);
        investors += (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void CEOOptionThree()
    {
        investors += (PickRandomNumber(16) + 20);
        newOldMoney -= (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void CEOOptionFour()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        investors -= (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    
    public void AirOptionOne()
    {
        newOldMoney -= (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        budget -= (PickRandomNumber(16000) + 5000);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void AirOptionTwo()
    {
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        budget -= (PickRandomNumber(16000) + 5000);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void AirOptionThree()
    {
        deniers += (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 20);
        budget += 5000;
        choiceMade = 1;
        round++;
    }

    public void WasteOptionOne()
    {
        newOldMoney -= (PickRandomNumber(16) + 20);
        hopefuls += (PickRandomNumber(16) + 20);
        deniers -= (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void WasteOptionTwo()
    {
        newOldMoney -= (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void WasteOptionThree()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        deniers += (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 5);
        averageJoes -= (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void WasteOptionFour()
    {
        newOldMoney += (PickRandomNumber(16) + 20);
        deniers += (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        budget += 5000;
        choiceMade = 1;
        round++;
    }

    public void LibraryOptionOne()
    {
        deniers -= (PickRandomNumber(16) + 20);
        hopefuls += (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        budget -= (PickRandomNumber(16000) + 5000);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void LibraryOptionTwo()
    {
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        budget -= (PickRandomNumber(16000) + 5000);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void LibraryOptionThree()
    {
        deniers += (PickRandomNumber(21) - 10);
        averageJoes += (PickRandomNumber(21) - 10);
        hopefuls += (PickRandomNumber(21) - 10);
        budget += 5000;
        choiceMade = 1;
        round++;
    }
    public void LibraryOptionFour()
    {
        deniers += (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        budget += 5000;
        choiceMade = 1;
        round++;
    }

    public void LandOptionOne()
    {
        averageJoes += (PickRandomNumber(16) + 5);
        choiceMade = 1;
        round++;
    }
    public void LandOptionTwo()
    {
        investors += (PickRandomNumber(16) + 5);
        newOldMoney -= (PickRandomNumber(16) + 5);
        choiceMade = 1;
        round++;
    }
    public void LandOptionThree()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        investors -= (PickRandomNumber(16) + 5);
        choiceMade = 1;
        round++;
    }
    public void LandOptionFour()
    {
        averageJoes += (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        choiceMade = 1;
        round++;
    }
}
