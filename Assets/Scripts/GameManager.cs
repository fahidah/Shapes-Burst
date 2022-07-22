using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> shapes;
    private float spawnRate = 0.5f; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnShapes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnShapes()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, shapes.Count);
            Instantiate(shapes[index]);
        }
    }
}
