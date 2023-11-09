using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Continuar : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nombreDeLaSiguienteEscena; // El nombre de la escena a la que quieres cambiar

    private void Start()
    {
        // Registra el método que se ejecutará cuando el video termine
        videoPlayer.loopPointReached += VideoTerminado;
    }

    private void VideoTerminado(VideoPlayer vp)
    {
        // Se ejecutará cuando el video termine
        CambiarDeEscena();
    }

    private void CambiarDeEscena()
    {
        // Carga la nueva escena especificada
        SceneManager.LoadScene("PruebaGrave");
    }
}

