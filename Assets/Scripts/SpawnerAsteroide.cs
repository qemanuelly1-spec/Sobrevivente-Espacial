using UnityEngine;

public class SpawnerAsteroide : MonoBehaviour
{
    // Todos os asteroides leem esse valor para saber a velocidade
    public static float multiplicador = 1f;

    [SerializeField] private GameObject asteroidePrefab;
    [SerializeField] private float intervalo = 1.5f;
    [SerializeField] private float xMin = -8f;
    [SerializeField] private float xMax = 8f;
    [SerializeField] private float y = 6f;

    [Header("Dificuldade")]
    [SerializeField] private float aumentoPorSegundo = 0.03f;
    [SerializeField] private float multiplicadorMaximo = 3f;

    private float tempoParaProximo = 1f;

    void Start()
    {
        multiplicador = 1f; // recomeça fácil quando a cena reinicia
    }

    void Update()
    {
        multiplicador = Mathf.Min(multiplicador + aumentoPorSegundo * Time.deltaTime, multiplicadorMaximo);

        tempoParaProximo -= Time.deltaTime;
        if (tempoParaProximo <= 0f)
        {
            Criar();
            tempoParaProximo = intervalo / multiplicador;
        }
    }

    void Criar()
    {
        float x = Random.Range(xMin, xMax);
        Instantiate(asteroidePrefab, new Vector3(x, y, 0f), Quaternion.identity);
    }
}