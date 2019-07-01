using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject katana;
    public GameObject rifle;

    private int HERIDA = 100;
    private int CURA = 10;
    public Text texto;
    private int vida;
    private bool tieneKatana;
    private bool armaActiva; // 0 rifle, 1 katana
    private bool ultimoEstado;
    private float contador; //contar el numero de frames que han pasado

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        tieneKatana = true;
        armaActiva = true;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "100 - " + vida;
        contador += Time.deltaTime;
        if (Input.GetButton("Change") && tieneKatana && contador > 1.5)
        {
            if (!armaActiva) //Tiene el rifle
            {
                ControllerArmas.Deactivate();
                MeleeController.Activate();
                armaActiva = !armaActiva;
            }
            else //tiene la katana
            {
                MeleeController.Deactivate();
                ControllerArmas.Activate();
                armaActiva = !armaActiva;
            }
            contador = 0;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            herir();
        }
    }
    

    void herir()
    {
        vida -= HERIDA;

        if(vida <= 0)
        {
            
            
            LevelManager.FinalPartida("MainMenu");
        }
    }

    public void curar()
    {
        if(vida < 100)
        {
            vida += CURA;

            if (vida > 100)
                vida = 100;
        }
    }
   
}
