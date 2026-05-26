using UnityEngine;
using System.Collections;

public class ArvoreRespawn : MonoBehaviour
{
    [SerializeField] private float tempoParaRessurgir = 4f;
    private SpriteRenderer spriteRenderer;
    private Collider2D arvoreCollider;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        arvoreCollider = GetComponent<Collider2D>();
    }

    public void Cortar()
    {
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
