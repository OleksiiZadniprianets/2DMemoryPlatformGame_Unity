using UnityEngine;

public class SpikeReset : MonoBehaviour
{
    public Transform startPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = startPoint.position;
        }
    }
}
