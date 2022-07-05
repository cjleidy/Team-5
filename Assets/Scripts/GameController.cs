using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float investors = 50; // 0-100
    public float newOldMoney = 50;
    public float averageJoes = 50;
    public float hopefuls = 50;
    public float deniers = 50;
    public float gameRound = 0;
    public float funding = 20; // 0-100

    //events
    public bool eventCEO = false;
        public bool CEOoptionOne = false;
        public bool CEOoptionTwo = false;
        public bool CEOoptionThree = false;
        public bool CEOoptionFour = false;
    public bool eventAir = false;
        public bool airOptionOne = false;
        public bool airOptionTwo = false;
        public bool airOptionThree = false;
    public bool eventWaste = false;
        public bool wasteOptionOne = false;
        public bool wasteOptionTwo = false;
        public bool wasteOptionThree = false;
        public bool wasteOptionFour = false;
    public bool eventLibrary = false;
        public bool libraryOptionOne = false;
        public bool libraryOptionTwo = false;
        public bool libraryOptionThree = false;
        public bool libraryOptionFour = false;
    public bool eventLand = false;


//a choice is prompted to the user that they have to decide whether they go along with the task or do something else. this will change the ratings from each group of people negatively or positively. 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    // minor = rnd.Next(16) + 5;
    // middle = rnd.Next(21) + 20;
    // major = rnd.Next(21) + 40;
        if (eventCEO == true){
            //set event object active
            if (CEOoptionOne == true){
                funding -= (PickRandomNumber(16) + 5);
                investors += (PickRandomNumber(16) + 5);
            }else if (CEOoptionTwo == true){
                funding -= (PickRandomNumber(16) + 5);
                investors += (PickRandomNumber(16) + 5);
                hopefuls += (PickRandomNumber(16) + 5);
                deniers -= (PickRandomNumber(16) + 5);
            }

        }
    }

    private int PickRandomNumber(int maxInt){
        int randomNum = Random.Range(1, maxInt);
        return randomNum;
    }
}
