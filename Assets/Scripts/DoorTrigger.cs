using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public WaterRise water;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            water.StartRising();
        }
    }
}
