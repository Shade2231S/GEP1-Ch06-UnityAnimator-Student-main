using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Animator))]
public class MegaManAniController : MonoBehaviour
{
    public Animator animator;
    public Vector2 move;
    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
}
