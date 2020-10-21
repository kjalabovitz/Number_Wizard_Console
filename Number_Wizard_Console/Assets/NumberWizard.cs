using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame ()
    {
        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Behold! I am the all-knowing Number Wizard!");
        Debug.Log("You will do as I command! Think of a number between " + min + " and " + max);
        Debug.Log("I will now guess your number! Is it higher or lower than 500?");
        Debug.Log("Press up arrow for higher, down arrow for lower, and enter if my guess is correct");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Higher, eh? You're certain of that?");
            min = guess;
            NextGuess();
            Debug.Log("Very well! Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Lower? I will know if you're lying to me!");
            max = guess;
            NextGuess();
            Debug.Log("I'm seeing your number in my mind! " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Behold! I know all!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
