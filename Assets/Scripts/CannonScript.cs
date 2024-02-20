using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    // Prefab da bomba
    public List<GameObject> bombPrefabs;

    // Intervalo em Vector 2
    public Vector2 timeInterval = new Vector2(1, 1);

    // Referencia pro ponto de origem da bomba (GameObject)
    public GameObject spawnPoint;

    // Referencia ao nosso alvo
    public GameObject target;
    
    // Range (float)
    public float rangeInDegrees;

    // Força (Vector2)
    public Vector2 force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Temporizador (cooldown, interval, DeltaTime)
    }
}
