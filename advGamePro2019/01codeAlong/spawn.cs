using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public GameObject block;

	void Start ()
    {
        Do();
    }

    public List<GameObject> allBlocks = new List<GameObject>();

	void Do ()
    {
        float vert = Random.Range(-4.0f, 4.0f);
        for(int i = 0; i < 20; i++)
        {
            if ((i - 10) == 0 || (i - 10) == 1)
            {
                continue;
            }
            allBlocks.Add(Instantiate(block, new Vector2(15, vert + (i - 10)), Quaternion.identity));
        }

        if(allBlocks.Count > 60)
        {
            for(int i = 17; i > -1; i--)
            {
                Destroy(allBlocks[i]);
            }
            for (int i = 17; i > -1; i--)
            {
                allBlocks.RemoveAt(i);
            }
        }

        Invoke("Do", Random.Range(5, 10));
	}
}
