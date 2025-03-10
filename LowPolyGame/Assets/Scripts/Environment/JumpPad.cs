using UnityEngine;

// 점프대 구현 (ForceMode, Impulse 사용) 

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프 높이

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            player.OnJumpPad(jumpForce);
        }

    }

}
