using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveDamager : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    bool canExplode = true;
    public void Explode()
    {
        if (canExplode)
        {
            canExplode = false;
            explosion.SetActive(true);
            StartCoroutine(reload());
            Collider[] collider = Physics.OverlapSphere(gameObject.transform.position, 2);
            foreach(Collider a in collider)
            {
                if(a.GetComponent<Character>() != null)
                {
                    a.GetComponent<Character>().Health -= 5;
                }
            }
        }
    }

    public IEnumerator reload()
    {
        yield return new WaitForSeconds(1f);
        explosion.SetActive(false);
        canExplode = true;
    }
}
