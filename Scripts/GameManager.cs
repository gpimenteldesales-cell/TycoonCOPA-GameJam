using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TextMeshProUGUI madeiraTexto;
    public TextMeshProUGUI copasTexto;

    [Header("Valores")]
    public int madeiras = 0;
    public int copas = 0;

    [SerializeField]private int proximaMeta = 30;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AtualizarUI();
    }

    public void AdicionarMadeira(int quantidade)
    {
        madeiras += quantidade;

        while (madeiras >= proximaMeta)
        {
            copas += 10;
            proximaMeta += 30;
        }

        AtualizarUI();

        Debug.Log("Madeiras: " + madeiras);
        Debug.Log("Copas: " + copas);
    }

    void AtualizarUI()
    {
        madeiraTexto.text = "Madeiras: " + madeiras;
        copasTexto.text = "Copas: " + copas;
    }
}