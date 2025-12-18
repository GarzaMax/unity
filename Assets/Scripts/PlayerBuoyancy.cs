using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBuoyancy : MonoBehaviour
{
    public Transform water;
    public float floatStrength = 20f;
    public float offset = 0.5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float waterY = water.position.y;

        if (transform.position.y < waterY + offset)
        {
            float depth = (waterY + offset) - transform.position.y;
            rb.AddForce(Vector3.up * floatStrength * depth, ForceMode.Force);
        }
    }
}
