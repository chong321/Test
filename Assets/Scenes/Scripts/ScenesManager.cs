using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;


    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Gameplay,
        Computer
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadComputer()
    {
        SceneManager.LoadScene(Scene.Computer.ToString());
    }

    public void goBack()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
