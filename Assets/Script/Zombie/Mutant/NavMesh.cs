using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform Target;
    NavMeshAgent agent;
	private Animator _animator;
    bool attacking;

    void Start()
    {
		_animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Target.position);
        Vector3 diff = gameObject.transform.position - Target.position;
        if (diff.sqrMagnitude < 1 && attacking == false){
			_animator.SetBool("Attack", true);
            gameObject.GetComponent<ZombieDamager>().damage(Target);
            attacking = !attacking;
            StartCoroutine("Attack");

		}else{
			_animator.SetBool("Attack", false);
		}
        //Debug.Log(attacking);
    }

    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(2.5f);
        attacking = !attacking;
    }
}
