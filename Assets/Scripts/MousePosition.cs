using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{

    [SerializeField] private Camera mainCamera; 

    public GameObject Cylinder;
    public GameObject Seed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Seed, raycastHit.point, Seed.transform.rotation);
        }
    }
}
