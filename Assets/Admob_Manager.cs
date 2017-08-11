using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class Admob_Manager : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Banner_Click()    
    {

        FindObjectOfType<Ad_Manager>().Show_Banner_top();

    }
    public void Gecis_Click()
    {
        FindObjectOfType<Ad_Manager>().Show_Video();
    }

    }
