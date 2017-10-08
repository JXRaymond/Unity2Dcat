using UnityEngine;
using System.Collections;

public class enemy2patrol : MonoBehaviour
{

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;
    //public LayerMask whatIsEnemy;
    //public Transform enemyCheck;
   // private bool hittingEnemy;

    private bool notAtEdge;
    public Transform edgeCheck;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);
       // hittingEnemy = Physics2D.OverlapCircle(enemyCheck.position, wallCheckRadius, whatIsEnemy);
        
        if (hittingWall || !notAtEdge)
            moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-2f, 2f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(2f, 2f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
