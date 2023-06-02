using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            manager.PickupItem(collision.gameObject);
        }
    }
}
