using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class DropdownHandler1 : MonoBehaviour
{
    public TMP_Dropdown myDropdown;
    public GameObject feedbackImage;
    public GameObject correctImage;
    public GameObject incorrectImage;

    void Start()
    {
        if (myDropdown != null)
        {
            myDropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(myDropdown);
            });
        }

        feedbackImage.SetActive(false);
    }

    void DropdownValueChanged(TMP_Dropdown change)
    {
        if (change.value == 0)
        {
            correctImage.SetActive(true);
            incorrectImage.SetActive(false);
        }
        else
        {
            correctImage.SetActive(false);
            incorrectImage.SetActive(true);
        }
    }

    void OnDestroy()
    {
        myDropdown.onValueChanged.RemoveListener(delegate {
            DropdownValueChanged(myDropdown);
        });
    }
}
