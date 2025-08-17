using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100f; 
    private Rigidbody rb;
    public float minDirectionValue = 45;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0f, 1f);
        rb.linearVelocity = direction * speed;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
    void OnCollisionEnter(Collision collision)
    {

        Vector3 vel = rb.linearVelocity;

        if (vel.x > -minDirectionValue && vel.x < minDirectionValue)
        {
            vel.x = minDirectionValue * Mathf.Sign(vel.x != 0 ? vel.x : 1f);
        }

        if (vel.z > -minDirectionValue && vel.z < minDirectionValue)
        {
            vel.z = minDirectionValue * Mathf.Sign(vel.z != 0 ? vel.z : 1f);
        }

        rb.linearVelocity = vel.normalized * speed;

        if (collision.gameObject.CompareTag("Block"))
            Destroy(collision.gameObject);
    }
}