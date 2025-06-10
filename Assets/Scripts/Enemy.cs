using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public  class Enemy: MonoBehaviour
{
    [SerializeField] float _speed;
    private PlayerController _playerController;
    private Transform player;
    private Animator _animator;
    private LifeController _lifeController;
    
    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _animator = GetComponent<Animator>();
        _lifeController = GetComponent<LifeController>();
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
    void FixedUpdate()
    {
        EnemyMovement();
        EnemyAnimator();
    }

    void EnemyMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, _speed * Time.deltaTime);
    }

    private void EnemyAnimator()
    {
        Vector2 _direction = new Vector2(transform.position.x, transform.position.y);
        if (player != null)
        {
            Vector2 dir2 = _direction - new Vector2(player.transform.position.x, player.transform.position.y);
            _animator.SetFloat("xDir", dir2.x);

            _animator.SetFloat("yDir",dir2.y);


        }

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Bullet _b = collision.collider.GetComponent<Bullet>();
            if (_b != null)
            {
                Debug.Log(_lifeController.CurrentHp);
                _lifeController.AddHp(-_b._damage);
            }
        }
    }
}
