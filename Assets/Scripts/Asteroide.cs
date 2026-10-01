using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public float velocidade = 3f;
    private float velocidadeAtual;

    void Start()
    {
        velocidadeAtual = velocidade * SpawnerAsteroide.multiplicador;
    }

    void Update()
    {
        transform.Translate(Vector2.down * velocidadeAtual * Time.deltaTime);

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Missil"))
        {
            Destroy(colisao.gameObject);
            Destroy(gameObject);
        }
        else if (colisao.CompareTag("Player"))
        {
            Vida vida = colisao.GetComponentInParent<Vida>();
            if (vida != null)
            {
                vida.LevarDano();
            }
            Destroy(gameObject);
        }
    }
}