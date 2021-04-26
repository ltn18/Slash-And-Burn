using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : InteractableObject
{

    public Material onFocus;
    public Material onLeave;

    override public void OnFocus()
    {
        gameObject.GetComponent<MeshRenderer>().material = onFocus;
    }

    public override void OnLeave()
    {
        gameObject.GetComponent<MeshRenderer>().material = onLeave;
    }

    public override void OnInteraction()
    {
        gameObject.GetComponent<ExplosiveDamager>().Explode();
    }
}

