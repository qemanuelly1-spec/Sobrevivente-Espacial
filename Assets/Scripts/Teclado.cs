using UnityEngine;
using UnityEngine.InputSystem;

public class Teclado : MonoBehaviour
{
    public bool cima;
    public bool baixo;
    public bool esquerda;
    public bool direita;
    public bool z;
    public bool x;
    public bool espaco;

    void Update()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        var k = Keyboard.current;

        cima     = k.upArrowKey.isPressed    || k.wKey.isPressed;
        baixo    = k.downArrowKey.isPressed  || k.sKey.isPressed;
        esquerda = k.leftArrowKey.isPressed  || k.aKey.isPressed;
        direita  = k.rightArrowKey.isPressed || k.dKey.isPressed;

        z = k.zKey.isPressed;
        x = k.xKey.isPressed;
        espaco = k.spaceKey.isPressed;
    }
}