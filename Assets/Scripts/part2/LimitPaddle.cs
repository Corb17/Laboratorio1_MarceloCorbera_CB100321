using UnityEngine;

public class PaddleLimiter : MonoBehaviour
{
    public float minX = -132f;
    public float maxX = 132f; 

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }
}
