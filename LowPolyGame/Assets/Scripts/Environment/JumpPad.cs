using UnityEngine;

// 점프대 구현 (ForceMode, Impulse 사용) 

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프 높이
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            player.OnJumpPad(jumpForce);

            animator.SetTrigger("IsJump");
        }
    }

}
