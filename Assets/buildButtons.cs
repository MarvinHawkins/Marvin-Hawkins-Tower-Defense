yuusing UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class buildButtons : MonoBehaviour {

    public buildSpot openSpot;
    public GameObject[] towers; //This is an array of the tower types  that the player has available

    [SerializeField]  GameObject buttonPrefab;

    // Use this for initialization
    void Start () {

        openSpot = GetComponentInParent<buildSpot>();
	}

    

    // Update is called once per frame
    void Update () {
	
	}
}
