using System.Collections.Generic;
using UnityEngine;

public class ScriptShop : MonoBehaviour
{
    [SerializeField] private GameObject shopUI;
    public List<ArvoreRespawn> arvoreRespawn;
    public GameManager gameManager;

    void Start()
    {
        shopUI.SetActive(false);
    }
    void Update()
    {
        if (gameManager.copas <= 0)
        {
            gameManager.copas = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shopUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shopUI.SetActive(false);
        }
    }

    public void BasicAxe()
    {
        if (gameManager.copas == 20)
        {
            gameManager.copas = -20;
            foreach( ArvoreRespawn arvore in arvoreRespawn)
            {
                arvore.tempoParaCortar = 4.5f;
            }
        }
    }

    public void MediumAxe()
    {
        if (gameManager.copas == 100)
        {
            gameManager.copas = -100;
            foreach( ArvoreRespawn arvore in arvoreRespawn)
            {
                arvore.tempoParaCortar = 4f;
            }
        }
    }

    public void YellowAxe()
    {
        if (gameManager.copas == 300)
        {
            gameManager.copas = -300;
            foreach( ArvoreRespawn arvore in arvoreRespawn)
            {
                arvore.tempoParaCortar = 3f;
            }
        }
    }
    public void SupremumAxe()
    {
        if (gameManager.copas == 1000)
        {
            gameManager.copas = -1000;
            foreach( ArvoreRespawn arvore in arvoreRespawn)
            {
                arvore.tempoParaCortar = 2f;
            }
        }
    }
}