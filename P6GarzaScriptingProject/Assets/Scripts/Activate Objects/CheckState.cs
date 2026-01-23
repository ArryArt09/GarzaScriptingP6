using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{

    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Heirarchy: " + myObject.activeInHierarchy);
    }
    //HI CHAT WHATCHA DOING LOOKING HERE???!??

    // Update is called once per frame
    void Update()
    {
        
    }
}
