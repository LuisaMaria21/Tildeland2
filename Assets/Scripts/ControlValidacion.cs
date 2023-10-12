using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlValidacion : MonoBehaviour
{
    public Button botonValidacion1;
    public Button botonValidacion2;
    public Button botonValidacion3;
    public Button botonContinuar;

    private bool validacion1Completada = false;
    private bool validacion2Completada = false;
    private bool validacion3Completada = false;

    private void Start()
    {
        // Deshabilita el botón de continuar al inicio
        botonContinuar.interactable = false;

        // Asocia funciones a los botones de validación
        botonValidacion1.onClick.AddListener(ValidarBoton1);
        botonValidacion2.onClick.AddListener(ValidarBoton2);
        botonValidacion3.onClick.AddListener(ValidarBoton3);
    }

    private void ValidarBoton1()
    {
        // Acción que se ejecuta cuando se presiona el botón de validación 1
        validacion1Completada = true;
        VerificarHabilitarBotonContinuar();
    }

    private void ValidarBoton2()
    {
        // Acción que se ejecuta cuando se presiona el botón de validación 2
        validacion2Completada = true;
        VerificarHabilitarBotonContinuar();
    }

    private void ValidarBoton3()
    {
        // Acción que se ejecuta cuando se presiona el botón de validación 3
        validacion3Completada = true;
        VerificarHabilitarBotonContinuar();
    }

    private void VerificarHabilitarBotonContinuar()
    {
        // Habilita el botón de continuar si todas las validaciones están completadas
        if (validacion1Completada && validacion2Completada && validacion3Completada)
        {
            botonContinuar.interactable = true;
        }
    }
}

