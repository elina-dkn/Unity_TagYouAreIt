using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSMC.Runtime;
using System;

[Serializable]
public class RunToward : FSMC_Behaviour
{
    private GameObject m_go;
    private GameObject m_player;
    private float m_distance;
    private float m_speed;
    public override void StateInit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_speed = stateMachine.GetFloat("NPC_Speed");
        m_go = executer.gameObject;
        m_player = UnityEngine.GameObject.FindWithTag("Player");
    }
    public override void OnStateEnter(FSMC_Controller stateMachine, FSMC_Executer executer)
    {

        m_go.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
    }

    public override void OnStateUpdate(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go.transform.position += (m_player.transform.position - m_go.transform.position).normalized * m_speed * Time.deltaTime;
        m_go.transform.LookAt(m_player.transform.position);
        m_distance = Vector3.Distance(m_player.transform.position, m_go.transform.position);
        stateMachine.SetFloat("Distance", m_distance);
        stateMachine.SetBool("I_Down", Input.GetKeyDown(KeyCode.I));
    }

    public override void OnStateExit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {

    }
}