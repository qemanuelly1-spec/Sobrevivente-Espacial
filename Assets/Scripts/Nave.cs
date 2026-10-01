using UnityEngine;

public class Nave : MonoBehaviour
{
    public float velocidade = 5f;
    private Teclado teclado;

    void Start()
    {
        teclado = GetComponent<Teclado>();
    }

    void Update()
    {
        float h = (teclado.direita ? 1 : 0) - (teclado.esquerda ? 1 : 0);
        float v = (teclado.cima ? 1 : 0) - (teclado.baixo ? 1 : 0);

        transform.position += new Vector3(h, v, 0) * velocidade * Time.deltaTime;
        LimitarMovimento();
    }

    void LimitarMovimento()
    {
        Vector3 p = transform.position;
        p.x = Mathf.Clamp(p.x, -8f, 8f);
        p.y = Mathf.Clamp(p.y, -4.5f, 4.5f);
        transform.position = p;
    }
}