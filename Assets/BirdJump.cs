using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float JumpPower;

    // Start is called before the first frame update
    void Start() //최초한번
    {
        rb = GetComponent<Rigidbody2D>(); //컴포넌트 받기
    }

    // Update is called once per frame
    void Update() //매 프레임마다
    {
        if (Input.GetMouseButtonDown(0))//마우스 눌렷을때 
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * JumpPower; //속도값 , (0,3) , 위쪽 방향으로 3만큼 올라간다.
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");

    }
}
