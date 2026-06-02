using System.Collections;
using UnityEngine;

public class ArvoreRespawn : MonoBehaviour
{
    [Header("Configurações de Tempo")]
    [SerializeField] public float tempoParaCortar = 5f;
    [SerializeField] private float tempoParaRessurgir = 20f;
    
    [Header("Configurações de Recompensa")]
    [SerializeField] private int pontosPorArvore = 3;

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
        if (rotinaCorte != null)
        {
            StopCoroutine(rotinaCorte);
        }
    }

    private IEnumerator CortarAposTempo()
    {
        yield return new WaitForSeconds(tempoParaCortar);

        if (GameManager.Instance != null)
        {
            GameManager.Instance.AdicionarMadeira(pontosPorArvore);
        }

        if (spriteRenderer != null) spriteRenderer.enabled = false;
        if (arvoreCollider != null) arvoreCollider.enabled = false;

        StartCoroutine(RessurgirRotina());
    }

    private IEnumerator RessurgirRotina()
    {
        yield return new WaitForSeconds(tempoParaRessurgir);

        if (spriteRenderer != null) spriteRenderer.enabled = true;
        if (arvoreCollider != null) arvoreCollider.enabled = true;
    }
}