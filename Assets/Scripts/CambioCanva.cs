using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioCanva : MonoBehaviour
{
    public GameObject canvas1; // Arrastra el primer Canvas aqui en el Inspector
    public GameObject canvas2; // Arrastra el segundo Canvas aqui en el Inspector
    public Button botonCambio;

    public void CambiarCanvas()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
