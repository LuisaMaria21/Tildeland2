using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class pasarNivel : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene("VideoNiña");
    }
}
