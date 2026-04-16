using UnityEngine;
using UnityEngine.Audio;

public class Coin : MonoBehaviour
{

    public AudioSource audioSource;
    public float destroyDelay = 0.5f;



    private bool triggered = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.CompareTag("Player"))
        {
            triggered = true;

            if (audioSource != null)
                audioSource.Play();

            // Hide the object immediately
            GetComponent<MeshRenderer>().enabled = false;

            // Destroy after the sound finishes
            Destroy(gameObject, destroyDelay);
        }
    }


}
