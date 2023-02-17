using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance;
    private void Awake(){
        Instance = this;
    }
    public void LoadMap(){
        SceneManager.LoadScene(1);
    }
}
