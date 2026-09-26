using UnityEngine;

public class MissilController : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 8f;

    [SerializeField]
    private float tempoDeVida = 3f;

    void Start()
    {
        // Destroi o míssil depois de alguns segundos para não acumular objetos na cena
        Destroy(gameObject, tempoDeVida);
    }

    void Update()
    {
        // Move o míssil sempre para a direita da tela, independente da rotação do sprite
        transform.Translate(Vector3.right * velocidade * Time.deltaTime, Space.World);
    }
}