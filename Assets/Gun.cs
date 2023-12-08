using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject Bulletprefab;
    public float bulletSpeed = 10;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Bullet = Instantiate(Bulletprefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
        }

    }
}
