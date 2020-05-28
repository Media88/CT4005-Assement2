using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public void FullscreenToggle (bool FullScreenOn) // toggles fullscreen.
    {
        Screen.fullScreen = FullScreenOn;
    }
}
