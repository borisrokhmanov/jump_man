using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public int movementspeed = 15;
    enum GravityDirection { Down, Up };
    GravityDirection m_GravityDirection;
    public int gravPos = 1;

    void Start()
    {
        m_GravityDirection = GravityDirection.Down;
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
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        m_GravityDirection = GravityDirection.Up;
                        gravPos = -1;
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
        }
    }
}