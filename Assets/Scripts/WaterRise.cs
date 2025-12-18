using UnityEngine;

public class WaterRise : MonoBehaviour
{
    public float maxHeight = 3f;
    public float speed = 0.3f;
    private bool rising = false;

    void Update()
    {
        if (rising && transform.position.y < maxHeight)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }

    public void StartRising()
    {
        rising = true;
    }
}
