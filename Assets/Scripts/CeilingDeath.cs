using UnityEngine;

public class CeilingDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок умер");
            // Тут потом можно сделать перезапуск
        }
    }
}
