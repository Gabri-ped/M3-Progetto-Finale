using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed;
    private Rigidbody2D _rb;
   public Vector2 Dir { get;  set; }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Dir = new Vector2(h, v).normalized;
        _rb.MovePosition( _rb.position + Dir * (_speed * Time.deltaTime) );
    }
}
