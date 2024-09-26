using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private float maxX;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnRate;

    private bool gameStated =false;

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX,maxX);
        Instantiate(block, spawnPos, Quaternion.identity);
    }
}
