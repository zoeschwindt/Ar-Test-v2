using UnityEngine;

public class SonidoConRetraso : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 2f;

    void Start()
    {
        audioSource.PlayDelayed(delay);
    }
}
