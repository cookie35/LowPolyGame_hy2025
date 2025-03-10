using UnityEngine;

// �߰��� �Ҹ��� ���� �� 

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepClips;
    private AudioSource audioSource;
    private Rigidbody rigidbody;
    public float footstepThreshold;  // ���ڱ� �Ҹ��� ���� �ӵ� �Ӱ谪
    public float footstepRate;  // ���ڱ� �Ҹ� ��� ����
    private float footstepTime;  // ������ ���ڱ� �Ҹ� �ð�

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Mathf.Abs(rigidbody.velocity.y) < 0.1f)  // y�� �ӵ��� ���� 0�̸�(���� �ʰų� ���߿� x)
        {
            if (rigidbody.velocity.magnitude > footstepThreshold)  // �ӵ��� �Ӱ谪�� ������ 
            {
                if (Time.time - footstepTime > footstepRate)  // ���ڱ� �Ҹ� ������ �Ǹ�
                {
                    footstepTime = Time.time;  // ���ڱ� �Ҹ� �ð� ���� 
                    if (footstepClips.Length > 0)  //  ���ڱ� �Ҹ� �迭�� Ŭ���� �ִ��� Ȯ��
                    {
                        audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
                        // �迭�� �ִ� Ŭ�� �� �������� �ϳ��� �����Ͽ� ���
                    }

                }
            }
        }

    }
}
