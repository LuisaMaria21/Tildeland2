using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText2 : MonoBehaviour
{
    public InputField inputField;
    public Button continueButton;
    public GameObject wrongAnswerImage;
    public GameObject correctAnswerImage;
    public AudioClip incorrectSound; // Agrega el AudioClip para el sonido

    private string correctAnswer = "len";
    private AudioSource audioSource; // Agrega el AudioSource para reproducir el sonido

    private void Start()
    {
        // Agrega un listener al campo de entrada para activar la validación
        inputField.onValueChanged.AddListener(ValidateInput);

        // Obtén o agrega un AudioSource al objeto actual
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void ValidateInput(string userInput)
    {
        userInput = userInput.Trim(); // Elimina espacios en blanco

        if (string.Equals(userInput, correctAnswer, System.StringComparison.OrdinalIgnoreCase))
        {
            // La entrada es correcta
            wrongAnswerImage.SetActive(false);
            correctAnswerImage.SetActive(true);
            continueButton.interactable = true; // Habilita el botón
        }
        else
        {
            // La entrada es incorrecta
            wrongAnswerImage.SetActive(true);
            correctAnswerImage.SetActive(false);
            continueButton.interactable = false; // Deshabilita el botón
            PlayIncorrectSound(); // Reproduce el sonido de incorrecto
        }
    }

    private void PlayIncorrectSound()
    {
        if (incorrectSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(incorrectSound);
        }
    }
}