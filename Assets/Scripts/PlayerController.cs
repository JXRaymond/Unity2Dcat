using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Animator anim;
    Rigidbody2D rb;
    public AudioSource[] AudioS;

    float speed, jumpSpeedY;
    bool facingright, canPlay, walking, jumping, grounded, scoreTrack, isAlive;


    public AudioSource walkingsound;
    public AudioSource runningsound;
    public AudioSource deathsound;
    public AudioSource jumpingsound;

    public Transform groundCheck;
    public float radius;
    public LayerMask groundMask;

    private string playerName;
    GameObject userName;
    GameObject victory;
    public AudioClip winSong;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        AudioS = GetComponents<AudioSource>();
        walkingsound = AudioS[0];
        //runningsound = AudioS[1];
        deathsound = AudioS[2];
        jumpingsound = AudioS[3];

        facingright = true;
        walking = false;
        canPlay = true;
        grounded = false;
        isAlive = true;
        jumpSpeedY = 450;
    }

    void Update()
    {
        MovePlayer(speed);
        Flip();

        grounded = Physics2D.OverlapCircle(groundCheck.position, radius, groundMask);


        if (Input.GetKeyDown(KeyCode.LeftArrow) && canPlay == true && isAlive == true)
        {
            if(grounded == true)
            {
                walkingsound.Play();
            }
            
            speed = -6;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && canPlay == true && isAlive == true)
        {
            speed = 0;
            walkingsound.Stop();

        }
       if (Input.GetKeyDown(KeyCode.RightArrow) && canPlay == true && isAlive == true)
        {
            if (grounded == true)
            {
                walkingsound.Play();
            }
            speed = 6;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && canPlay == true && isAlive == true)
        {
            speed = 0;
            walkingsound.Stop();

        }

         if (Input.GetKeyDown(KeyCode.Space) && grounded == true && canPlay == true && isAlive == true)
        {
            jumping = true;
            walkingsound.Stop();
            jumpingsound.Play();
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
            anim.SetInteger("State", 4);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        
        if (scoreTrack == true)
        {
            if (scoreManager.getScore() > PlayerPrefs.GetInt("HiScore10"))
            {
                PlayerPrefs.SetInt("New Score Flag", 1);
                userName.SetActive(true);
                if (Input.GetKey("enter") || Input.GetKeyDown("return"))
                {
                    scoreManager.saveScores(userName.GetComponent<InputField>().text);
                    SceneManager.LoadScene("highscores");
                }
            }
            else
            {
                PlayerPrefs.SetInt("New Score Flag", 0);
                SceneManager.LoadScene("highscores");
            }
        }
    }
    void MovePlayer(float PlayerSpeed)
    {
        if (PlayerSpeed < 0 && !jumping || PlayerSpeed > 0 && !jumping && isAlive == true)
        {
            anim.SetInteger("State", 1);
        }
        if (PlayerSpeed == 0 && !jumping && isAlive == true)
        {
            anim.SetInteger("State", 0);
        }
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }
    void Flip()
    {
        if (speed > 0 && !facingright || speed < 0 && facingright)
        {
            facingright = !facingright;

            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "enemy" && isAlive == true)
        {
            isAlive = false;
            StartCoroutine("wait");
        }
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "brick" && isAlive == true)
        {
            jumping = false;
            anim.SetInteger("State", 0);
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "brick" && isAlive == true)
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "fallDeath" && isAlive == true)
        {
            //isAlive = false;
            transform.position = new Vector3(-7.1f, 4.2f, 0);
            livesManager.lostLife();
           // isAlive = true;
        }
        if(other.gameObject.tag == "winGame" && isAlive == true)
        {
            StartCoroutine("win");
        }
    }
    IEnumerator wait()
    {
        canPlay = false;
        speed = 0;
        anim.SetInteger("State", 3);
        walkingsound.Stop();
        deathsound.Play();
        yield return new WaitForSeconds(3.0f);
        transform.position = new Vector3(-7.1f, 4.2f, 0);
        livesManager.lostLife();
        anim.SetInteger("State", 0);
        isAlive = true;
        canPlay = true;
    }
    IEnumerator win()
    {
        canPlay = false;
        anim.SetInteger("State", 0);
        walkingsound.Stop();
        speed = 0;
        victory.SetActive(true);
        AudioSource.PlayClipAtPoint(winSong, transform.position);
        yield return new WaitForSeconds(5.0f);
        scoreTrack = true;
    }

    void Awake()
    {
        userName = GameObject.Find("InputField");
        userName.SetActive(false);
        PlayerPrefs.SetInt("New Score Flag", 0);
        victory = GameObject.Find("Text");
        victory.SetActive(false);
    }

}