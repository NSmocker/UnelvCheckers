using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

    public void Size6()
    {
        Info.size = 6;
        SceneManager.LoadScene("game");
    }
    public void Size8()
    {
        Info.size = 8;
        SceneManager.LoadScene("game");
    }
    public void Size10()
    {
        Info.size = 10;
        SceneManager.LoadScene("game");
    }
    public void Size12()
    {
        Info.size = 12;
        SceneManager.LoadScene("game");
    }
}
