using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerController _playerController;
    // Start is called before the first frame update
    void Start()
    {
      _animator = GetComponent<Animator>();
      _playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(_playerController.Dir != Vector2.zero)
        {
            _animator.SetBool("isWalk", true);
            _animator.SetFloat("xDir", _playerController.Dir.x);
            _animator.SetFloat("yDir", _playerController.Dir.y);
        }
       else
        {
            _animator.SetBool("isWalk", false);
        }
    }
}
