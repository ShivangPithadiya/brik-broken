using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    public Camera mainCamara;
   
    void Update()
    {
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        Vector3 mouseTowardsWorld = mainCamara.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosBlock =mouseTowardsWorld;
        paddlePos.x = mousePosBlock.x;
        paddlePos.x = Mathf.Clamp(mousePosBlock.x, -10.40f, 10.40f);
        this.transform.position = paddlePos;
    }
   
}
