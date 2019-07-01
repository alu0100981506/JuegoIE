using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public double vida = 1;
    private NavMeshAgent enemy;
    public GameObject pos;
    
    private void Awake()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    public void quitarVida(int x)
    {
        vida -= x;

        if (vida <= 0) {
            Destroy(gameObject);
            GameController.eliminarZombieActivo();
            GameController.sumarPunto();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(pos.transform.position);
        
    }


}
