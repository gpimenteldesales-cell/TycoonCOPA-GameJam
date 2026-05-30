using UnityEngine;
using TMPro;

public class CopasPontos : MonoBehaviour
{
    public static CopasPontos Instance { get; private set; }

    [Header("UI do Jogo")]
    [SerializeField] private TextMeshProUGUI textoPontos; 
    [SerializeField] private string prefixoTexto = "Pontos: "; 

    [Header("Pontuação")]
    [SerializeField] private int pontosAtuais = 0; // Deixei visível no Inspector para você acompanhar

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Garante que o GameManager não suma
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AtualizarInterface();
    }

    public void AdicionarPontos(int quantidade)
    {
        pontosAtuais += quantidade;
        Debug.LogWarning("GameManager recebeu os pontos! Total atual: " + pontosAtuais);
        AtualizarInterface();
    }

    private void AtualizarInterface()
    {
        if (textoPontos != null)
        {
            textoPontos.text = prefixoTexto + pontosAtuais.ToString();
        }
        else
        {
            Debug.LogError("ERRO: O campo 'Texto Pontos' está vazio no Inspector do GameManager!");
        }
    }
}