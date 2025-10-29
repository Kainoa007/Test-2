using UnityEngine;

public class CameraMoveUp : MonoBehaviour
{
    public float cameraSpeed = 0.005f;

    private void Update()
    {
        transform.Translate(Vector3.up* cameraSpeed * Time.deltaTime);
    }
}
