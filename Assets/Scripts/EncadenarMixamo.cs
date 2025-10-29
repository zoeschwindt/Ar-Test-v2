using UnityEngine;

public class EncadenarMixamo : MonoBehaviour
{
    public Animator animator;

   
    public void SiguienteAnimacion()
    {
        animator.Play("Death"); 
    }
}
