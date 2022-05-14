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
            //Debug.Log("Zemine �arpti.");

            //SceneManager.LoadScene(0);

            Time.timeScale = 0; //zamani durdurur

            _gameOverPanel.SetActive(true);
        }
    }


    public void TekrarBaslat()
    {
        SceneManager.LoadScene(0); //sahneyi y�kler

        Time.timeScale = 1; //zamani eski haline getirir
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Izometrik TileMap yap (Sadece tasar�m).

    //Internetten bulunan spritelarla k�rm�z� ba�l�kl� k�z yap.

    //mermi yap
}
