using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropdownScript : MonoBehaviour
{
    public void DropdownLoad(int index){
        switch(index){
            case 0: SceneManager.LoadScene(1); break;
            case 1: SceneManager.LoadScene(2); break;
            case 2: SceneManager.LoadScene(1); break;
        }
    }
}
