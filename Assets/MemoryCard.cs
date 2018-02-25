using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour {

	[SerializeField] private GameObject cardBack;

	// Use this for initialization
	void Start () {
		
	}

	public void OnMouseDown() 
	{
		if (cardBack.activeSelf) {
			cardBack.SetActive(false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}


}
