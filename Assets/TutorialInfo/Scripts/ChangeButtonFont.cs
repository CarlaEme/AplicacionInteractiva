using UnityEngine;
using TMPro;

public class ChangeButtonFont : MonoBehaviour
{
    public TextMeshProUGUI textoDelBoton;
    public TMP_FontAsset nuevaFuente;

    public void CambiarFuenteBoton()
    {
        textoDelBoton.font = nuevaFuente;
    }
}