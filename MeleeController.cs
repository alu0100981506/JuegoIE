using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
    public static GameObject katana;
    public Camera fpscam;
    public float range;
    public LayerMask myLayerMask;


    private Animator anim;
    private bool attack;
    public static bool enable;
    private float attackDelay;
    private float DELAY = 0.5f;
    private int count;
    private int DAMAGE = 100;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        attack = false;
        enable = false;
        anim.SetBool("Attack", attack);
        anim.SetBool("Enable", enable);
        attackDelay = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Enable", enable);

        if (attack)
        {
            attack = false;
            anim.SetBool("Attack", attack);
        }
        

        attackDelay -= Time.deltaTime;
        if (Input.GetAxis("Fire1") > 0.0 && attackDelay <= 0)
        {
            attack = true;
            anim.SetBool("Attack", attack);
            //Attack();
            attackDelay = DELAY;
        }

        
    }

    //private void OnCollisionTrigger(Collision collision)
    //{
    //    Debug.Log(collision.gameObject.tag);
    //    if(attack && collision.gameObject.CompareTag("Enemy"))
    //    {
    //        collision.gameObject.GetComponent<EnemyController>().quitarVida(DAMAGE);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyController>().quitarVida(DAMAGE);
        }
    }

    //void Attack()
    //{
    //    RaycastHit hit;
    //    if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range, myLayerMask))
    //    {
    //        Debug.Log(hit.transform.name);
    //    }
    //}

    public static void Activate()
    {
        //katana.SetActive(true);
        enable = true;
    }

    public static void Deactivate()
    {
        enable = false;
        //katana.SetActive(false);
    }
}
