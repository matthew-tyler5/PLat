using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform FirePosition;
    public GameObject projectile;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, FirePosition.position, FirePosition.rotation);
        }
    }
}
