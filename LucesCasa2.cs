using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesCasa2 : MonoBehaviour
{
    private ParticleSystem system;
    LucesCasa2 control;

    // Start is called before the first frame update
    void Start()
    {
        this.system = GetComponent<ParticleSystem>();
        GameController.lucesCasa2 += changeState;
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

   
}
