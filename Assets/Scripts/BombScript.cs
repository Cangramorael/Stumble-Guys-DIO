using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float ExplosionDelay = 5f;

    public GameObject ExplosionPrefab;

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
        //To do

        //Create SFX
        //To do

        //Destroy Bomb
        Destroy(gameObject);
    }
}
