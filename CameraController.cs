using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
public GameObject Player1;
public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
		offset = transform.position - Player1.transform.position;//sticks camera to the payer or user
    }

    // Update is called once per frame
    void LateUpdate()  //runs just like update but is guranteed to run after all items have processed in update
    {
		transform.position = Player1.transform.position + offset;//sticks camera to the payer or user
    }
}
