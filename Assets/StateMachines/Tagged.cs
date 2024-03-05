using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSMC.Runtime;
using System;

[Serializable]
public class Tagged : FSMC_Behaviour
{
    private GameObject m_go;
    public override void StateInit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go = executer.gameObject;
    }
    public override void OnStateEnter(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
        m_go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    public override void OnStateUpdate(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
    
    }

    public override void OnStateExit(FSMC_Controller stateMachine, FSMC_Executer executer)
    {
    
    }
}