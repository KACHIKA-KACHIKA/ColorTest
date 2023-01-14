using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject Ask_panel;
    private GameObject[] gameObjects;
    private bool check= false;
    public void BtnEndClick()
    {
        if (!GetComponent<Menu>().StartPanel.activeSelf && !check)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("ProgrammUI");
            check = true;
        }
        if (Ask_panel.activeSelf)
        {
            for (int i = 0; i < gameObjects.Length; ++i)
            {
                gameObjects[i].SetActive(true);
            }
            Ask_panel.SetActive(false);
        }
        else
        {
            for (int i = 0; i < gameObjects.Length; ++i)
            {
                gameObjects[i].SetActive(false);
            }
            Ask_panel.SetActive(true); 
        }
    }
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        
    }
}
