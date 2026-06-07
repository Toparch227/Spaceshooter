using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{   
    private TextMeshProUGUI textMesh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver == true && textMesh.enabled == false)
        {
            textMesh.enabled = true;
        }
    }
}
