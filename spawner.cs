using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    public float minx;
    public float maxX;
    public float interval;
    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    private void spawn()
    {
        GameObject newPlat = Instantiate(prefab);
        newPlat.transform.position = new Vector2(
            Random.Range(minx, maxX), transform.position.y + (Random.Range(0.5f, 1f)));
    }
}
