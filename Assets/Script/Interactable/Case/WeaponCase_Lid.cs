using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCase_Lid : MonoBehaviour
{
	void Start(){
		float posX = Random.Range(-10,10);
		float posZ = Random.Range(-10,10);
		transform.position = new Vector3(posX,0,posZ);
	}
	public void OnFocus()
    {
		gameObject.transform.Rotate(new Vector3(0f, 0f, 90f));
		Debug.Log("case Lid");
    }

	public void OnLeave()
    {
		gameObject.transform.Rotate(new Vector3(0f, 0f, -90f));
    }


	/*
	void OnTriggerEnter(Collider other){
		PlayerCharacter player = other.GetComponent<PlayerCharacter>();
		if (player != null) {
			transform.Rotate(90,0,0);
			float Group1 = Random.Range(0, 2); // for different selections new weapon/upgrade/health
			if(Group1 == 0){
				float Group_weapon = Random.Range(0,5); // six different weapons
				if(Group_weapon==0){
				}else if(Group_weapon == 1){
				}else if(Group_weapon == 2){
				}else if(Group_weapon == 3){
				}else if(Group_weapon == 4){
				}else{
				}
			}else if(Group1 == 1){
				float Group_upgrade = Random.Range(0,3); //4 different upgrade
				if(Group_upgrade==0){
				}else if(Group_upgrade == 1){
				}else if(Group_upgrade == 2){
				}else{
				}
			}else{	//health recover
			}
			Destroy(this.gameObject);
		}
		
	}
	*/
}
