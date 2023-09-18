using UnityEngine;

public class PetObject : MonoBehaviour
{
    private new ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Soap"))
        {
            particleSystem.Play();
        } else if (other.CompareTag("Water"))
        {
            particleSystem.Clear();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Soap"))
        {
            particleSystem.Pause();
        }
    }
}
