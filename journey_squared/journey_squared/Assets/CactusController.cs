using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusController : MonoBehaviour
{
    public CharController CharCont;
    public Transform target;
    public Rigidbody2D fireball;
    public float fireballSpeed = 8f;
    public bool fire = true;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CharCont.transform.position = target.position;
    }

    public void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        for (; ; )
        {
            var fireballInst = Instantiate(fireball, transform.position, Quaternion.Euler(new Vector2(0, 0)));
            fireballInst.velocity = new Vector2(fireballSpeed, -1);
            yield return new WaitForSeconds(2);
        }
    }

    public void Update()
    {
        
        
    }
}
