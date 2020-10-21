using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 1;
        int max = 1000;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Think of a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Press up arrow for higher, down arrow for lower, and enter if my guess is correct");

    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
