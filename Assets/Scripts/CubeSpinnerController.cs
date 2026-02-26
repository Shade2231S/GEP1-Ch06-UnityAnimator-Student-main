using UnityEngine;
using UnityEngine.InputSystem;
public class CubeSpinnerController : MonoBehaviour
{
    public Animator animator;
    private int IsRotatingHash = Animator.StringToHash("isrotating");
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed && (animator.GetBool(IsRotatingHash) == true)) 
        {
            animator.SetBool(IsRotatingHash, true);
        }
        else if (context.performed && (animator.GetBool(IsRotatingHash) == false))
        {
            animator.SetBool(IsRotatingHash, true);
        }
    }
}
