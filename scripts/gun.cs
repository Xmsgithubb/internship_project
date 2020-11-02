
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpscam;
    public float impact = 50f;
   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

               
    }
    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range ))
        {
            Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.takedmg(damage);
            }
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impact);
            }    
        }
    }

}
