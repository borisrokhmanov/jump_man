using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDestructionScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name == "fireball(Clone)")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
