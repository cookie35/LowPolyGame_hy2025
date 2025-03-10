using UnityEngine;

// ������ ���� (ForceMode, Impulse ���) 

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // ���� ����
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
