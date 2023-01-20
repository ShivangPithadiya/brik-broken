using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasmanager_1 : MonoBehaviour
{
    //public static BottomCollider bc1
    public Button playagainbtn;
    public GameObject level_1Image;
    public GameObject level_1_nextExitImage;
    public GameObject playAgainImage;
    public GameObject gameOverImage;
    //public Button level_1_Exitbtn;
    //public Button PlayAgainbtn;
    //public Button level_1_Nextbtn;
    public GameObject levelCompleteImage;
    public GameObject congoImage;
    public static canvasmanager_1 cm1;

    public bool islevel1 = false;
    //public static BallManager BallManager.bm;
   // public GameManager obj;
    // Start is called before the first frame update
    void Start()
    {
        cm1 = this;
        level_1Image.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (BallManager.bm.oneDestroyed && BallManager.bm.twoDestroyed && BallManager.bm.ThreeDestroyed && BallManager.bm.fourDestroyed && BallManager.bm.fiveDestroyed && BallManager.bm.sixDestroyed && BallManager.bm.sevenDestroyed)
        {
            //StartCoroutine(timerlevelcomplete_1());

            level_1Image.SetActive(false);
            levelCompleteImage.SetActive(true);
            level_1_nextExitImage.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            // isLevel1Completed = true;
            Debug.Log("levelComplete");
        }
        //if (BottomCollider.bc.bottomTrigered && islevel1)
        //{
        //    // Time.timeScale = 0;
        //    //gameOverImage.SetActive(true);
        //    level_1Image.SetActive(false);
        //    playAgainImage.SetActive(true);
        //    playagainbtn.enabled = true;
        //    BottomCollider.bc.bottomTrigered = false;
        //    islevel1 = false;



        //}

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

//}

    public void level_1__next_btn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        canvasmanager_2.cm2.islevel2 = true;

        //level_2_image.SetActive(true);
        //level_1_image.SetActive(false);
    }
    public void level_1_exit_button()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        level_1Image.SetActive(false);
        level_1_nextExitImage.SetActive(false);
        levelCompleteImage.SetActive(false);
        playAgainImage.SetActive(false);
        gameOverImage.SetActive(false);
        congoImage.SetActive(false);
    }
    public void playagain_btn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Time.timeScale = 1;
        //level_1Image.SetActive(true);
        level_1_nextExitImage.SetActive(false);
        levelCompleteImage.SetActive(false);
        playAgainImage.SetActive(false);
        gameOverImage.SetActive(false);
        congoImage.SetActive(false);
    }

   
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("BottomCollider"))
    //    {

    //        gameOverImage.SetActive(true);
    //        playAgainImage.SetActive(true);


    //    }

    //}
}
