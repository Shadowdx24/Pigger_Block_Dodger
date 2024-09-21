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
        //if (Input.GetMouseButton(0))
        //{
        //    Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //    if (touchPos.x < 1)
        //    {
        //        playerRb.AddForce(Vector2.left * speed);
        //    }
        //    else if (touchPos.x > 1)    
        //    {
        //        playerRb.AddForce(Vector2.right * speed);
        //    }
        //}
        //else
        //{
        //    playerRb.velocity = Vector2.zero;
        //}
        MoveOnTouch();

    }

    private void MoveOnTouch()
    {
        if (Input.touchCount > 0)
        {
            Vector2 pos = Input.GetTouch(0).position;
            float middle = Screen.width / 2;

            if (pos.x < middle)
            {
                MoveLeft = true;
            }
            else if (pos.x > middle)
            {
                MoveRight = true;
            }
        }
        else
        {
            MoveLeft = false;
            MoveRight = false;
        }
    }
}
