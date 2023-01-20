using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballmanager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public static ballmanager2 bm2;
    int maxHit1 = 1;
    int timesHit1;
    int numberOf1 = 1;
    public bool oneDestroyed = false;

    int maxHit2 = 1;
    int timesHit2;
    int numberOf2 = 1;
    public bool twoDestroyed = false;

    int maxHit3 = 1;
    int timesHit3;
    int numberOf3 = 1;
    public bool ThreeDestroyed = false;

    int maxHit4 = 1;
    int timesHit4;
    int numberOf4 = 1;
    public bool fourDestroyed = false;

    int maxHit5 = 1;
    int timesHit5;
    int numberOf5 = 1;
    public bool fiveDestroyed = false;

    int maxHit6 = 1;
    int timesHit6;
    int numberOf6 = 1;
    public bool sixDestroyed = false;

    int maxHit7 = 1;
    int timesHit7;
    int numberOf7 = 1;
    public bool sevenDestroyed = false;
    // public static GameManager game_manager;
    private Rigidbody2D rb;
    public PaddleManager instance;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        bm2 = this;
        rb = GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = instance.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.rb.velocity = new Vector2(2f, 10f);

            }
        }
       
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("one"))
        {
            timesHit1++;

            if (maxHit1 == timesHit1)
            {
                numberOf1--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("two"))
        {
            timesHit2++;
            if (maxHit2 == timesHit2)
            {
                numberOf2--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("three"))
        {
            timesHit3++;
            if (maxHit3 == timesHit3)
            {
                numberOf3--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("four"))
        {
            timesHit4++;
            if (maxHit4 == timesHit4)
            {
                numberOf4--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("five"))
        {
            timesHit5++;
            if (maxHit5 == timesHit5)
            {
                numberOf5--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("six"))
        {
            timesHit6++;
            if (maxHit6 == timesHit6)
            {
                numberOf6--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("seven"))
        {
            timesHit7++;
            if (maxHit7 == timesHit7)
            {
                numberOf7--;
                Destroy(collision.gameObject);
            }
        }




        if (numberOf1 == 0)
        {
            oneDestroyed = true;
        }

        if (numberOf2 == 0)
        {
            twoDestroyed = true;
        }

        if (numberOf3 == 0)
        {
            ThreeDestroyed = true;
        }

        if (numberOf4 == 0)
        {
            fourDestroyed = true;
        }

        if (numberOf5 == 0)
        {
            fiveDestroyed = true;
        }

        if (numberOf6 == 0)
        {
            sixDestroyed = true;
        }

        if (numberOf7 == 0)
        {
            sevenDestroyed = true;
        }
    }
    IEnumerator timerbottomcolidedlevel_1()
    {
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    //IEnumerator timerbottomcolidedlevel_2()
    //{
    //    yield return new WaitForSeconds(2);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    //}
    //IEnumerator timerlevelcomplete_1()
    //{
    //    yield return new WaitForSeconds(2);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    //}
    //IEnumerator timerlevelcomplete_2()
    //{
    //    yield return new WaitForSeconds(2);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    //}
   
}
