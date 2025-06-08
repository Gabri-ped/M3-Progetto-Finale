using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public  class Enemy: MonoBehaviour
{
    [SerializeField] float _speed;
    private PlayerController _playerController;
    private Transform player;
    public Vector2 _dir {  get;  set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }


    }

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }
    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
        if(gameObject != null)
        {
            player = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }
    void EnemyMovement()
    {
        transform.position = Vector2.(transform.position, player.position, _speed * Time.deltaTime);
    }
}
