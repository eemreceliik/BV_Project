using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{

    [SerializeField] private Camera cam;
    [SerializeField] private Color color;
    [SerializeField] private Color color2;
    [SerializeField] private LayerMask layerMask;
    public GameObject cube;
    private bool isPainted = false;


    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask) && isPainted == false)   
        {
            if (hit.collider != null)
            {
                Debug.Log("boyandý");
                isPainted = true;
                hit.collider.gameObject.GetComponent<MeshRenderer>().materials[0].color = color;
            }


        }
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask) == false && isPainted == true)  
        {
            Debug.Log("boyandýktan sonrasý");
            isPainted=false;
            cube.GetComponent<MeshRenderer>().materials[0].color = color2;
        }


    }
}
