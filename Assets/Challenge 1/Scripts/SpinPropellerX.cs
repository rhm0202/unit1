using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000f; // �����緯 ȸ�� �ӵ�(Inspector���� ���� ����)

    void Update()
    {
        // Z���� �������� ȸ�� (�� �����Ӹ���)
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
