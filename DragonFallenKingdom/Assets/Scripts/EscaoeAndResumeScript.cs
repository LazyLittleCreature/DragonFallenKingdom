using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscaoeAndResumeScript : MonoBehaviour
{
    public GameObject _pause;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pause.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    public void ResumeButton()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }
}
