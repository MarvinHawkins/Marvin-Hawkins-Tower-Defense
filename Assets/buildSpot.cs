using UnityEngine;
using System.Collections;

public class buildSpot : MonoBehaviour {

    public GameObject buildPanel; //t he build pqanel
    public GameObject buildPrefab;


    // Use this for initialization
    void Start () {
        buildPanel = Instantiate(buildPrefab) as GameObject;
        buildPanel.SetActive(false);

    }

    void OnMouseUp()
    {
        buildPanel.SetActive(true);
    }


    // Update is called once per frame
    void Update () {

	
	}
}
