using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegador : MonoBehaviour
{
    public void IrAJugar()
    {
        // Si tu escena se llama "Jugar", el código debe ser así:
        SceneManager.LoadScene("Jugar"); 
    }
}