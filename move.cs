
using System.Security.Cryptography;
using UnityEngine.InputSystem;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    PlayerInput input;
    InputAction jumpAction;
    InputAction move;
    const float speed = 5f;

    void Awake()
    {
        input = GetComponent<PlayerInput>();
        jumpAction = input.actions["Jump"];
        move = input.actions["Move"];
        jumpAction.performed += OnJump;
    }

    void OnJump(InputAction.CallbackContext ctx)
    {
      // rb.AddForce(Vector3.up * jumpForce);
    }
    void Update()
    {
        Vector2 M =
   move.ReadValue<Vector2>();
        transform.Translate(M * speed * Time.deltaTime);
    }
}
