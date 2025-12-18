using UnityEngine;

public class PlayerFloat : MonoBehaviour
{
    public float waterLevel = 0.5f;
    public float floatStrength = 3f;

    void FixedUpdate()
    {
        if (transform.position.y < waterLevel)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
        }
    }
}
