using UnityEngine;

public class Nave : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(horizontal, vertical, 0);

        transform.position += movimento * velocidade * Time.deltaTime;

        LimitarMovimento();
    }

    void LimitarMovimento()
    {
        Vector3 posicao = transform.position;

        posicao.x = Mathf.Clamp(posicao.x, -8f, 8f);
        posicao.y = Mathf.Clamp(posicao.y, -4.5f, 4.5f);

        transform.position = posicao;
    }
}