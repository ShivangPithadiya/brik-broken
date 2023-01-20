using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHit : MonoBehaviour
{
   public static OneHit one;
  
    static int maxHit = 1;
    static int timesHit;
    // Start is called before the first frame update
    void Start()
    {
        one = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            timesHit++;

        }
        if (timesHit == maxHit)
        {
          
            Destroy(gameObject);
        }
    }
}
