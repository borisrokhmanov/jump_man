using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public CharController CharCont;
    public LevelManager levelManager;
    public string level;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "Jump Man")
        {
            levelManager.LoadLevel(level);
        }
        
    }
}
