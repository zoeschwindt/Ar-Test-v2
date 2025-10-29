using UnityEngine;
using System.Collections;

public class RetrasoAnimacionClip : MonoBehaviour
{
    public Animator animator;
    public AnimationClip animacion;
    public float delay = 2f;

    void Start()
    {
        
        animator.enabled = false;
        StartCoroutine(EjecutarConRetraso());
    }

    IEnumerator EjecutarConRetraso()
    {
        yield return new WaitForSeconds(delay);

        if (animacion != null && animator != null)
        {
            animator.enabled = true;
            animator.Play(animacion.name);
        }
    }
}
