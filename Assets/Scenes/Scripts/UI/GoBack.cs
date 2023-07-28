using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    [SerializeField] Button close;
    // Start is called before the first frame update
    void Start()
    {
        close.onClick.AddListener(closeWin);
    }

    private void closeWin()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
