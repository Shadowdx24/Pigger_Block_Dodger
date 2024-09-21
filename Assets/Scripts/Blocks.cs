using UnityEngine;

public class Blocks : MonoBehaviour
{
     void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }        
    }
}
