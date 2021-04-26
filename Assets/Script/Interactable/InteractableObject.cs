using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    //private Material NotPointing;
   // private Material Pointing;
    virtual public void OnFocus()
    {
        //gameObject.GetComponent<MeshRenderer>().material = Pointing;
    }

    virtual public void OnLeave()
    {
        //gameObject.GetComponent<MeshRenderer>().material = NotPointing;
    }
	
    virtual public void OnInteraction()
    {
        
    }
}
