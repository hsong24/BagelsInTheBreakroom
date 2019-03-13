using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("MoveTest");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("I quitted i swear");
    }
}
