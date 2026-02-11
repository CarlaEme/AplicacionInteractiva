using UnityEngine;

public class CreditosSubiendo : MonoBehaviour
{
    public float velocidad = 50f; // Puedes ajustar la rapidez desde el Inspector

    void Update()
    {
        // Mueve el objeto hacia arriba en el eje Y continuamente
        transform.Translate(Vector3.up * velocidad * Time.deltaTime);
    }
}