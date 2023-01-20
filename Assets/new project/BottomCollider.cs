using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomCollider : MonoBehaviour
{
    //public static BottomCollider bc;
    //public bool bottomTrigered = false;
    // Start is called before the first frame update
    void Start()
    {
       // bc = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("ball collided");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            //bottomTrigered = true;
           // canvasmanager_1.cm1.islevel1 = true;


            //if (bottomTrigered && canvasmanager_1.cm1.islevel1)
            //{
            //    // Time.timeScale = 0;
            //    //gameOverImage.SetActive(true);
            //    canvasmanager_1.cm1.level_1Image.SetActive(false);
            //    canvasmanager_1.cm1.playAgainImage.SetActive(true);

            //}
        }
    }
}
