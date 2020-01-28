using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void QuitGame()
    {
    Debug.Log("User has quit the game");
    Application.Quit();

    }
}
