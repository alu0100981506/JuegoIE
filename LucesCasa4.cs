using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucesCasa4 : MonoBehaviour
{
    private ParticleSystem system;
    LucesCasa4 control;

    // Start is called before the first frame update
    void Start()
    {
        this.system = GetComponent<ParticleSystem>();
        GameController.lucesCasa4 += changeState;
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
