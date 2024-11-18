using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SenhaManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject Senha;
    public GameObject diario;
    public Button submitButton;
    public TextMeshProUGUI errou;

    private string senhaCorreta = "8645"; 

    void Start()
    { 
        submitButton.onClick.AddListener(VerificarSenha);
        diario.SetActive(false);
        Senha.SetActive(true);
    }

    void VerificarSenha()
    {
        
        string senhaDigitada = inputField.text;

        
        if (senhaDigitada == senhaCorreta)
        {
            diario.SetActive(true);
            Senha.SetActive(false);
        }
        else
        {
            errou.text = "Senha incorreta";
        }

        inputField.text = "";
    }
}
