using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Mouvement : MonoBehaviour {

    // Use this for initialization
    public float m_Speed;
    public bool m_CanJump;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.eulerAngles += new Vector3(Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), 0);

        transform.position += Vector3.right * Input.GetAxisRaw("Horizontal") * m_Speed * Time.deltaTime;
        transform.position += Vector3.forward * Input.GetAxisRaw("Vertical") * m_Speed * Time.deltaTime;
    }
}
