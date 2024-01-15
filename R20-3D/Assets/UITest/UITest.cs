using UnityEngine;
using UnityEngine.UIElements;
using System;
using System.Collections;

public class UITest : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    [SerializeField] private StyleSheet _styleSheet;

    public static event Action<float> ScaleChanged;
    public static event Action SpinClicked;

    private void Start() 
    {
        StartCoroutine(Generate());
    }

    private void OnValidate() 
    {
        if(Application.isPlaying)return;
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        yield return null;
        var root = _uiDocument.rootVisualElement;//找到UIDocument所有UI元素
        root.Clear();
        root.styleSheets.Add(_styleSheet);//找到樣式模板

        var container = Create("container");

        var viewBox = Create("view-box", "border-box");
        container.Add(viewBox);

        var controlBox = Create("control-box", "border-box");

        var spinBtn = Create<Button>();
        spinBtn.text = "Spin";
        spinBtn.clicked += SpinClicked;
        controlBox.Add(spinBtn);

        var scaleSlider = Create<Slider>();
        scaleSlider.lowValue = 0.5f;
        scaleSlider.highValue = 2f;
        scaleSlider.value = 1f;
        scaleSlider.RegisterValueChangedCallback(v => ScaleChanged?.Invoke(v.newValue));
        controlBox.Add(scaleSlider);

        container.Add(controlBox);

        root.Add(container);
    }

    VisualElement Create(params string[] names)
    {
        return Create<VisualElement>(names);
    }

    T Create<T>(params string[] names)where T : VisualElement, new()
    {
        var ele = new T();
        foreach(var name in names)
        {
            ele.AddToClassList(name);
        }
        return ele;
    }
}

// var titleLabel = new Label("SEX");//創建UILable
// root.Add(titleLabel);//將UILabel加入root

// var redBox = new VisualElement();
// redBox.AddToClassList("redBox");
// root.Add(redBox);

// var blueBox = new VisualElement();
// blueBox.AddToClassList("blueBox");
// root.Add(blueBox);
