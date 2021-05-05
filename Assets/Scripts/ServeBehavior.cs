using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeBehavior : MonoBehaviour
{
    //Reference to the object that will be serving
    public GameObject server;
    //Instance of ProjectileBehavior used for the drinks that will be served
    public ProjectileBehavior drink;
    //A bool used to tell the server if they can serve or not
    public bool canServe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reference to the drink object
        GameObject _drink;
        //If the left mouse button has been pressed and the canServe variable is true
        if (Input.GetKeyDown(KeyCode.Mouse0) && canServe)
        {
            //Sets _drink to instantiate the drink's gameobject at the server's position
            _drink = Instantiate(drink.gameObject, server.transform.position, server.transform.rotation);
            //Calls GetComponent for _drink with a new ProjectileBehavior
            ProjectileBehavior moveDrink = _drink.GetComponent<ProjectileBehavior>();
        }
    }
}
