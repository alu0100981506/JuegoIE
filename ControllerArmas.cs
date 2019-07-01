using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerArmas : MonoBehaviour {
    [SerializeField]
    GameObject objeto;


    private int DAMAGE = 25;
    public Text texto;
    private int maxNumBullets;
    private bool catchForPlayer;
    public static int shootBullets;
    private float tiempo;
    private float tiempoMinimo;
    private RaycastHit disparo;
    private Vector3 posicion;
    private Vector3 direccion;
    private int rango;
    private Quaternion rotacion ;
    private int cargador;

    private Animator anim;
    public static bool enable;
    private bool shooting;
    public static GameObject rifle;
    private float contador;

    // Use this for initialization
    void Start () {
        contador = 0;
        rango = 100;
        catchForPlayer = false;
        maxNumBullets = 30;
        shootBullets = 30;
        //      cargador = 90;
        tiempo = 0.0f;
        tiempoMinimo = 0.3f;
        anim = GetComponent<Animator>();
        enable = true;
        shooting = false;
        anim.SetBool("Enable", enable);
        anim.SetBool("Shooting", shooting);

    }
	
	// Update is called once per frame
	void Update ()
    {
        contador++;
        texto.text = ("30 - " + shootBullets);
        tiempo += Time.deltaTime;
        if (shooting && tiempo > tiempoMinimo)
        {
            shooting = false;
            anim.SetBool("Shooting", shooting);
        }
        anim.SetBool("Enable", enable);
        posicion = transform.parent.position;
        direccion = transform.TransformDirection(Vector3.forward);
        rotacion = Quaternion.FromToRotation(Vector3.up, disparo.normal);

        if (Input.GetButton("Fire1") && enable && !shooting)
        {
            ShootingRuting();
        }
        if (Input.GetButton("Reload") && enable && tiempo > 1) {
            //shootBullets = maxNumBullets;
            Invoke("Recargar", 0);
        }


    }


    void ShootingRuting()
    {
        //Debug.Log("Primer if");
        if ((shootBullets >= 1))
        {
            shooting = true;
            anim.SetBool("Shooting", shooting);
            shootBullets--;
            // Debug.Log("Dentro del segundo iff");
            if (Physics.Raycast(posicion, direccion, out disparo, rango)) {
                //Debug.Log(disparo.collider.tag);
                if (disparo.collider.tag == "Enemy") {
                    GameObject zombie = disparo.collider.gameObject;
                    zombie.GetComponent<EnemyController>().quitarVida(DAMAGE);
                }
                else if(disparo.collider.tag == "Tierra"){
                    //Instantiate(objeto, disparo.point, rotacion);
                }
            }
            tiempo = 0;

        }

        //if (Input.GetButton("Reload"))
        //{
        //    //shootBullets = maxNumBullets;
        //    Invoke("Recargar", 1);
        //}
    }

    void Recargar()
    {
        shootBullets = maxNumBullets;
  //      cargador -= maxNumBullets;
    }

    public static void Activate()
    {
        enable = true;
        //rifle.SetActive(true);
    }

    public static void Deactivate()
    {
        enable = false;
        //rifle.SetActive(false);
    }
}

