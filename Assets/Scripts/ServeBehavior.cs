using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeBehavior : MonoBehaviour
{
    public GameObject server;
    public ProjectileBehavior drink;
    public int drinkCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _drink;
        if (Input.GetKeyDown(KeyCode.Mouse0) && drinkCount > 0)
        {
            _drink = Instantiate(drink.gameObject, server.transform.position, server.transform.rotation);
            ProjectileBehavior moveDrink = _drink.GetComponent<ProjectileBehavior>();
            drinkCount--;
        }
    }
}
