using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadBegin : MonoBehaviour
{
    public LevelManager levelmanager;
    public Button yourButton;

    void start ()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick ()
    {
        levelmanager.LoadLevel("BeginScreen");
    }
}

