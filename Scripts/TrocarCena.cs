using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
   public string nomeDaCena;

   public void CenaJogo()
   {
       SceneManager.LoadScene(nomeDaCena);
   }

   public void SairApp()
   {
       Application.Quit();
   }
}
