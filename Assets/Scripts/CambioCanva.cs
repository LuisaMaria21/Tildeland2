using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioCanva : MonoBehaviour
{
    public GameObject canvas1; // Arrastra el primer Canvas aqui en el Inspector
    public GameObject canvas2; // Arrastra el segundo Canvas aqui en el Inspector
    public Button botonCambio;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     // Al iniciar el juego, mostramos el primer Canvas y ocultamos el segundo Canvas
    //     canvas1.SetActive(true);
    //     canvas2.SetActive(false);

    //     // Configura la funcion de cambio cuando se hace clic en el boton
    //     botonCambio.onClick.AddListener(CambiarCanvas);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     canvas1.SetActive(!canvas1.activeSelf); // Cambiamos el estado del primer Canvas
    //     canvas2.SetActive(!canvas2.activeSelf); // Cambiamos el estado del segundo Canvas
    // }

    public void CambiarCanvas(){
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }
}
