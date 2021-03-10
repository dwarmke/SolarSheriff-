using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueMaster : MonoBehaviour
{

    // This is what displays the clues. 
    public Text ClueText;
// This is a list of all the different destination clues lists. 
public List<List<string>> ClueDestinations;

//These hold clues for each planet/location. Modify in inspector.
public List<string> MarsClues;
public List<string> LEOClues; 
public List<string> LunaClues;
public List<string> SuspectClues;

private string _Clue;

private List<string> _CurentClues; 

private string _GenderProNoun;

public bool Woman;
public bool Man;

public bool NonBinary;

public bool DestinationMars; 
public bool DestinationLEO;
public bool DestinationLuna;
public bool DestinationSuspect; 

private int index;


    void Start()
    {
        //Bool is used to assign gender pronouns (pick one in GUI)
        if(Woman == true)
        {
            _GenderProNoun = "She ";
        }
        if(Man == true)
        {
            _GenderProNoun = "He ";
        }
        
        if(NonBinary == true)
        {
            _GenderProNoun = "They ";
        }

        //Set up planetary destination clues, modify in GUI. 
        if(DestinationMars == true)
        {
            _CurentClues = MarsClues;
        }
        
         if(DestinationLEO == true)
        {
            _CurentClues = LEOClues;
        }

        if (DestinationLuna == true)
        {
            _CurentClues = LunaClues;
        }

        if (DestinationSuspect == true)
        {
            _CurentClues = SuspectClues;
        }

    }

    //PopClue called by location buttons. 
    public void PopClue()
    {
        
        _Clue = _CurentClues[Random.Range(0,MarsClues.Count)];
        
        ClueText.text = (_GenderProNoun + _Clue);
        MarsClues.Remove(_Clue);
        //Clues are permanently removed. Make sure players don't double back or fix.
    }
 
    
}
