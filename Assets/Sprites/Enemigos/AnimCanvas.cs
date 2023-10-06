using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimCanvas : MonoBehaviour
{
    // Referencia al componente Animator que controla la animacion
    public Animator animator;

    // Variable que indica si la animacion debe reproducirse
    public bool isWalking = false;

    private void Start()
    {
        // Obten la referencia al componente Animator
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Controla la variable de la animacion en funcion de isWalking
        animator.SetBool("IsWalking", isWalking);
    }
}


