using UnityEngine;
using System.Collections;

public class ArvoreRespawn : MonoBehaviour
{
    [SerializeField] private float tempoParaCortar = 3f;
    [SerializeField] private float tempoParaRessurgir = 4f;

    private SpriteRenderer spriteRenderer;
    private Collider2D arvoreCollider;
    private Coroutine rotinaCorte;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        arvoreCollider = GetComponent<Collider2D>();
    }

    public void IniciarCorte()
    {
        rotinaCorte = StartCoroutine(CortarAposTempo());
    }

    public void CancelarCorte()
    {
        if (rotinaCorte != null) StopCoroutine(rotinaCorte);
    }

    private IEnumerator CortarAposTempo()
    {
        yield return new WaitForSeconds(tempoParaCortar);
        spriteRenderer.enabled = false;
        arvoreCollider.enabled = false;
        StartCoroutine(RessurgirRotina());
    }

    private IEnumerator RessurgirRotina()
    {
        yield return new WaitForSeconds(tempoParaRessurgir);
        spriteRenderer.enabled = true;
        arvoreCollider.enabled = true;
    }
}
