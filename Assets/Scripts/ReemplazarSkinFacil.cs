using UnityEngine;
using System.Collections;
public class ReemplazarSkinFacil : MonoBehaviour
{
    [Header("Referencias")]
    public GameObject modeloBase; 
    public GameObject modeloSkin; 

    [Header("Opciones")]
    public bool ocultarBot = true;
    public float delay = 0.5f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);

        if (!modeloBase || !modeloSkin)
        {
            Debug.LogError(" Faltan referencias en el inspector.");
            yield break;
        }

        Animator animBase = modeloBase.GetComponent<Animator>();
        if (!animBase)
        {
            Debug.LogError(" El modelo base no tiene Animator.");
            yield break;
        }

        Animator animSkin = modeloSkin.GetComponent<Animator>();
        if (!animSkin)
            animSkin = modeloSkin.AddComponent<Animator>();

        
        animSkin.runtimeAnimatorController = animBase.runtimeAnimatorController;
        animSkin.avatar = animBase.avatar;

        
        modeloSkin.transform.position = modeloBase.transform.position;
        modeloSkin.transform.rotation = modeloBase.transform.rotation;

        
        yield return new WaitForSeconds(delay);

        if (ocultarBot)
        {
            foreach (var r in modeloBase.GetComponentsInChildren<Renderer>())
                r.enabled = false;
        }

        Debug.Log(" Skin reemplazada correctamente (sin tocar escala).");
    }
}