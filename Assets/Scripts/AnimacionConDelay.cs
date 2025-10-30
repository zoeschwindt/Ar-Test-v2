using UnityEngine;
using System.Collections;

public class AnimacionConDelay : MonoBehaviour
{
    [Header("Referencias")]
    public Animator animator;        
    public AudioSource audioSource;  
    public GameObject personaje;     

    [Header("Configuración")]
    public float delay = 3f;         

    void Start()
    {
        
        if (animator != null)
            animator.speed = 0f;

        
        if (personaje != null)
            SetVisible(personaje, false);

       
        StartCoroutine(IniciarDespuesDeDelay());
    }

    IEnumerator IniciarDespuesDeDelay()
    {
        yield return new WaitForSeconds(delay);

        
        if (personaje != null)
            SetVisible(personaje, true);

        
        if (animator != null)
            animator.speed = 1f;

        
        if (audioSource != null)
            audioSource.Play();

        Debug.Log($" Personaje visible y bailando después de {delay} segundos");
    }

    
    void SetVisible(GameObject target, bool visible)
    {
        Renderer[] renderers = target.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer r in renderers)
        {
            r.enabled = visible;
        }
    }
}