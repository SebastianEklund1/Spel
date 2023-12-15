using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D Car_rigidbody;
   public GameObject car_2prefab;
   public GameObject Car_Spawnprefab;
    public Transform Spawn; 
    

    // Start is called before the first frame update
    void Start()
    {
        Car_rigidbody = GetComponent<Rigidbody2D>();
        Car_rigidbody.AddForce(Vector3.left * 10, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       
    }
}
