using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff) //timeDiff초마다 파이프가 생성
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(-4, Random.Range(-4f, 3f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }

    }
}
