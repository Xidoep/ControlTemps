using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XS_Utils;

//[CreateAssetMenu(menuName = "Xido Studio/ControlTemps", fileName = "ControlTemps")]
public static class ControlTemps
{
    /*public static ControlTemps Instance;

    [HideInInspector] public GameObject prefab;
    public static GameObject Prefab
    {
        get
        {
            return ControlTemps.Instance.prefab;
        }
    }*/


    /*private void Awake()
    {
        Instance = this;
    }
    private void OnEnable()
    {
        Instance = this;
    }*/
    
    static float objectiu;
    static float velocitat;
    public static void Temps(float _objectiu, float _velocitat)
    {
        objectiu = _objectiu;
        velocitat = _velocitat;

        XS_Coroutine.StartCoroutine(ProperAObjectiu, CanviarTemps);
        /*CrearGestor(objectiu);
        if (ControlTemps_Gestor.Instance == null)
            return;

        ControlTemps_Gestor.Instance.Temps(objectiu, velocitat);*/
    }
    static float Distancia => Mathf.Clamp01(Mathf.Abs(objectiu - Time.timeScale));
    static bool ProperAObjectiu() => Distancia < 0.02f;
    static void CanviarTemps() 
    {
        if (!ProperAObjectiu())
            Time.timeScale += Time.unscaledDeltaTime * (objectiu > Time.timeScale ? 1 : -1) * Distancia * velocitat;
        else Time.timeScale = objectiu;
    } 
    public static void Temps(float objectiu)
    {
        Time.timeScale = objectiu;
        /*CrearGestor(objectiu);
        if (ControlTemps_Gestor.Instance == null)
            return;

        ControlTemps_Gestor.Instance.Temps(objectiu);*/
    }
    public static void Pausar()
    {
        Time.timeScale = 0;
    }
    public static void Pausar(float tempsPausat)
    {
        Time.timeScale = 0;
        XS_Coroutine.StartCoroutine(tempsPausat, TimeScaleEqualsOne);
        /*CrearGestor(-1);
        if (ControlTemps_Gestor.Instance == null)
            return;

        ControlTemps_Gestor.Instance.Pausar(temps);*/
    }
    static void TimeScaleEqualsOne() => Time.timeScale = 1;
    /*static void CrearGestor(float objectiu)
    {
        if (objectiu == Time.timeScale)
            return;

        if(ControlTemps_Gestor.Instance == null)
        {
            Instantiate(Prefab).GetComponent<ControlTemps_Gestor>();
        }
    }

    
    static void CanviarTemps(float objectiu, float velocitat)
    {
        distancia = Mathf.Clamp01(Mathf.Abs(objectiu - Time.timeScale));
        if (distancia > 0.02f)
        {
            Time.timeScale += Time.unscaledDeltaTime * (objectiu > Time.timeScale ? 1 : -1) * distancia * velocitat;
        }
    }
    static void CanviarTemps(float objectiu)
    {
        Time.timeScale = objectiu;
    }*/
}
