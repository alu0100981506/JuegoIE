using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    GameController control;
    public delegate void cambiarFog(bool onOf);
    public delegate void encerderLuces(bool onOf);
    public static event encerderLuces lucesCasa1;
    public static event encerderLuces lucesCasa2;
    public static event encerderLuces lucesCasa3;
    public static event encerderLuces lucesCasa4;
    public static event cambiarFog fog;
    private const int INITIALRUNGAME = 1000;
    public const int NUMBER_OF_ZOMBIES = 24;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public Text text_puntos;
    public Text text_ronda;
    static int pto = 0;
    private int ronda;
    static private int zombiesActivos;
    private int zombiesEsperados;
    private int zombiesSpawneados;
   
    static private int zombiesMuertos;
    // Start is called before the first frame update
    void Awake()
    {


       /* if (control == null) {
            control = this;
            DontDestroyOnLoad(control);
        }
        else if (control != this)
        {
           Object.Destroy(control);
        }*/
        //lucesCasa2(false);
        //lucesCasa3(false);
        //lucesCasa4(false);
    }

    void Start()
    {
        
        zombiesActivos = 0;
        zombiesEsperados = 6;
        zombiesSpawneados = 0;
        zombiesMuertos = 0;
       
        Debug.Log("JAJAJAJAJA HASTA LA PUTA ESTOY DE ESTA MIERDA-!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!111");
    
        ronda = 0;
        pto = 0;
        finRonda();

    }
    public static void sumarPunto()
    {
        pto++;
    }

    // Update is called once per frame
    void Update()
    {
        text_puntos.text = "" + pto;
        text_ronda.text = ""+ ronda;
        spawnearZombies();
        /*Debug.Log("estos son los zombies activados" + zombiesActivos);
        Debug.Log("estos son los zombies esperados" + zombiesEsperados);
        Debug.Log("estos son los zombies Spawneados" + zombiesSpawneados);
        Debug.Log("estos son los zombies muertos" + zombiesMuertos);
        */
        if (zombiesEsperados == zombiesMuertos) {
            finRonda();
        }

       
    }
    private void finRonda()
    {
        ronda++;
        zombiesMuertos = 0;
        zombiesSpawneados = 0;
        if (ronda % 3 == 0)
        {
            fog(true);
        }
        else
        {
            fog(false);
        }
        if (ronda % 2 == 0)
        {
            lucesCasa1(true);
        }
        else
        {
            lucesCasa1(false);
        }

        if (ronda % 3 == 0)
        {
            lucesCasa2(true);
        }
        else
        {
            lucesCasa2(false);
        }

        if (ronda % 4 == 0)
        {
            lucesCasa3(true);
        }
        else
        {
            lucesCasa3(false);
        }

        if (ronda % 5 == 0)
        {
            lucesCasa4(true);
        }
        else
        {
            lucesCasa4(false);
        }
        zombiesMuertos = 0;
        zombiesSpawneados = 0;

        if (ronda < 10)
            zombiesEsperados = (int)(0.0842 * Mathf.Pow(ronda, 2) + 0.1954 * ronda + 22.05 - 16 / ronda);
        else
            zombiesEsperados = (int)(0.0842 * Mathf.Pow(ronda, 2) + 0.1954 * ronda + 22.05);

        if (ronda > 1) { 
        enemy.GetComponent<EnemyNavigation>().vida *= 1.25;
        enemy1.GetComponent<EnemyNavigation>().vida *= 1.25;
        enemy2.GetComponent<EnemyNavigation>().vida *= 1.25;
        enemy3.GetComponent<EnemyNavigation>().vida *= 1.25;
        }
    }


    static public void eliminarZombieActivo()
    {
        zombiesActivos--;
      //  sumarPunto();
        zombiesMuertos++;
    }

    void spawnearZombies()
    {
        if(zombiesActivos  < NUMBER_OF_ZOMBIES && zombiesSpawneados < zombiesEsperados) {
            switch (Random.Range(1, 5)) {
                case 1:
                    zonaA();
                    break;
                case 2:
                    zonaB();
                    break;
                case 3:
                    zonaC();
                    break;
                case 4:
                    zonaD();
                    break;
            }
            zombiesActivos++;
            zombiesSpawneados++;
        }
    }

    void zonaA()
    {
        switch (Random.Range(1, 5)) {
            case 1:
                Instantiate(enemy, new Vector3(19.0F, 2.0F, -60.0F), Quaternion.identity).SetActive(true);
                break;
            case 2:
                Instantiate(enemy1, new Vector3(19.0F, 2.0F, -60.0F), Quaternion.identity).SetActive(true);
                break;
            case 3:
                Instantiate(enemy2, new Vector3(19.0F, 2.0F, -60.0F), Quaternion.identity).SetActive(true);
                break;
            case 4:
                Instantiate(enemy3, new Vector3(19.0F, 2.0F, -60.0F), Quaternion.identity).SetActive(true);
                break;
        }
        
    }

    void zonaB()
    {
        switch (Random.Range(1, 5)) {
            case 1:
                Instantiate(enemy, new Vector3(50.2F, 2.0F, 5.6F), Quaternion.identity).SetActive(true);
                break;
            case 2:
                Instantiate(enemy1, new Vector3(50.2F, 2.0F, 5.6F), Quaternion.identity).SetActive(true);
                break;
            case 3:
                Instantiate(enemy2, new Vector3(50.2F, 2.0F, 5.6F), Quaternion.identity).SetActive(true);
                break;
            case 4:
                Instantiate(enemy3, new Vector3(50.2F, 2.0F, 5.6F), Quaternion.identity).SetActive(true);
                break;
        }
    }

    void zonaC()
    {
        switch (Random.Range(1, 5)) {
            case 1:
                Instantiate(enemy, new Vector3(-1.0F, 2.0F, 53.6F), Quaternion.identity).SetActive(true);
                break;
            case 2:
                Instantiate(enemy1, new Vector3(-1.0F, 2.0F, 53.6F), Quaternion.identity).SetActive(true);
                break;
            case 3:
                Instantiate(enemy2, new Vector3(-1.0F, 2.0F, 53.6F), Quaternion.identity).SetActive(true);
                break;
            case 4:
                Instantiate(enemy3, new Vector3(-1.0F, 2.0F, 53.6F), Quaternion.identity).SetActive(true);
                break;
        }

    }

    void zonaD()
    {
        switch (Random.Range(1, 5)) {
            case 1:
                Instantiate(enemy, new Vector3(-52.2F, 2.0F, 18.6F), Quaternion.identity).SetActive(true);
                break;
            case 2:
                Instantiate(enemy1, new Vector3(-52.2F, 2.0F, 18.6F), Quaternion.identity).SetActive(true);
                break;
            case 3:
                Instantiate(enemy2, new Vector3(-52.2F, 2.0F, 18.6F), Quaternion.identity).SetActive(true);
                break;
            case 4:
                Instantiate(enemy3, new Vector3(-52.2F, 2.0F, 18.6F), Quaternion.identity).SetActive(true);
                break;
        }
    }



    public void destroyAllObjectsOfGame()
    {

       

        
    }






}
