using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private float maxX;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnRate;
    private bool gameStated = false;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStated)
        {
            StartSpawning();

            gameStated = true;

            tapText.SetActive(false);
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
        score++;
        scoreText.text = " " + score;
    }

   
}
