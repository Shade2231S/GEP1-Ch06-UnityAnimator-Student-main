using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Animator))]
public class MegaManAniController : MonoBehaviour
{
    public Animator animator;
    public Vector2 move;
    private int MoveInputHashx = Animator.StringToHash("Moveinputx");
    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        animator.SetFloat(MoveInputHashx, move.x);


    }
}
