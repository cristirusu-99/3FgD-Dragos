using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Vector3 zoom;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zoom = Camera.main.transform.position - GameObject.Find("Cactus").transform.position; 
        if (zoom.y <= 0.2 && zoom.z >= -0.2)
            animator.Play("Attack");
    }
}
