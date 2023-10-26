using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputValidation : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public InputField inputField3;
    public InputField inputField4;

    public Button continueButton;
    public GameObject wrongAnswerImage;
    public GameObject correctAnswerImage;
    public GameObject wrongAnswerImage2;
    public GameObject correctAnswerImage2;
    public GameObject wrongAnswerImage3;
    public GameObject correctAnswerImage3;
    public GameObject wrongAnswerImage4;
    public GameObject correctAnswerImage4;

    private string correctAnswer1 = "Paréntesis";
    private string correctAnswer2 = "Teléfono";
    private string correctAnswer3 = "Acústica";
    private string correctAnswer4 = "Relámpago";

    private void Start()
    {
        // Agrega listeners para cada InputField
        inputField1.onValueChanged.AddListener(ValidateInput);
        inputField2.onValueChanged.AddListener(ValidateInput);
        inputField3.onValueChanged.AddListener(ValidateInput);
        inputField4.onValueChanged.AddListener(ValidateInput);
    }

    public void ValidateInput(string userInput)
    {
        userInput = userInput.Trim(); // Elimina espacios en blanco

        if (inputField1.isFocused)
        {
            Debug.Log("Lo q se escribe "+userInput);
            if (string.Equals(userInput, correctAnswer1, System.StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log("If equals1 "+userInput);
                // La entrada es correcta para inputField1
                wrongAnswerImage.SetActive(false);
                correctAnswerImage.SetActive(true);
                continueButton.interactable = true; // Habilita el botón
            }
            else
            {
                // La entrada es incorrecta para inputField1
                wrongAnswerImage.SetActive(true);
                correctAnswerImage.SetActive(false);
                continueButton.interactable = false; // Deshabilita el botón
            }
        }
        else if (inputField2.isFocused)
        {
            Debug.Log("Lo q se escribe "+userInput);
            if (string.Equals(userInput, correctAnswer2, System.StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log("If equals 2"+userInput);
                // La entrada es correcta para inputField2
                wrongAnswerImage2.SetActive(false);
                correctAnswerImage2.SetActive(true);
                continueButton.interactable = false; // Deshabilita el botón
            }
            else
            {
                // La entrada es incorrecta para inputField2
                wrongAnswerImage2.SetActive(true);
                correctAnswerImage2.SetActive(false);
                continueButton.interactable = false; // Deshabilita el botón
            }
        }
        else if (inputField3.isFocused)
        {
            Debug.Log("Lo q se escribe 3 "+userInput);
            if (string.Equals(userInput, correctAnswer3, System.StringComparison.OrdinalIgnoreCase))
            {
Debug.Log("If equals 3 "+userInput);
                // La entrada es correcta para inputField2
                wrongAnswerImage3.SetActive(false);
                correctAnswerImage3.SetActive(true);
                continueButton.interactable = false; // Deshabilita el botón
            }
            else
            {
                // La entrada es incorrecta para inputField2
                wrongAnswerImage3.SetActive(true);
                correctAnswerImage3.SetActive(false);
                continueButton.interactable = false; // Deshabilita el botón
            }
        }
        else if (inputField4.isFocused)
        {
            Debug.Log("Lo q se escribe 4"+userInput);
            if (string.Equals(userInput, correctAnswer4, System.StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log("If equals 4 "+userInput);
                // La entrada es correcta para inputField2
                wrongAnswerImage4.SetActive(false);
                correctAnswerImage4.SetActive(true);
                continueButton.interactable = true; // Deshabilita el botón
            }
            else
            {
                // La entrada es incorrecta para inputField2
                wrongAnswerImage4.SetActive(true);
                correctAnswerImage4.SetActive(false);
                continueButton.interactable = false; // Deshabilita el botón
            }
        }
    }
}
