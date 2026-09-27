using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public float velocidade = 3f;

    void Update()
    {
        transform.Translate(Vector2.down * velocidade * Time.deltaTime);
    }
}