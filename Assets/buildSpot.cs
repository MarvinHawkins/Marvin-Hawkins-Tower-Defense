using UnityEngine;
using System.Collections;

public class buildSpot : MonoBehaviour {

    public GameObject buildPanel; //t he build pqanel
    public GameObject buildPrefab;
    public GameObject[] towers; //This is an array of the tower types  that the player has available


    // Use this for initialization
    void Start () {
        buildPanel = Instantiate(buildPrefab) as GameObject;
        buildPanel.SetActive(false);

    }

    void OnMouseUp()
    {
        buildPanel.SetActive(true);
    }

    public void buildTower(int building)
    {
        Instantiate(towers[building], transform.position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update () {

	
	}
}
