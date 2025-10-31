using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //Create an integer variable.
    public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Running my Integer through a function
        myInt = MultiplyByTwo(myInt);

        //Display the result uin the console
        Debug.Log(myInt);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //creating a function
    int MultiplyByTwo(int number)
    {

        //create a results variable
        int result;
        result = number * 2;

        //return the result
        return result;
        }
}
