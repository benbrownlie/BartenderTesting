using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStationBehavior : MonoBehaviour
{
    public GameObject user;
    public GameObject usePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject _server;
        if (user.transform.position == usePoint.transform.position && Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
