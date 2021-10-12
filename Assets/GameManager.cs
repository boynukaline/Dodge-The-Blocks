using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void EndGame()
    {
        StartCoroutine("RestartLevel");
    }

    IEnumerator RestartLevel()
    {

        Time.timeScale = 0.05f;
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 1.0f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
