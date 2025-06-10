using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    [SerializeField] private GameObject weaponPrefab;
    [SerializeField] private Transform weaponParent;
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] private Transform _hand;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EquipWeapon(other.transform);
            Destroy(gameObject, destroyDelay);
        }
    }

    private void EquipWeapon(Transform player)
    {
        if (weaponPrefab == null) return;


        if (weaponParent == null)
        {
            weaponParent = player.Find("Player") ?? player;
        }


        GameObject newWeapon = Instantiate(weaponPrefab, _hand);
        newWeapon.transform.localPosition = _hand.transform.localPosition;
        newWeapon.transform.localRotation = _hand.transform.localRotation;
        newWeapon.transform.localScale = _hand.transform.localScale;
    }
}
