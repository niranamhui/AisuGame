using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CPR_LINE : MonoBehaviour
{   
    public void LoadScene(string nameScenes)
    {
        SceneManager.LoadScene(nameScenes);
    }
}

