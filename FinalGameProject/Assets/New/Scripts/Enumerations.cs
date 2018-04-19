using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enumerations : MonoBehaviour
{
    public Text text;
    public enum Difficulty {Difficulty_Select, Shameful, Easy, Medium, Hard, Psychotic};
    private Difficulty myDifficulty;
    // Use this for initialization
    void Start()
    {
        myDifficulty = Difficulty.Difficulty_Select;
    }

    // Update is called once per frame
    void Update()
    {
        if (myDifficulty == Difficulty.Difficulty_Select)
        {
            Difficulty_Select();
        }

        else if (myDifficulty == Difficulty.Shameful)
        {
            Shameful();
        }

        else if (myDifficulty == Difficulty.Easy)
        {
            Easy();
        }

        else if (myDifficulty == Difficulty.Medium)
        {
            Medium();
        }

        else if (myDifficulty == Difficulty.Hard)
        {
            Hard();
        }

        else if (myDifficulty == Difficulty.Psychotic)
        {
            Psychotic();
        }
    }

    void Difficulty_Select()
    {
        text.text = "Choose Your Difficulty \n\n" +
            "Press the 1st Letter of the Difficulty you desire... \n\n" +
            "Shameful" +
            "Easy" +
            "Medium" +
            "Hard" +
            "Psychotic";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myDifficulty = Difficulty.Shameful;
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            myDifficulty = Difficulty.Easy;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myDifficulty = Difficulty.Medium;
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            myDifficulty = Difficulty.Hard;
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            myDifficulty = Difficulty.Psychotic;
        }
    }

    private void Shameful()
    {
        text.text = "You chose the Shameful Difficulty." +
            "You only get the first level: and it just repeats ENDLESSLY! \n\n" +
            "Are You Sure About This? \n\n" +
            " Press Y for Yes or N for No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("FirstScene");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myDifficulty = Difficulty.Difficulty_Select;
        }
    }

    private void Easy()
    {
        text.text = "You chose the Easy Difficulty." +
            "For those who don't play video games like it's their career. \n\n" +
            "Are You Sure About This? \n\n" +
            " Press Y for Yes or N for No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("FirstScene");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myDifficulty = Difficulty.Difficulty_Select;
        }
    }

    private void Medium()
    {
        text.text = "You chose the Medium Difficulty." +
            "An average difficulty for the average player. \n\n" +
            "Are You Sure About This? \n\n" +
            " Press Y for Yes or N for No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("FirstScene");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myDifficulty = Difficulty.Difficulty_Select;
        }
    }

    private void Hard()
    {
        text.text = "You chose the Hard Difficulty." +
            "Ready for a challenge?  Then this difficulty is for you. \n\n" +
            "Are You Sure About This? \n\n" +
            " Press Y for Yes or N for No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("FirstScene");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myDifficulty = Difficulty.Difficulty_Select;
        }
    }

    private void Psychotic()
    {
        text.text = "You chose the Psychotic Difficulty." +
            "I'll be amazed if you pass Level 1.  Yeah, it's THAT hard. \n\n" +
            "Are You Sure About This? \n\n" +
            " Press Y for Yes or N for No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("FirstScene");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myDifficulty = Difficulty.Difficulty_Select;
        }
    }
}