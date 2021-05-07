using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Array used to store the points the player can move to
    public Transform[] MovePoints = new Transform[3];
    //The maximum amount of spaces the player can move
    private int _moveMax = 3;
    //The minimum amount of spaces the player can move
    private int _moveMin = 3;
    public CharacterController characterController;
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && i < _moveMax)
        {
            characterController.transform.position = MovePoints[i].transform.position;
        }
    }
}
