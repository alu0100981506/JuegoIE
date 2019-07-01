using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFog : MonoBehaviour
{

    public ParticleSystem system;
    ControlFog control;

    // Start is called before the first frame update
    void Start()
    {
        this.system = GetComponent<ParticleSystem>();
        GameController.fog += changeState;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void changeState(bool onOf)
    {

    
        if (onOf)
            this.system.Play();
        else
            this.system.Stop();
    }

    public ParticleSystem getSystem()
    {
        return this.system;
    }

   
}
