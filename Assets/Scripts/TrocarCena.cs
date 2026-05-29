using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("GameScene");
    }
}