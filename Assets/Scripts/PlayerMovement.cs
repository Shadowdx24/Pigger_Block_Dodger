using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Rigidbody2D playerRb;
    private bool MoveLeft;
    private bool MoveRight;

    // Start is called before the first frame update
    void Start()
    {
        playerRb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Input.mousePosition;

            if (touchPos.x < 1)
            {
                playerRb.AddForce(Vector2.left * speed);
            }
            else if (touchPos.x > 1)
            {
                playerRb.AddForce(Vector2.right * speed);
            }
        }
        else
        {
            playerRb.velocity = Vector2.zero;
        }
    }
}
