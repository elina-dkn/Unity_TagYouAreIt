using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject m_go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horIn = Input.GetAxis("Horizontal");
        float verIn = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horIn, 0.6f, verIn);
        m_go.transform.Translate(dir*20f*Time.deltaTime);
        Vector3 pos = m_go.transform.position;
        pos.y = 0.6f;
        m_go.transform.position = pos;
    }
}
