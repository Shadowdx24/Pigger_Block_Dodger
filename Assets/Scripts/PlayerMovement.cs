using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private GameObject gameOverObj;
    [SerializeField] private GameObject gamePauseObj;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            Debug.Log("Game Over");
            GameOver();
        }
    }

    private void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0f;
        GameManager.instance.DisplayGameOverScore();
    }

    public void GamePause()
    {
        gamePauseObj.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        gameOverObj.SetActive(false); 
    }
    public void GameResume()
    {
        gamePauseObj.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameHome()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
