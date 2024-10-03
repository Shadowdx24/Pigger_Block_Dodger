using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private float maxX;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnRate;
    [SerializeField] private TextMeshProUGUI gamePlayScoreText;
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    
    private bool gameStated = false;
    private int score = 0;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStated)
        {
            StartSpawning();

            gameStated = true;
        }
        
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", .5f,spawnRate);        
    }

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX,maxX);
        Instantiate(block, spawnPos, Quaternion.identity);
        UpdateScore();
        
    }

    private void UpdateScore()
    {
        score++;

        DisplayGamePlayScore();
    }

    private void DisplayGamePlayScore()
    {
        gamePlayScoreText.text = $"{score}";
    }
    public void DisplayGameOverScore()
    {
        gameOverScoreText.text = $"Score: {score}";
    }
}
