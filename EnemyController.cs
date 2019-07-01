using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent zombie;
    private int walkAnimation = 0;
    private int runAnimation = 0;
    private int attackAnimation = 0;
    private float speed = 2f;
    private bool attack = false;
    private Animator anim;
    private float contador;



    public int vida = 10;
    public GameObject posJugador;


    private void Awake()
    {
        zombie = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        contador = 0f;
    }

    public void quitarVida(int danio)
    {
        vida -= danio;
    }

    // Start is called before the first frame update
    void Start()
    {
        contador = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        walkAnimation = Random.Range(1, 3);
        runAnimation = Random.Range(1, 3);
        attackAnimation = Random.Range(1, 5);
        var distancia = posJugador.transform.position - zombie.transform.position;
        if (distancia.magnitude < 2)
            attack = true;
        else
            attack = false;

        anim.SetInteger("Walk Animation", walkAnimation);
        anim.SetInteger("Run Animation", runAnimation);
        anim.SetInteger("Attack Animation", attackAnimation);
        anim.SetInteger("Life", vida);
        anim.SetFloat("Speed", speed);
        anim.SetBool("Attack", attack);

        if(vida > 0)
            zombie.SetDestination(posJugador.transform.position);
        if (vida <= 0)
        {
            zombie.isStopped = true;
            contador += Time.deltaTime;
            if(contador > 3)
            {
                Destroy(gameObject);
                GameController.eliminarZombieActivo();
                GameController.sumarPunto();
            }
        }
            

    }


}
