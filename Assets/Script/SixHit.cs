using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixHit : MonoBehaviour
{
    static int maxhit = 6;
    static int timesHit;
    // Start is called before the first frame update
    void Start()
    {

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
        if (timesHit == maxhit)
        {
            Destroy(gameObject);
        }
    }
}
