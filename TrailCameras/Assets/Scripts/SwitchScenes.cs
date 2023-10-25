using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void LoadScene1() 
    {
        SceneManager.LoadScene("MainGame");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("HomeScreen");  
    }
}
