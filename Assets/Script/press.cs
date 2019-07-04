using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class press : MonoBehaviour
{
    public GameObject myObject;
    public int button_sayac ;
    public int button_hakkı;
    public int one_star_steps;
    public int two_star_steps;
    public int three_star_steps;
    public int kucuk_x;
    public int buyuk_x;
    public int kucuk_y;
    public int buyuk_y;
    public int kucuk_z;
    public int buyuk_z;
    public Text sayac_text;
    public List<String> myList = new List<String>();
    public List<String> funcList = new List<String>();
    public GameObject play;
    public GameObject stop;
    public GameObject pauseEkranı;
    public GameObject sonucEkranı;
    public GameObject zero_star;
    public GameObject one_star;
    public GameObject two_star;
    public GameObject three_star;
    public GameObject nextButton;
    public Sprite RightButtonPic;
    public Sprite LeftButtonPic;
    public Sprite UpButtonPic;
    public Sprite DownButtonPic;
    public Sprite FuncButtonPics;
    public Button mainMenu;
    public Sprite mainPic1;
    public Sprite mainPic2;
    public Button funcMenu;
    public Sprite funcPic1;
    public Sprite funcPic2;
    public Button[] buttons ;
    public Button[] funcButtons;
    public GameObject[] buttonsVisibled;
    public GameObject[] funcbuttonsVisibled;
    public int sayac = 0;
   
    public void Start()
    {
        mainMenu.GetComponent<Image>().sprite = mainPic1;
        funcMenu.GetComponent<Image>().sprite = funcPic2;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void IleriDevril()
    {
        if (button_sayac > 0)
        {
            
            if(mainMenu.GetComponent<Image>().sprite == mainPic1)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetComponent<Image>().sprite != RightButtonPic)
                    {
                        if (buttons[i].GetComponent<Image>().sprite != LeftButtonPic)
                        {
                            if (buttons[i].GetComponent<Image>().sprite != DownButtonPic)
                            {
                                if (buttons[i].GetComponent<Image>().sprite != UpButtonPic)
                                {
                                    if(buttons[i].GetComponent<Image>().sprite != FuncButtonPics)
                                    {
                                        buttonsVisibled[i].SetActive(true);
                                        buttons[i].GetComponent<Image>().sprite = UpButtonPic;
                                        myList.Add("İleri");
                                        button_sayac = button_sayac - 1;
                                        sayac_text.text = button_sayac.ToString();
                                        sayac = sayac + 1;
                                        break;
                                    }                                
                                }
                            }
                        }
                    }
                }
            }
            
            
            
        }
        if (funcMenu.GetComponent<Image>().sprite == funcPic1)
        {
            for (int i = 0; i < funcButtons.Length - 1; i++)
            {
                if (funcButtons[i].GetComponent<Image>().sprite != RightButtonPic)
                {
                    if (funcButtons[i].GetComponent<Image>().sprite != LeftButtonPic)
                    {
                        if (funcButtons[i].GetComponent<Image>().sprite != DownButtonPic)
                        {
                            if (funcButtons[i].GetComponent<Image>().sprite != UpButtonPic)
                            {
                                funcbuttonsVisibled[i].SetActive(true);
                                funcButtons[i].GetComponent<Image>().sprite = UpButtonPic;
                                funcList.Add("İleri");

                                break;
                            }
                        }
                    }
                }
            }
        }
    }
    public void AsagiDevril()
    {
        if (button_sayac > 0)
        {
            
            
            if (mainMenu.GetComponent<Image>().sprite == mainPic1)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetComponent<Image>().sprite != RightButtonPic)
                    {
                        if (buttons[i].GetComponent<Image>().sprite != LeftButtonPic)
                        {
                            if (buttons[i].GetComponent<Image>().sprite != DownButtonPic)
                            {
                                if (buttons[i].GetComponent<Image>().sprite != UpButtonPic)
                                {
                                    if (buttons[i].GetComponent<Image>().sprite != FuncButtonPics)
                                    {
                                        buttonsVisibled[i].SetActive(true);
                                        buttons[i].GetComponent<Image>().sprite = DownButtonPic;
                                        myList.Add("Geri");
                                        button_sayac = button_sayac - 1;
                                        sayac_text.text = button_sayac.ToString();
                                        sayac = sayac + 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
           

        }
        if (funcMenu.GetComponent<Image>().sprite == funcPic1)
        {
            for (int i = 0; i < funcButtons.Length - 1; i++)
            {
                if (funcButtons[i].GetComponent<Image>().sprite != RightButtonPic)
                {
                    if (funcButtons[i].GetComponent<Image>().sprite != LeftButtonPic)
                    {
                        if (funcButtons[i].GetComponent<Image>().sprite != DownButtonPic)
                        {
                            if (funcButtons[i].GetComponent<Image>().sprite != UpButtonPic)
                            {
                                funcbuttonsVisibled[i].SetActive(true);
                                funcButtons[i].GetComponent<Image>().sprite = DownButtonPic;
                                funcList.Add("Geri");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
    public void SagaDevril()
    {
        if (button_sayac > 0)
        {
           
            
            if (mainMenu.GetComponent<Image>().sprite == mainPic1)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetComponent<Image>().sprite != RightButtonPic)
                    {
                        if (buttons[i].GetComponent<Image>().sprite != LeftButtonPic)
                        {
                            if (buttons[i].GetComponent<Image>().sprite != DownButtonPic)
                            {
                                if (buttons[i].GetComponent<Image>().sprite != UpButtonPic)
                                {
                                    if (buttons[i].GetComponent<Image>().sprite != FuncButtonPics)
                                    {
                                        buttonsVisibled[i].SetActive(true);
                                        buttons[i].GetComponent<Image>().sprite = RightButtonPic;
                                        myList.Add("Sag");
                                        button_sayac = button_sayac - 1;
                                        sayac_text.text = button_sayac.ToString();
                                        sayac = sayac + 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
         

        }
        if (funcMenu.GetComponent<Image>().sprite == funcPic1)
        {
            for (int i = 0; i < funcButtons.Length - 1; i++)
            {
                if (funcButtons[i].GetComponent<Image>().sprite != RightButtonPic)
                {
                    if (funcButtons[i].GetComponent<Image>().sprite != LeftButtonPic)
                    {
                        if (funcButtons[i].GetComponent<Image>().sprite != DownButtonPic)
                        {
                            if (funcButtons[i].GetComponent<Image>().sprite != UpButtonPic)
                            {
                                funcbuttonsVisibled[i].SetActive(true);
                                funcButtons[i].GetComponent<Image>().sprite = RightButtonPic;
                                funcList.Add("Sag");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
    public void SolaDevril()
    {
        if (button_sayac > 0)
        {
            
            
            if (mainMenu.GetComponent<Image>().sprite == mainPic1)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetComponent<Image>().sprite != RightButtonPic)
                    {
                        if (buttons[i].GetComponent<Image>().sprite != LeftButtonPic)
                        {
                            if (buttons[i].GetComponent<Image>().sprite != DownButtonPic)
                            {
                                if (buttons[i].GetComponent<Image>().sprite != UpButtonPic)
                                {
                                    if (buttons[i].GetComponent<Image>().sprite != FuncButtonPics)
                                    {
                                        buttonsVisibled[i].SetActive(true);
                                        buttons[i].GetComponent<Image>().sprite = LeftButtonPic;
                                        myList.Add("Sol");
                                        button_sayac = button_sayac - 1;
                                        sayac_text.text = button_sayac.ToString();
                                        sayac = sayac + 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            


        }
        if (funcMenu.GetComponent<Image>().sprite == funcPic1)
        {
            for (int i = 0; i < funcButtons.Length - 1; i++)
            {
                if (funcButtons[i].GetComponent<Image>().sprite != RightButtonPic)
                {
                    if (funcButtons[i].GetComponent<Image>().sprite != LeftButtonPic)
                    {
                        if (funcButtons[i].GetComponent<Image>().sprite != DownButtonPic)
                        {
                            if (funcButtons[i].GetComponent<Image>().sprite != UpButtonPic)
                            {
                                funcbuttonsVisibled[i].SetActive(true);
                                funcButtons[i].GetComponent<Image>().sprite = LeftButtonPic;
                                funcList.Add("Sol");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
    public void FunctionButton()
    {
        if (button_sayac > 0)
        {


            if (mainMenu.GetComponent<Image>().sprite == mainPic1)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetComponent<Image>().sprite != RightButtonPic)
                    {
                        if (buttons[i].GetComponent<Image>().sprite != LeftButtonPic)
                        {
                            if (buttons[i].GetComponent<Image>().sprite != DownButtonPic)
                            {
                                if (buttons[i].GetComponent<Image>().sprite != UpButtonPic)
                                {
                                    if (buttons[i].GetComponent<Image>().sprite != FuncButtonPics)
                                    {
                                        buttonsVisibled[i].SetActive(true);
                                        buttons[i].GetComponent<Image>().sprite = FuncButtonPics;
                                        for(int j = 0 ; j < funcList.Count; j++)
                                        {
                                            myList.Add(funcList[j]);
                                        }
                                        
                                        button_sayac = button_sayac - 1;
                                        sayac_text.text = button_sayac.ToString();
                                        sayac = sayac + funcList.Count;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        }
    public void OnGui()
    {

            play.SetActive(false);
            stop.SetActive(true);

            StartCoroutine("gecikme");

    }
    public void Update()
    {
       
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PauseGame() 
        {
        pauseEkranı.SetActive(true);
        } 
    public void ContinueGame()
    {
        pauseEkranı.SetActive(false);
    }
    public void TurnToMenuBasic()
    {
        SceneManager.LoadScene("Episode");
    }
    public void TurnToMenuFunction()
    {
        SceneManager.LoadScene("Episode2");
    }
    public void TurnToMenuLoop()
    {
        SceneManager.LoadScene("Episode3");
    }
    public void NextGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    IEnumerator gecikme()
    {
        yield return new WaitForSeconds(0.8f);
        print(sayac);
        for (int i = 0; i < sayac; i++)
        {

            if (myList[i] == "Sol")
            {
                for (int j = 0; j <= 15; j++)
                {
                    yield return new WaitForSeconds(0.015f);
                    myObject.GetComponent<Hareket>().Update(0, 1);
                    myObject.GetComponent<Hareket>().FixedUpdate();
                    

                }
                yield return new WaitForSeconds(1);
            }

            if (myList[i] == "Sag")
            {
                for (int j = 0; j <= 15; j++)
                {
                    yield return new WaitForSeconds(0.015f);
                    myObject.GetComponent<Hareket>().Update(0, -1);
                    myObject.GetComponent<Hareket>().FixedUpdate();
                    
                   

                }
                yield return new WaitForSeconds(1);
            }

            if (myList[i] == "İleri")
            {
                for (int j = 0; j <= 15; j++)
                {
                    yield return new WaitForSeconds(0.015f);
                    myObject.GetComponent<Hareket>().Update(1, 0);
                    
                    myObject.GetComponent<Hareket>().FixedUpdate();
                 
                    
                }
                yield return new WaitForSeconds(1);
            }

            if (myList[i] == "Geri")
            {
                for (int j = 0; j <= 15; j++)
                {
                    yield return new WaitForSeconds(0.015f);
                    myObject.GetComponent<Hareket>().Update(-1, 0);
                   
                    myObject.GetComponent<Hareket>().FixedUpdate();
                 
                   

                }
                yield return new WaitForSeconds(1);
            }
        }
        float x = myObject.transform.position.x;
        float y = myObject.transform.position.y;
        float z = myObject.transform.position.z;
        print(x);
        print(y);
        print(z);
        if ( x >= kucuk_x && x <= buyuk_x )
        {

            if (y >= kucuk_y && y <= buyuk_y)
            {
                if (z >= kucuk_z && z <= buyuk_z)
                {
                    if (button_hakkı-button_sayac <= three_star_steps)
                    {
                        sonucEkranı.SetActive(true);
                        three_star.SetActive(true);
                    }
                    if(button_hakkı - button_sayac > three_star_steps && button_hakkı - button_sayac <= two_star_steps)
                    {
                        sonucEkranı.SetActive(true);
                        two_star.SetActive(true);
                    }
                    if(button_hakkı - button_sayac >= one_star_steps )
                    {
                        sonucEkranı.SetActive(true);
                        one_star.SetActive(true);
                    }
                    
                }
            }
                
        }
        else
        {
            sonucEkranı.SetActive(true);
            zero_star.SetActive(true);
            nextButton.SetActive(false);
        }
    }

    public void MainMenu()
    {
       
            mainMenu.GetComponent<Image>().sprite = mainPic1;
            funcMenu.GetComponent<Image>().sprite = funcPic2;

    }
    public void SelectFuncMenu()
    {
            mainMenu.GetComponent<Image>().sprite = mainPic2;
            funcMenu.GetComponent<Image>().sprite = funcPic1;
    }

    public void RemoveButton1()
    {
        int s = 0;
        if (buttons[0].GetComponent<Image>().sprite == FuncButtonPics)
        {
            s = s + funcList.Count - 1;
            for (int k = 1; k <= funcList.Count; k++)
            {
                myList.RemoveAt(0);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
         
            myList.RemoveAt(s);
            sayac = sayac - 1;

        }

        
        for (int i = 0; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton2()
    {
        int s = 0;
        for(int i=0; i<1; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
            

        }
        if (buttons[1].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count+(s-1); k++)
            {
                myList.RemoveAt(s+1);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(1 + s);
            sayac = sayac - 1;

        }
        for (int i = 1; i < buttons.Length ; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton3()
    {
        int s = 0;
        for (int i = 0; i < 2; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count-1;
            }
            
        }
        if (buttons[2].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(2+s);
            sayac = sayac - 1;
        }

            for (int i = 2; i < buttons.Length; i++)
            {
                if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                    || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                    || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
                {
                    buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
                }
                else
                {
                    buttonsVisibled[i - 1].SetActive(false);
                }
            }


            button_sayac = button_sayac + 1;
            sayac_text.text = button_sayac.ToString();
            
        }
    
    public void RemoveButton4()
    {
        int s = 0;
        for (int i = 0; i < 3; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[3].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(3 + s);
            sayac = sayac - 1;
        }

        for (int i = 3; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton5()
    {
        int s = 0;
        for (int i = 0; i < 4; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[4].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(4 + s);
            sayac = sayac - 1;
        }

        for (int i = 4; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton6()
    {
        int s = 0;
        for (int i = 0; i < 5; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[5].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(5 + s);
            sayac = sayac - 1;
        }

        for (int i = 5; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton7()
    {
        int s = 0;
        for (int i = 0; i < 6; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[6].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(6 + s);
            sayac = sayac - 1;
        }

        for (int i = 6; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton8()
    {
        int s = 0;
        for (int i = 0; i < 7; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[7].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(7 + s);
            sayac = sayac - 1;
        }

        for (int i = 7; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton9()
    {
        int s = 0;
        for (int i = 0; i < 8; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[8].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(8 + s);
            sayac = sayac - 1;
        }

        for (int i = 8; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton10()
    {
        int s = 0;
        for (int i = 0; i < 9; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[9].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(9 + s);
            sayac = sayac - 1;
        }

        for (int i = 9; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton11()
    {
        int s = 0;
        for (int i = 0; i < 10; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[10].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(10 + s);
            sayac = sayac - 1;
        }

        for (int i = 10; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton12()
    {
        int s = 0;
        for (int i = 0; i < 11; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[11].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(11 + s);
            sayac = sayac - 1;
        }

        for (int i = 11; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton13()
    {
        int s = 0;
        for (int i = 0; i < 12; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[12].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(12 + s);
            sayac = sayac - 1;
        }

        for (int i = 12; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton14()
    {
        int s = 0;
        for (int i = 0; i < 13; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[13].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
               
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(13 + s);
            sayac = sayac - 1;
        }

        for (int i = 13; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }
    public void RemoveButton15()
    {
        int s = 0;
        for (int i = 0; i < 14; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                s = s + funcList.Count - 1;
            }
        }
        if (buttons[14].GetComponent<Image>().sprite == FuncButtonPics)
        {

            for (int k = s; k <= funcList.Count + (s - 1); k++)
            {
                myList.RemoveAt(s + 1);
                
            }
            sayac = sayac - funcList.Count;
        }
        else
        {
            myList.RemoveAt(14 + s);
            sayac = sayac - 1;
        }

        for (int i = 14; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
                || buttons[i].GetComponent<Image>().sprite == FuncButtonPics)
            {
                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;
            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }
        }


        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();
        
    }

    public void FuncRemoveButton1()
    {
        for (int i = 0; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(0);
    }
    public void FuncRemoveButton2()
    {
        for (int i = 1; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(1);
    }
    public void FuncRemoveButton3()
    {
        for (int i = 2; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(2);
    }
    public void FuncRemoveButton4()
    {
        for (int i = 3; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(3);
    }
    public void FuncRemoveButton5()
    {
        for (int i = 4; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(4);
    }
    public void FuncRemoveButton6()
    {
        for (int i = 5; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(5);
    }
    public void FuncRemoveButton7()
    {
        for (int i = 6; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(6);
    }
    public void FuncRemoveButton8()
    {
        for (int i = 8; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(8);
    }
    public void FuncRemoveButton9()
    {
        for (int i = 8; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(8);
    }
    public void FuncRemoveButton10()
    {
        for (int i = 9; i < funcButtons.Length; i++)
        {

            if (funcButtons[i].GetComponent<Image>().sprite == RightButtonPic || funcButtons[i].GetComponent<Image>().sprite == LeftButtonPic
                || funcButtons[i].GetComponent<Image>().sprite == UpButtonPic || funcButtons[i].GetComponent<Image>().sprite == DownButtonPic)
            {

                funcButtons[i].GetComponent<Image>().sprite = funcButtons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                funcbuttonsVisibled[i - 1].SetActive(false);
            }

        }
        funcList.RemoveAt(9);
    }
}
  
       

