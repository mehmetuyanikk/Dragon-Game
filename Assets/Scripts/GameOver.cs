using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject _gameOverPanel;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (gameObject.CompareTag("dusman") || collision.gameObject.CompareTag("sagEngel"))
    //    {
    //        Time.timeScale = 0;
    //        _gameOverPanel.SetActive(true);
    //    }
    //}

    public void TekrarBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
