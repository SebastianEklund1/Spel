using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SCP_Truck_Movement : MonoBehaviour

{
    public GameObject SCP_Truck;
    [SerializeField] float speed = 5f;
    Rigidbody2D Rb;
    Transform target;
    Vector2 moveDirection;
    int HP = 10;
    public GameObject SCP_Bulletprefab;
    Transform SCP_Bullet_Spawn;
    public float SCP_Bullet_Speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("MainCar").transform;
    }


    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HP -= 1;
        if (HP == 0)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            moveDirection = direction;
          
        }
        Instantiate(SCP_Bulletprefab, SCP_Bullet_Spawn.position, SCP_Bullet_Spawn.rotation);
        SCP_Bulletprefab.GetComponent<Rigidbody2D>().velocity = SCP_Bullet_Spawn.right * SCP_Bullet_Speed;
    }

    private void FixedUpdate()
    {
        if (target)
        {
            Rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }


    }

  

}   
