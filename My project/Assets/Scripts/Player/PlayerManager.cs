using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int cointCount;
    
    public void PickupItem(GameObject obj)
    {
        switch(obj.tag)
        {
            case "Currency":
                cointCount++;
                break;
             default:
                break;
        }
    }

}
