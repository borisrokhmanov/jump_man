using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitCollider : MonoBehaviour
{
    public CharController CharCont;
    public Transform target;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "Jump Man")
        {
            CharCont.transform.position = target.position;
            
        }
        
    }
}
