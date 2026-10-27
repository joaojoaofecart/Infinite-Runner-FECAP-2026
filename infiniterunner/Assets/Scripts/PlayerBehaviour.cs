using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //67
    //672
    [SerializeField] private float moveSpeed = 5;

    private float moveX;
    private float moveY;

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(moveX, moveY, 0);
    }
}
