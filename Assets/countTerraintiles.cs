using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countTerraintiles : MonoBehaviour
{

    public Transform buildingContainer;
    public TMPro.TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = buildingContainer.childCount.ToString();
    }
}
