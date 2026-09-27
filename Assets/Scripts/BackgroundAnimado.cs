using UnityEngine;

public class BackgroundAnimado : MonoBehaviour
{
    public Transform imagemA;
    public Transform imagemB;
    public float velocidade = 1f;

    private float largura;

    void Start()
    {
        SpriteRenderer sprite = imagemA.GetComponent<SpriteRenderer>();

        // Descobre automaticamente a largura da imagem
        largura = sprite.bounds.size.x;

        // Coloca a imagem B exatamente à direita da imagem A
        imagemB.position = new Vector3(
            imagemA.position.x + largura,
            imagemA.position.y,
            imagemA.position.z
        );
    }

    void Update()
    {
        // Move as duas imagens para a esquerda
        Vector3 movimento = Vector3.left * velocidade * Time.deltaTime;

        imagemA.position += movimento;
        imagemB.position += movimento;

        // Quando A sair completamente pela esquerda,
        // ela volta para a direita de B
        if (imagemA.position.x <= -largura)
        {
            imagemA.position = new Vector3(
                imagemB.position.x + largura,
                imagemA.position.y,
                imagemA.position.z
            );
        }

        // Quando B sair completamente pela esquerda,
        // ela volta para a direita de A
        if (imagemB.position.x <= -largura)
        {
            imagemB.position = new Vector3(
                imagemA.position.x + largura,
                imagemB.position.y,
                imagemB.position.z
            );
        }
    }
}