using UnityEngine;
using UnityEngine.SceneManagement; // Esta línea es vital para el cambio de escenas

public class ManejadorEscenas : MonoBehaviour
{
    // Función para ir a la escena de Créditos
    public void IrACreditos()
    {
        SceneManager.LoadScene("Escena_Creditos");
    }

    // Función para regresar a la escena de Inicio
    public void IrAInicio()
    {
        SceneManager.LoadScene("Inicio");
    }


// Función para cerrar la aplicación
public void SalirDeLaAplicacion()
{
    Debug.Log("Saliendo de la aplicación...");
    Application.Quit();
}
}