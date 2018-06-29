using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitplayer : MonoBehaviour {
    public int AttackDamage;
    void OnTriggerStay(Collider other)
    {
        HUD_Manager hudmanager = other.gameObject.GetComponent<HUD_Manager>();
        if(hudmanager != null)
        {
            hudmanager.UpdateHealth(AttackDamage);
        }


    }







}
