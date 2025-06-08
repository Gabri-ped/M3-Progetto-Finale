using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _currentHP = 10;
    [SerializeField] private int _MaxHP = 18;
    

    public int GetHP() => _currentHP;
    public int GetMaxHP() => _MaxHP;

    public void SetHp(int hp)
    {
        hp = Mathf.Clamp(hp, 0,_MaxHP);
        
        _currentHP = hp;

        if(_currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetMaxHP(int maxHP)
    {
        maxHP = Mathf.Max(1, maxHP);
        SetHp(_currentHP);
    }
}
