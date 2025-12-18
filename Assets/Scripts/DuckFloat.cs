using UnityEngine;

public class DuckFloat : MonoBehaviour
{
    public float floatForce = 15f;
    public float waterLevel = 1.4f;

    void FixedUpdate()
    {
        if (transform.position.y < waterLevel)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * floatForce);
        }
    }
}
