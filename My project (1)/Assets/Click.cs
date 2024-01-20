using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Click : MonoBehaviour
    {

        public Canvas Button;
        public TextMeshPro text;
        public int score;


        public Canvas StoneButton;
        public TextMeshPro Stone;
        public int ManaStone;


        public Canvas CristalButton;
        public TextMeshPro Cristal;
        public int CristalMana;


        public Canvas PylonButton;
        public TextMeshPro TextPylon;
        public int Pylon;

        

    

        public void clic()
        {
            score++;
            text.text = "Mana : " + score.ToString();
        }
    

        public void mana()
        {
            ManaStone++;
            Stone.text = "Pierre de Mana " + ManaStone.ToString();
    
        }
    
        public void cristal()
        {
            CristalMana++;
            Cristal.text = "Cristal de Mana " + CristalMana.ToString();
        }
    
        public void Pylone()
        {
            Pylon++;
            TextPylon.text = "Pylone " + Pylon.ToString();
    
        }
    
        
    }   
