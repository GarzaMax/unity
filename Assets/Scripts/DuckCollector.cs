using UnityEngine;

public class DuckCollector : MonoBehaviour
{
    public int ducksLeft = 5;
    public Transform teleportPoint;

    public void CollectDuck()
    {
        ducksLeft--;
        if (ducksLeft <= 0)
        {
            transform.position = teleportPoint.position;
        }
    }
}
