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
    public float funding = 25; // 0-100
    public Text AAR;
    public Text Funding;
    public Text InvestorsR;
    public Text NewOldMoneyR;
    public Text AverageJoesR;
    public Text HopefulsR;
    public Text DeniersR;


    //events
    public int choiceMade = 0;


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
            Funding.text = "Funding: $" + funding;
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
        funding -= (PickRandomNumber(16) + 5);
        investors += (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void CEOOptionTwo()
    {
        funding -= (PickRandomNumber(16) + 5);
        investors += (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void CEOOptionThree()
    {
        investors += (PickRandomNumber(16) + 20);
        newOldMoney -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void CEOOptionFour()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        investors -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    
    public void AirOptionOne()
    {
        newOldMoney -= (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        funding -= (PickRandomNumber(16) + 20);
        funding += 5;
        choiceMade = 1;
    }
    public void AirOptionTwo()
    {
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        funding -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void AirOptionThree()
    {
        deniers += (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 20);
        funding += 5;
        choiceMade = 1;
    }

    public void WasteOptionOne()
    {
        newOldMoney -= (PickRandomNumber(16) + 20);
        hopefuls += (PickRandomNumber(16) + 20);
        deniers -= (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void WasteOptionTwo()
    {
        newOldMoney -= (PickRandomNumber(16) + 5);
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void WasteOptionThree()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        deniers += (PickRandomNumber(16) + 5);
        hopefuls -= (PickRandomNumber(16) + 5);
        averageJoes -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void WasteOptionFour()
    {
        newOldMoney += (PickRandomNumber(16) + 20);
        deniers += (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        funding += 5;
        choiceMade = 1;
    }

    public void LibraryOptionOne()
    {
        deniers -= (PickRandomNumber(16) + 20);
        hopefuls += (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        funding -= (PickRandomNumber(16) + 20);
        funding += 5;
        choiceMade = 1;
    }
    public void LibraryOptionTwo()
    {
        deniers -= (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        funding -= (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }
    public void LibraryOptionThree()
    {
        deniers += (PickRandomNumber(21) - 10);
        averageJoes += (PickRandomNumber(21) - 10);
        hopefuls += (PickRandomNumber(21) - 10);
        funding += 5;
        choiceMade = 1;
    }
    public void LibraryOptionFour()
    {
        deniers += (PickRandomNumber(16) + 20);
        hopefuls -= (PickRandomNumber(16) + 20);
        averageJoes += (PickRandomNumber(16) + 5);
        funding += 5;
        choiceMade = 1;
    }

    public void LandOptionOne()
    {
        averageJoes += (PickRandomNumber(16) + 5);
        choiceMade = 1;
    }
    public void LandOptionTwo()
    {
        investors += (PickRandomNumber(16) + 5);
        newOldMoney -= (PickRandomNumber(16) + 5);
        choiceMade = 1;
    }
    public void LandOptionThree()
    {
        newOldMoney += (PickRandomNumber(16) + 5);
        investors -= (PickRandomNumber(16) + 5);
        choiceMade = 1;
    }
    public void LandOptionFour()
    {
        averageJoes += (PickRandomNumber(16) + 5);
        hopefuls += (PickRandomNumber(16) + 5);
        choiceMade = 1;
    }
}
