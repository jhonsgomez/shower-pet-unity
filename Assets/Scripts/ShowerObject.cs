using UnityEngine;

public class ShowerObject : MonoBehaviour
{
    private new ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }

    private void OnMouseDown()
    {
        particleSystem.Play();
    }

    private void OnMouseUp()
    {
        particleSystem.Stop();
    }
}
