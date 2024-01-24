using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Click : MonoBehaviour
{

    public Canvas Button;
    public TextMeshProUGUI text;
    public int score;


    public Canvas StoneButton;
    public TextMeshProUGUI Stone;
    public int ManaStone;
    public bool ManaStone2 = false;
        


    public Canvas CristalButton;
    public TextMeshProUGUI Cristal;
    public int CristalMana;
    public bool Cristal2 = false;


    public Canvas PylonButton;
    public TextMeshProUGUI TextPylon;
    public int Pylon;

    

    

    public void clic()
    {
        score++;
        text.text = "Mana : " + score.ToString();
        
    }


    public void ManaCheck()
    {
        if (score >= 10)
        {
            
            ManaStone2 = true;
            ManaStone++;
            Stone.text = "Pierre de Mana " + ManaStone.ToString();
            score = score - 10*ManaStone;
            StartCoroutine(AutoClickScore());
            
        }
    }

    


    public IEnumerator AutoClickScore()
    {
        while(ManaStone > 0)
        { 
            clic();
            yield return new WaitForSecondsRealtime(1);
        }
    }
    


    public void cristalcheck() {

        if (score > 100 && ManaStone > 10)
        {
            Cristal2 = true;
            CristalMana++;
            Cristal.text = "Cristal de Mana " + CristalMana.ToString();
            score = score - 100;
            StartCoroutine(AutoClickMana());
        }
    }

    public IEnumerator AutoClickMana()
    {
       
        while(CristalMana > 0)
        {
            ManaCheck();
            yield return new WaitForSecondsRealtime(1);
        }
        
    }
    
    public void Pylone()
    {
        Pylon++;
        TextPylon.text = "Pylone " + Pylon.ToString();
    
    }
    
        
}   
