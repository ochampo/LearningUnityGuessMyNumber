using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuessMyNum : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Give me a number");
        Debug.Log($"Hey {max} and  below");
        Debug.Log($"Hey {min} and  higer");
        Debug.Log("Tell me if your number is 500");
        Debug.Log($"guess {guess}");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("you hit up key ");
            min = guess;
            guess = (max + min) / 2;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            print("you hit down key");
            max = guess;
            guess = (max + min) / 2;
        }
       else if (Input.GetKey(KeyCode.Return))
        {
            print("you hit Enter key");
            print("you hit Enter key");
            print("you hit Enter key");
            print("you hit Enter key");
        }

    }
}
