using UnityEngine;
using TMPro;

public class UIScore : MonoBehaviour
{

    private TextMeshProUGUI textMeshProUGUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = GameManager.instance.score.ToString();
    }
}
