using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public GameObject ballprefab;
    //public GameObject ballSpawnner1;
    //public GameObject ballSpawnner2;
    public GameObject startMenuInamge;
    public Button StartBtn;
    public Button Quitbtn;
   // public GameObject level_1_image;
    //public bool islevel1 = false;
    //public GameObject level_2_image;

   
    


    //public GameObject evelCompleteImage;
    //public GameObject level_2_nextExitImage;
    //public GameObject level_2_playAgainImage;
    //public GameObject level_2_gameOverImage;
    
    //public Button level_2_Exitbtn;
    //public bool isLevel1Completed = false;
   // public Button level_2_PlayAgainbtn;

    //public static GameManager obj;

    private void Awake()
    {
        //DontDestroyOnLoad();

    }
    private void Start()
    {
        //obj = this;
        startMenuInamge.SetActive(true);
    }

    public void start_btn()
    {
        //AsyncOperation scene1 = SceneManager.LoadSceneAsync("menuManager", LoadSceneMode.Additive);
        //scene1.allowSceneActivation = false;
        //AsyncOperation scene2 = SceneManager.LoadSceneAsync("level_1", LoadSceneMode.Additive);
        //scene2.allowSceneActivation = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //canvasmanager_1.cm1.level_1Image.SetActive(true);
        //level_1_image.SetActive(true);
    }
   
    //public void PlayAgain_btn()
    //{
    //    if (isLevel1Completed)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //        //this.transform.position = ballSpawnner2.transform.position;
    //        //level_2_image.SetActive(true);
    //        //level_1_image.SetActive(false);
    //        //Instantiate(ballSpawnner2, ballSpawnner2.transform.position, Quaternion.identity);
    //    }
    //    else
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //        //level_2_image.SetActive(false);
    //        //level_1_image.SetActive(true);
    //       // Instantiate(ballSpawnner1, ballSpawnner1.transform.position, Quaternion.identity);
    //        //this.transform.position = ballSpawnner1.transform.position;
    //    }
        
    //}
   
   
    public void Quti_btn()
    {
        Application.Quit();
    }


}
