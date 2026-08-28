using UnityEngine;

public class ObjectRoot : MonoBehaviour
{
    [Header("Rotation Speed")]
    [SerializeField] private float rotationSpeedX = 10f;
    [SerializeField] private float rotationSpeedY = 30f;
    [SerializeField] private float rotationSpeedZ = 5f;

    private void Update()
    {
        Vector3 rotation = new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
        transform.Rotate(rotation * Time.deltaTime, Space.Self);
    }
}
