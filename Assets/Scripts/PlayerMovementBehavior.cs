using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    public LinkedList<Transform> movePoints = new LinkedList<Transform>();

    public float speed;
    public CharacterController characterController;
    public Transform movePoint;
    public Transform movePoint1;
    public Transform movePoint2;

    // Start is called before the first frame update
    void Start()
    {
        movePoints.AddFirst(movePoint1);
        movePoints.AddLast(movePoint2);
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            characterController.transform.position = movePoints;
    }
}
