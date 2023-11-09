using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public InputField inputField;
    public Button continueButton;
    public GameObject wrongAnswerImage;
    public GameObject correctAnswerImage;
    public AudioSource audioSource;
    public AudioClip incorrectAudioClip; // Asegúrate de asignar un AudioClip en el Inspector

    private string correctAnswer = "fí";

    private void Start()
    {
        // Agrega un listener al campo de entrada para activar la validación
        inputField.onValueChanged.AddListener(ValidateInput);
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
            PlayIncorrectSound();
        }
    }

    private void PlayIncorrectSound()
    {
        if (audioSource != null && incorrectAudioClip != null)
        {
            audioSource.PlayOneShot(incorrectAudioClip);
        }
    }
}