using UnityEngine;

public class SonidoDelay : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;
    public float delay = 2f;

    [Header("Bloques que aparecerán")]
    public GameObject bloque1;
    public GameObject bloque2;

    void Start()
    {
        
        bloque1.SetActive(false);
        bloque2.SetActive(false);

        
        StartCoroutine(EsperarYActivar());
    }

    System.Collections.IEnumerator EsperarYActivar()
    {
        
        yield return new WaitForSeconds(delay);

        
        audioSource.Play();

        
        bloque1.SetActive(true);
        bloque2.SetActive(true);
    }
}
