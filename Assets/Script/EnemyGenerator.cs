using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GetEnemy",3,1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetEnemy()
    {
        Instantiate(Enemy, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }
}
