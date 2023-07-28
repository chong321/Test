using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenComputer : MonoBehaviour
{

    public void goIntoPC()
    {
        SceneManager.LoadScene("Computer");
    }
}
