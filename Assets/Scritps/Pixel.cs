using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel : MonoBehaviour {

    private string color { get; set; }
    private int dimension { get; set; }
    public GameObject pixelU;
    private Vector3 vector;
    private float posX;
    private float posy;
    private float posz; 

    // Use this for initialization
    void Start () {

        float posX = pixelU.transform.position.x;
        float posy = pixelU.transform.position.y;
        float posz = pixelU.transform.position.z;

        Vector3 vector = new Vector3(posX, posy, posz);
    }
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 15.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

        pixelU.transform.Translate(x, y, 0);
    }
}
