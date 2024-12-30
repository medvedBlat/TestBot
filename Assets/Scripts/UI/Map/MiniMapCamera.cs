using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    public Transform target;
    public float height = 20f;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, height, target.position.z);
    }
}