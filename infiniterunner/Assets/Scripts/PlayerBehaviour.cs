using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //67
    //672
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private int JumpForce;

    private Rigidbody2D rigidbody;

    private float moveX;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if(Input.GetButtonDown("Jump"))
        {
            JumpPlayer();
        }
    }

    //67
    private void MovePlayer()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        
        transform.Translate(moveX, 0,0);
    }

    private void JumpPlayer()
    {
        rigidbody.linearVelocityY = JumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.LogWarning("COLIDIU! O objeto foi " + collision.collider.gameObject.name);

        if(collision.collider.gameObject.name == "Obstacle")
        {
            Debug.LogError("COLIDI COM OBSTÁCULO");
            Destroy(this.gameObject);
        }
        
    }
}
