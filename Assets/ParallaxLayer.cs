using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public Vector3 startPosition;
    public float resetPosition;
    public float rate;

    public Transform[] tiles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Parallax.speed * rate * Time.deltaTime;
            if (tiles[i].position.x <= resetPosition)
            {
                tiles[i].position = startPosition;
            }
        }
    }
}
