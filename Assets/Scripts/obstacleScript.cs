using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{

    public Vector3 direction;
    [Range(0f, 50f)] public float speed;
    [SerializeField] Vector3 startDestroy;

    void Start()
    {
        setShape();
    }
    void Update()
    {
        movement();
        destroyMe();
    }


    void setShape()
    {
        float rand = Random.Range(5f, 20f);
        transform.localScale = new Vector3(3.8f, 3, rand);
    }


    void movement()
    {
        transform.Translate(direction * Time.deltaTime * speed);

    }

    void destroyMe()
    {
        if(transform.position.z< startDestroy.z)
            Destroy(this.gameObject);
    }

}
