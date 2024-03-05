using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSMC.Runtime;
using System;

[Serializable]
public class Idle : FSMC_Behaviour
{
    private GameObject m_go;
    private GameObject m_player;
    private float m_distance;
    public override void StateInit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go = executer.gameObject;
        m_player = UnityEngine.GameObject.FindWithTag("Player");
        m_distance = Vector3.Distance(m_player.transform.position, m_go.transform.position);
        
    }
    public override void OnStateEnter(FSMC_Controller stateMachine, FSMC_Executer executer)
    {

        m_go.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    public override void OnStateUpdate(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go.transform.LookAt(m_player.transform.position);
        m_distance = Vector3.Distance(m_player.transform.position, m_go.transform.position);

        Vector3 pos = m_go.transform.position;
        pos.y = 0.6f;
        m_go.transform.position = pos;
        stateMachine.SetBool("I_Down", Input.GetKeyDown(KeyCode.I));
        stateMachine.SetFloat("Distance", m_distance);
        
    }

    public override void OnStateExit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
    
    }
}