using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{

    public int LevelDescription;

    // Use this for initialization
    void Start()
    {
        switch (LevelDescription)
        {
            case 1:
                print("This is Level 1, A.K.A. the Tutorial Level. Learn the basic format of the game and get a chance to take in your surroundings");
                break;

            case 2:
                print("This is Level 2.  If you know how the game works, then here you'll learn the objective for completing each level.");
                break;

            case 3:
                print("This is Level 3.  Here, you'll learn the hidden mechanics behind each tile.");
                break;

            case 4:
                print("This is Level 4. Ready for a true basics test?");
                break;

            case 5:
                print("This is Level 5.  Think you're ready?  Well, we'll just see how you deal with ENEMIES!");
                break;

            case 6:
                print("This is Level 6.  This is the culmination of all you've endured so far, so good luck.");
                break;

            default:
                print("Type the number of the level shown onscreen to read its' description.");
                break;
        }
    }
}
