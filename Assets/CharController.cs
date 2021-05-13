using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public int movementspeed = 10;
    enum GravityDirection { Down, Up };
    GravityDirection m_GravityDirection;
    public int gravPos = 1;
    public bool gravLock = false;
    public float groundPos;

    void Start()
    {
        m_GravityDirection = GravityDirection.Down;
        groundPos = transform.position.y;
    }

    void Update()
    {

        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * movementspeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * movementspeed * Time.deltaTime * gravPos);

            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
            }

            switch (m_GravityDirection)
            {
                case GravityDirection.Down:
                    Physics2D.gravity = new Vector2(0, -9.8f);
                    if (Input.GetKeyDown(KeyCode.F) && gravLock == false)
                    {
                        m_GravityDirection = GravityDirection.Up;
                        gravPos = -1;
                        gravLock = true;
                    }
                    break;

                case GravityDirection.Up:
                    Physics2D.gravity = new Vector2(0, 9.8f);
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        m_GravityDirection = GravityDirection.Down;
                        gravPos = 1;
                    }
                    break;
            }
            if (groundPos >= transform.position.y)
            {
                gravLock = false;
            }
        }
    }
}