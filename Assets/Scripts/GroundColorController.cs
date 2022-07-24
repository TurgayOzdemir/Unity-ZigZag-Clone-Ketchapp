using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;


    private int _colorIndex = 0;
    private float _currentTime;

    private void Update()
    {
        setColorChangeTime();
        setGroundMaterialSmoothColorChange();
    }

    private void setColorChangeTime()
    {
        if (_currentTime <= 0)
        {
            checkColorIndexValue();
            _currentTime = time;
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }

    private void checkColorIndexValue()
    {
        _colorIndex++;

        if (_colorIndex >= colors.Length)
        {
            _colorIndex = 0;
        }
    }

    private void setGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[_colorIndex], lerpValue * Time.deltaTime);
    }
    private void OnDestroy()
    {
        groundMaterial.color = colors[0];
    }
}
