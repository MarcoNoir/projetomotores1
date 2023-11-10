using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, msgvitoria;
    public int restantes;


    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Akumas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor){
        restantes -= valor;
         hud.text = $"Akumas restantes: {restantes}";
         
        if(restantes <= 0 ){
            //ganhou o jogo
            msgvitoria.text = "Parabéns! Isso é miraculoso! Zerou!!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
