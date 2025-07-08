using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // 좌/우(좌:-1, 우:1, 아무것도 안 누름: 0)
        forwardInput = Input.GetAxis("Vertical");      // 앞/뒤(앞:1, 뒤:-1, 안 누름:0)

        // 전진/후진 (W, S 또는 ↑↓키)  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // 좌/우 회전 (A, D 또는 ←→키)
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
