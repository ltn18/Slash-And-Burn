using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCase : InteractableObject
{
	float speed = 0.5f;
    bool onInteraction = false;
	bool isFocus = false;
    private void Update()
    {
        if(onInteraction)
            transform.eulerAngles = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(90, 0, 0), Time.time * speed);
		if(isFocus){
			transform.eulerAngles = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(90, 0, 0), Time.time * speed);
		}
	}
    override public void OnInteraction()
    {
        /*
		while (gameObject.transform.rotation.x < 90f)
			transform.eulerAngles = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(90, 0, 0), Time.time * speed);
        */
        onInteraction = true;
        Debug.Log("e pressed");
	}
	override public void OnFocus()
    {
		isFocus = true;
	}

	
    
}
