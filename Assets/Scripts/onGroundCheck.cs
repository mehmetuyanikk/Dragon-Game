using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onGroundCheck : MonoBehaviour
{

    [SerializeField] GameObject _gameOverPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dusman")
        {
            Time.timeScale = 0;

            _gameOverPanel.SetActive(true);
        }
    }

    public void TekrarBaslat()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1;
    }

}
