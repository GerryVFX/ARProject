using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SceneM : MonoBehaviour
{
    public TMP_InputField capturaNombre;
    public TMP_Text usuario;
    public Slider controlMusica;
    public AudioSource audioFuente;

    public string nombre;
    private void Start()
    {
        capturaNombre = FindObjectOfType<TMP_InputField>();
        usuario = FindObjectOfType<TMP_Text>();
    }

    private void Update()
    {
        audioFuente.volume = controlMusica.value;
    }

    public void ChangeScene()
    {
        //SceneManager.LoadScene(1);
        nombre = capturaNombre.text;
        usuario.text = nombre;
    }
}
