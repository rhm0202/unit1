using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000f; // 프로펠러 회전 속도(Inspector에서 조정 가능)

    void Update()
    {
        // Z축을 기준으로 회전 (매 프레임마다)
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
