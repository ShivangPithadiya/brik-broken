using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasmanager_2 : MonoBehaviour
{
    public GameObject level_2Image;
    //public static BottomCollider bc2;
    public GameObject levelCompleteImage;
    public GameObject congoImage;
    //public Button PlayAgainbtn;
    public GameObject playAgainImage;
    public GameObject gameOverImage;
    //public Button level_2_Exitbtn;
    //public bool isLevel1Completed = false;
    public bool islevel2 = false;
    public static canvasmanager_2 cm2;
    //public static ballmanager2 ballmanager2.ballmanager2.ballmanager2.bm22;
    // Start is called before the first frame update
    void Start()
    {
        cm2 = this;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (ballmanager2.bm2.oneDestroyed && ballmanager2.bm2.twoDestroyed && ballmanager2.bm2.ThreeDestroyed && ballmanager2.bm2.fourDestroyed && ballmanager2.bm2.fiveDestroyed && ballmanager2.bm2.sixDestroyed && ballmanager2.bm2.sevenDestroyed)
        {
            level_2Image.SetActive(true);
            levelCompleteImage.SetActive(true);
            congoImage.SetActive(true);
            //level_1_nextExitImage.SetActive(true);
            //isLevel1Completed = true;
            Debug.Log("levelComplete");
        }
        //if (BottomCollider.bc.bottomTrigered && islevel2)
        //{
        //    level_2Image.SetActive(false);
        //    //gameOverImage.SetActive(true);
        //    playAgainImage.SetActive(true);

        //}

    }
   
    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //    if (collision.gameObject.CompareTag("BottomCollider"))
    //    {
    //        Debug.Log("BottomCollider");
    //        //gameOverImage.SetActive(true);
    //        //playAgainImage.SetActive(true);



    //    }
    //}
    public void level_2_exit_button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        level_2Image.SetActive(true);
        levelCompleteImage.SetActive(false);
        playAgainImage.SetActive(false);
        gameOverImage.SetActive(false);
        congoImage.SetActive(false);

    }
    public void playagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        level_2Image.SetActive(true);
        levelCompleteImage.SetActive(false);
        congoImage.SetActive(false);
        playAgainImage.SetActive(false);
        gameOverImage.SetActive(false);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("BottomCollider"))
    //    {

    //        gameOverImage.SetActive(true);
    //        playAgainImage.SetActive(true);


    //    }
    //}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("BottomCollider"))
    //    {

    //        gameOverImage.SetActive(true);
    //        playAgainImage.SetActive(true);


    //    }
    //}
}
