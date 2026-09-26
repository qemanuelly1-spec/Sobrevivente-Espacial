using UnityEngine;

public class DisparoController : MonoBehaviour
{
    [SerializeField]
    private GameObject missilPrefab;

    [SerializeField]
    private Transform pontoDeDisparo;

    private Teclado teclado;
    private bool podeAtirar = true;

    [SerializeField]
    private float tempoEntreDisparos = 0.5f;

    void Start()
    {
        teclado = GetComponent<Teclado>();
    }

    void Update()
    {
        if (teclado.espaco && podeAtirar)
        {
            Atirar();
        }
    }

    void Atirar()
    {
        Vector3 posicaoDeDisparo = pontoDeDisparo != null ? pontoDeDisparo.position : transform.position;
        Instantiate(missilPrefab, posicaoDeDisparo, missilPrefab.transform.rotation);
        podeAtirar = false;
        Invoke(nameof(ResetarDisparo), tempoEntreDisparos);
    }

    void ResetarDisparo()
    {
        podeAtirar = true;
    }
}