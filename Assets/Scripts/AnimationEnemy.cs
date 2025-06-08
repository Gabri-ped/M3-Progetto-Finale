using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    private Animator _animator;
    private Enemy _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy._dir != Vector2.zero)
        {
            _animator.SetBool("isWalk", true);
            _animator.SetFloat("xDir",_enemy.transform.position.x);
            _animator.SetFloat("yDir",_enemy.transform.position.y);
        }
        else
        {
            _animator.SetBool("isWalk",false);
        }
    }
}
