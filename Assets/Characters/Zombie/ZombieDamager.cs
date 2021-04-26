using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamager : MonoBehaviour
{
    public void damage(Transform target)
    {
        StartCoroutine("attack", target);
    }

    public IEnumerator attack(Transform target)
    {
        yield return new WaitForSeconds(2.0f);
        Vector3 diff = gameObject.transform.position - target.position;
        if (diff.sqrMagnitude < 1)
            target.GetComponent<Character>().Health -= 5;
    }
}
