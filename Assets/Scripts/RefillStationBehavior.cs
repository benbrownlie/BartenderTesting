using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStationBehavior : MonoBehaviour
{
    //Reference to the user that will be interacting with the station
    public GameObject user;
    //Reference to the point that the user will be to be on the interact
    public GameObject usepoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (usepoint.transform.position == user.transform.position)
        {
            ServeBehavior server = user.GetComponent<ServeBehavior>();
            server.canServe = true;
        }
    }
}
