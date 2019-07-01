using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
            SceneManager.LoadScene("EscenaFinal");
    }
    public void cargarJuego(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public static void FinalPartida(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
