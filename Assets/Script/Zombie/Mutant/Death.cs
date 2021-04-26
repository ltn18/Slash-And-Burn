using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Death : MonoBehaviour
{
	private Animator _animator;
	private bool b = true;
	[SerializeField] private GameObject weaponCase;
    // Start is called before the first frame update
	void Start()
    {
		_animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Character>().Health == 0 && b == true){
			GetComponent<NavMesh>().enabled = false;
			GetComponent<ZombieDamager>().enabled = false;
			GetComponent<NavMeshAgent>().enabled = false;
			_animator.SetBool("Die", true);
			StartCoroutine(OnWaitMethod());
			b=false;
		}
    }
	IEnumerator OnWaitMethod()
	{
		yield return new WaitForSeconds(2f);
		GameObject _weaponCase = Instantiate(weaponCase) as GameObject;
		Vector3 pre_pos = this.GetComponent<Transform>().position;
		_weaponCase.GetComponent<Transform>().position = pre_pos;
		Destroy(this.gameObject);
	}
}
