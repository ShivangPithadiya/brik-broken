using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    public bool oneTime_print = true;
    public static BallManager bm;
   
     int maxHit1 = 1;
     int timesHit1;
     int numberOf1 = 6;
     public bool oneDestroyed = false;
     
     int maxHit2 = 2;
     int timesHit2;
     int numberOf2 = 4;
     public bool twoDestroyed = false;
     
     int maxHit3 = 3;
     int timesHit3;
     int numberOf3 = 5;
     public bool ThreeDestroyed = false;
     
     int maxHit4 = 4;
     int timesHit4;
     int numberOf4 = 3;
     public bool fourDestroyed = false;
     
     int maxHit5 = 5;
     int timesHit5;
     int numberOf5 = 6;
     public bool fiveDestroyed = false;
     
     int maxHit6 = 6;
     int timesHit6;
     int numberOf6 = 5;
     public bool sixDestroyed = false;
     
     int maxHit7 = 2;
     int timesHit7;
     int numberOf7 = 14;
     public bool sevenDestroyed = false;
    // public static GameManager game_manager;
    private Rigidbody2D rb;
    public PaddleManager instance;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        bm = this;
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
        if ( oneDestroyed &&  twoDestroyed &&  ThreeDestroyed &&  fourDestroyed &&  fiveDestroyed &&  sixDestroyed &&  sevenDestroyed && oneTime_print)
        {
          
            Debug.Log("levelComplete");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            oneTime_print = false;
            //oneDestroyed = false;
        }





    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("one"))
        {
             timesHit1++;
             Destroy(collision.gameObject);
            numberOf1--;
            if (maxHit1 == timesHit1)
            {
                
                
            }
        }
        if (collision.gameObject.CompareTag("two"))
        {
             timesHit2++;
            Destroy(collision.gameObject);
            numberOf2--;
            if (maxHit2 == timesHit2)
            {
                
                
            }
        }
        if (collision.gameObject.CompareTag("three"))
        {
             timesHit3++;
            Destroy(collision.gameObject);
            numberOf3--;
            if (maxHit3 == timesHit3)
            {
                
               
            }
        }
        if (collision.gameObject.CompareTag("four"))
        {
             timesHit4++;
            Destroy(collision.gameObject);
            numberOf4--;

            if (maxHit4 == timesHit4)
            {
                
            }
        }
        if (collision.gameObject.CompareTag("five"))
        {
             timesHit5++;
            Destroy(collision.gameObject);
            numberOf5--;

            if (maxHit5 == timesHit5)
            {
                
            }
        }
        if (collision.gameObject.CompareTag("six"))
        {
             timesHit6++;
            Destroy(collision.gameObject);
            numberOf6--;

            if (maxHit6 == timesHit6)
            {
                
            }
        }
        if (collision.gameObject.CompareTag("seven"))
        {
             timesHit7++;
            Destroy(collision.gameObject);
            numberOf7--;

            if (maxHit7 == timesHit7)
            {
               
            }
        }




        if( numberOf1 == 0)
        {
             oneDestroyed = true;
        }

        if ( numberOf2 == 0)
        {
             twoDestroyed = true;
        }

        if ( numberOf3 == 0)
        {
             ThreeDestroyed = true;
        }

        if ( numberOf4 == 0)
        {
             fourDestroyed = true;
        }

        if ( numberOf5 == 0)
        {
             fiveDestroyed = true;
        }

        if ( numberOf6 == 0)
        {
             sixDestroyed = true;
        }

        if ( numberOf7 == 0)
        {
             sevenDestroyed = true;
        }
    }
    
   
}
