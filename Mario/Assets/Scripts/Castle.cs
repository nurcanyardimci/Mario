using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Application.LoadLevel("GameComplete");

        }
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void Restart(){
        SceneManager.LoadScene("GameOver");
    }
}
