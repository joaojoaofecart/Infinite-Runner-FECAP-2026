using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float moveX;
    private float moveY;

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(moveX, moveY, 0);
    }
}
