using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // ��/��(��:-1, ��:1, �ƹ��͵� �� ����: 0)
        forwardInput = Input.GetAxis("Vertical");      // ��/��(��:1, ��:-1, �� ����:0)

        // ����/���� (W, S �Ǵ� ���Ű)  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // ��/�� ȸ�� (A, D �Ǵ� ���Ű)
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
