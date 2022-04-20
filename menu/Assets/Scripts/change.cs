using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class change : MonoBehaviour
{
    /// <summary>

    /// </summary>
    public void Scene1()
    {
        SceneManager.LoadScene("menu1");
        //
    }
    /// <summary>
    /// </summary>
    public void Scene2()
    {
        SceneManager.LoadScene("menu2");
        //
    }
}
