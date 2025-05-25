using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnSpawnerS : MonoBehaviour
{
    public GameObject columnPrefeb;
    public float minY, maxY;

    float timer;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        spawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxTime )
        {
            spawnColumn();
            timer = 0;
        }
    }

    void spawnColumn()
    {
        float randYpos = Random.Range( minY, maxY );

        GameObject newColumn = Instantiate(columnPrefeb);
        newColumn.transform.position = new Vector2(transform.position.x, randYpos);
    }
}
