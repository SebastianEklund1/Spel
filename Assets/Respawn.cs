using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour


{

    public Car car_2prefab;
    public Transform Car_Spawnprefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Car = Instantiate(car_2prefab, Car_Spawnprefab.position, Car_Spawnprefab.rotation); 
    }
}
