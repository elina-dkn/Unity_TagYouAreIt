using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject m_npc;
    [SerializeField]
    private GameObject m_player;

    // Start is called before the first frame update
    void Start()
    {
        m_npc.SetActive(true);
        for (int i = 0; i < 9; i++)
        {
            Vector3 player_pos = m_player.transform.position;
            float randomAngle = Random.Range(0f, 360f);

            
            float randomDistance = Random.Range(2f, 10f);

           
            float spawnX = player_pos.x + randomDistance * Mathf.Cos(randomAngle * Mathf.Deg2Rad);
            float spawnZ = player_pos.z + randomDistance * Mathf.Sin(randomAngle * Mathf.Deg2Rad);

            
            Vector3 spawnPosition = new Vector3(spawnX, 0f, spawnZ);
            m_npc.transform.position = spawnPosition;
            Instantiate(m_npc);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
