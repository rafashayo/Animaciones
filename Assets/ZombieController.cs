using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
 	anim.SetBool("IsWalking", false);       
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKeyDown(KeyCode.W))
	{
		anim.SetBool("IsWalking", false);
	}
	if(Input.GetKeyUp(KeyCode.W))
	{
		anim.SetBool("IsWalking", true);
	}   
    }
}
