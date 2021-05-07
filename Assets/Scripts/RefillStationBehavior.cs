using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStationBehavior : MonoBehaviour
{
    //Reference to the object who can use the station
    public GameObject user;
    //Reference to the point of interaction
    public GameObject usePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the set use point and the user's positions are the same
        if (usePoint.transform.position == user.transform.position)
        {
            ServeBehavior server = user.GetComponent<ServeBehavior>();
            server.canServe = true;
        }
    }
}
