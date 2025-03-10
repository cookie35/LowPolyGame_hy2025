using UnityEngine;

// ������ ���� (ForceMode, Impulse ���) 

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // ���� ����

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
