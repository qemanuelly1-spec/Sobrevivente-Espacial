using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public int vidas = 3;

    public void LevarDano()
    {
        vidas--;
        Debug.Log("Vidas: " + vidas);

        if (vidas <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}