using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Text Tgr;

void Start()
    {
        Tgr.text = "Aga ilah de�iliz silah de�iliz b�y�tmeyin bu kadar";
    }

    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "Trigger1")
        {
            Tgr.text = "Abi de�ilsin ama ta��akl� adams�n yani";
        }
        if (this.gameObject.tag == "Trigger2")
        {
            Tgr.text = "K�b� b�rak";
        }

    }
}
