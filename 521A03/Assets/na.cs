﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class na : MonoBehaviour {

    private NavMeshAgent aget;
    public Transform target;
    // Use this for initialization
    void Start () {
        aget = gameObject.GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        aget.SetDestination(target.position);
    }
}
