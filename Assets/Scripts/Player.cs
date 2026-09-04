using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Member variables can be rederred to as fields, whatever that means.
    private int experience;

    public int Expereience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }


    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health
    {
        get; set;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
