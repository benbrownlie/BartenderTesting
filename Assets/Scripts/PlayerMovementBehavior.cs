using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    public float speed;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            characterController.SimpleMove(Vector3.left * speed);
        if (Input.GetKey(KeyCode.S))
            characterController.SimpleMove(Vector3.right * speed);
        if (Input.GetKey(KeyCode.A))
            characterController.SimpleMove(Vector3.back * speed);
        if (Input.GetKey(KeyCode.D))
            characterController.SimpleMove(Vector3.forward * speed);
    }
}
