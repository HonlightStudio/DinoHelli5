using UnityEngine;

public class spawner : MonoBehaviour
{
    public float speed;
    public GameObject prefab;
    
    float timer = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= speed)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
