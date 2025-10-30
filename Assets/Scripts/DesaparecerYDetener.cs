using UnityEngine;
using System.Collections;

public class DesaparecerYDetener : MonoBehaviour
{
    [Header("Referencias")]
    public Animator animator;        
    public AudioSource audioSource;  
    public GameObject personaje;     

    [Header("Configuración")]
    public float tiempoActivo = 5f; 

    void Start()
    {
        
        StartCoroutine(DesaparecerDespuesDeTiempo());
    }

    IEnumerator DesaparecerDespuesDeTiempo()
    {
        
        yield return new WaitForSeconds(tiempoActivo);

        
        if (animator != null)
            animator.speed = 0f;

        if (audioSource != null && audioSource.isPlaying)
            audioSource.Stop();

       
        if (personaje != null)
            SetVisible(personaje, false);

        Debug.Log($" El personaje se apagó después de {tiempoActivo} segundos");
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
