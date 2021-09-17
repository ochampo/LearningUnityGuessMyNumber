using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuessMyNum : MonoBehaviour
{
    int max ;
    int min ;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
       


    }



    void StartGame()
    {
        int max = 1000;
        int min = 1;
        int guess = 500;
        Debug.Log("Give me a number");
        Debug.Log($"Hey {max} and  below");
        Debug.Log($"Hey {min} and  higer");
        Debug.Log("Tell me if your number is 500");
        Debug.Log($"guess {guess}");
        max = max + 1;




    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("you hit up key ");
            NextGuess();
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            print("you hit down key");
            NextGuess();


        }
       else if (Input.GetKey(KeyCode.Return))
        {
            print("you hit Enter key");
            
        }

    }

    void NextGuess()
    {
        max = guess;
        guess = (max + min) / 2;
    }




}
