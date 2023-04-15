using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
	public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position=new Vector3(0,5,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
