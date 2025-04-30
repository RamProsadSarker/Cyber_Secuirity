using UnityEngine;
using UnityEngine.UI;

public class Click_Counter : MonoBehaviour
{
    private Text chantText;
    private Button chantButton;
    private int count = 0;

    void Start()
    {

        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.white;
        // Create Canvas
        GameObject canvasGO = new GameObject("Canvas");
        Canvas canvas = canvasGO.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();
     //Camera.main.backgroundColor = Color.gray;

        // Create Button
        GameObject buttonGO = new GameObject("ChantButton");
        buttonGO.transform.SetParent(canvasGO.transform);
        chantButton = buttonGO.AddComponent<Button>();
        Image buttonImage = buttonGO.AddComponent<Image>();
        buttonImage.color = Color.cyan;

        // Set Button Position and Size
        RectTransform buttonRect = buttonGO.GetComponent<RectTransform>();
        buttonRect.sizeDelta = new Vector2(160, 30);
        buttonRect.anchoredPosition = new Vector2(0, 0);

        // Create Button Text
        GameObject buttonTextGO = new GameObject("ButtonText");
        buttonTextGO.transform.SetParent(buttonGO.transform);
        Text buttonText = buttonTextGO.AddComponent<Text>();
        buttonText.text = "Click";
        buttonText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        buttonText.alignment = TextAnchor.MiddleCenter;
        buttonText.color = Color.black;

        RectTransform buttonTextRect = buttonTextGO.GetComponent<RectTransform>();
        buttonTextRect.sizeDelta = buttonRect.sizeDelta;
        buttonTextRect.anchoredPosition = Vector2.zero;

        // Create Chant Text
        GameObject chantTextGO = new GameObject("ChantText");
        chantTextGO.transform.SetParent(canvasGO.transform);
        chantText = chantTextGO.AddComponent<Text>();
        chantText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        chantText.alignment = TextAnchor.UpperCenter;
        chantText.color = Color.black;

        RectTransform chantTextRect = chantTextGO.GetComponent<RectTransform>();
        chantTextRect.sizeDelta = new Vector2(200, 30);
        chantTextRect.anchoredPosition = new Vector2(0, 50);

        // Add Button Click Listener
        chantButton.onClick.AddListener(Chant);

        UpdateText();
    }

    void Chant()
    {
        count++;
        UpdateText();
        Debug.Log("Welcome to my 1st unity project");
    }

    void UpdateText()
    {
        chantText.text = "Counts: " + count.ToString();
    }
}
