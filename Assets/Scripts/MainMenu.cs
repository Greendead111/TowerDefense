using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Dictionary<int, string> levelDict = new Dictionary<int, string>();
        
        

    void Start()
    {
        levelDict.Add(0, "TestLevel");
    }


    public void StartScene(int lvl)
    {
        SceneManager.LoadScene(levelDict[lvl]);
        SceneManager.LoadScene("ManagerScene", LoadSceneMode.Additive);
    }
    
}
