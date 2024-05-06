using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JKConstrainY : MonoBehaviour
{
    private Vector3 m_spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, m_spawnPos.y, transform.position.z);
    }
}
