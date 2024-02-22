using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float ExplosionDelay = 5f;

    public GameObject ExplosionPrefab;

    public float BlastRadius = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplosionCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator ExplosionCoroutine(){
        //Wait
        yield return new  WaitForSeconds(ExplosionDelay);

        //Explode
        Explode();
    }

    private void Explode() {
        //Create VFX
        Instantiate(ExplosionPrefab, transform.position, ExplosionPrefab.transform.rotation);

        //Destroy plataforms
        Collider[] colliders = Physics.OverlapSphere(transform.position, BlastRadius);
        foreach(Collider collider in colliders) {
            GameObject hitObject = collider.gameObject;
            if(hitObject.CompareTag("Platform")) {
                Destroy(hitObject);
            }
        }

        //Create SFX
        //To do

        //Destroy Bomb
        Destroy(gameObject);
    }
}
