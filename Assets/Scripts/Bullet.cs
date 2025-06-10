using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Bullet : MonoBehaviour

{
    [SerializeField] float speed = 0.5f;
    private Rigidbody2D _rb;
    [SerializeField] private int _dmg = 1;
    public Vector2 dir {  get; set; }
    public int _damage => _dmg;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.velocity = dir * speed;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
