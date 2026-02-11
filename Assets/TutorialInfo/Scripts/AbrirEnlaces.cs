using UnityEngine;

public class AbrirEnlaces : MonoBehaviour
{
    // Esta función permitirá abrir cualquier link que le pases desde el Inspector
    public void AbrirURL(string url)
    {
        Application.OpenURL(url);
    }
}