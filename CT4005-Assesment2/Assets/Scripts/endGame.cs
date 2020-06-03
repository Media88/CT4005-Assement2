using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{

    [SerializeField]
    private GameObject endScreen;
    [SerializeField]
    private GameObject pauseScreen;

    private void Start()
    {
        endScreen.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(false);
    }

    private void Update()
    {
        
    }

}
