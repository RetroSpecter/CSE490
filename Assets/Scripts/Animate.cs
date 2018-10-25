using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Animate : MonoBehaviour
{
    PostProcessVolume volume;
    ColorGrading colorGrade;
    Vignette vigChange;

    public float duration = 2.0f;

    float startValueofTemp;
    float startValueofVig;
    float startValueofSat;
    public float endValueofTemp;
    public float endValueofVig;
    public float endValueofSat;
    float t = 0;

    // Use this for initialization
	void Start()
	{
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGrade);
        volume.profile.TryGetSettings(out vigChange);
        startValueofTemp = colorGrade.temperature.value;
        startValueofTemp = vigChange.intensity.value;
        startValueofSat = colorGrade.saturation.value;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / (duration);
        colorGrade.temperature.value = Mathf.Lerp(startValueofTemp, endValueofTemp, t);
        vigChange.intensity.value = Mathf.Lerp(startValueofVig, endValueofVig, t);
        colorGrade.saturation.value = Mathf.Lerp(startValueofSat, endValueofSat, t);
        Debug.Log(colorGrade.temperature.value);
        Debug.Log(vigChange.intensity.value);
    }
}
