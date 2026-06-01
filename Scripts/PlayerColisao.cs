using UnityEngine;

public class PlayerColisao : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arvore"))
        {
            ArvoreRespawn arvore = other.GetComponent<ArvoreRespawn>();
            if (arvore != null) arvore.IniciarCorte();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Arvore"))
        {
            ArvoreRespawn arvore = other.GetComponent<ArvoreRespawn>();
            if (arvore != null) arvore.CancelarCorte();
        }
    }
}
