using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //If coffee is greater than the hottest temp
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("MAN! That's really hot!");
        }
        //If it isn't that hot but COLDER...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... do this.
            print("Brr, too cool brochacho!");
        }
        //If neither of those thenb...
        else
        {
            //... do this.
            print("Delious temperature!");
        }
    }
}
