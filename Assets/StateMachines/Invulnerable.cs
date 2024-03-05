using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSMC.Runtime;
using System;

[Serializable]
public class Invulnerable : FSMC_Behaviour
{
    private GameObject m_go;
    private GameObject m_player;
    private float m_distance;
    private float m_time = 300f;
    public override void StateInit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go = executer.gameObject;
        m_player = UnityEngine.GameObject.FindWithTag("Player");
        m_time = 3f;
    }
    public override void OnStateEnter(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_time = 3f;
        m_go.GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
    }

    public override void OnStateUpdate(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        if(m_time > 0)
        {
            m_time -= Time.deltaTime;
        }
        else
        {
            stateMachine.SetBool("I_Down", Input.GetKeyDown(KeyCode.I));
            m_distance = Vector3.Distance(m_player.transform.position, m_go.transform.position);
            stateMachine.SetFloat("Distance", m_distance);
        }

        
        
    }

    public override void OnStateExit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
       // m_time = 3f;
    }
}