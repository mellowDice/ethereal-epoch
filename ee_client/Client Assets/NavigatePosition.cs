﻿using UnityEngine;
using System.Collections;

public class NavigatePosition : MonoBehaviour {
  
  private NavMeshAgent agent;

	void Start () {
    agent = GetComponent<NavMeshAgent>();
	}

  public void NavigateTo (Vector3 position) {
    agent.SetDestination(position);
  }
}
