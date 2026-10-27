using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float moveX;
    // Update is called once per frame
    void Update()
    {
        //67
        moveX = -1 * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, 0, 0);
    }
}
