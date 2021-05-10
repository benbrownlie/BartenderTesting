using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputEventBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    private void OnMove(InputAction.CallbackContext context)
    {

    }
}
