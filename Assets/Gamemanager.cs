using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject Ga;
    public void EndGame()
    {
	Debug.Log("Game");
	Invoke("Restart", 3f);
    }
    public void GameOver()
    {
	Ga.SetActive(true);
    }
    void Restart()
    {
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
