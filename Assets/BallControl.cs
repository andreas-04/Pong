using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void GoBall(){
        float rand = Random.Range(0, 2);
        if(rand < 1){
            rb2d.AddForce(new Vector2(500, -105));
        } else {
            rb2d.AddForce(new Vector2(-500, -105));
        }
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }
    void ResetBall(){
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
