using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// les différents sorts pour abattre des ennemis
// l'invocation peut être effectuer à condition d'avoir 9 pylone

public class Sort : MonoBehaviour
{
    public Canvas Sort1Button;
    public TextMeshPro Bleu;

    public int SortBleu = 20;

    public Canvas Sort2Button;
    public TextMeshPro Rouge;
    public int SortRouge = 50

    public Canvas Sort3Button;
    public TextMeshPro Invocation;
    public int SortInvocation = 500 000
}
