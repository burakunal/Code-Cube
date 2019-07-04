using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Basic : MonoBehaviour
{
    public GameObject myObject;
    public int button_sayac;
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
   
    public Button mainMenu;
    public Sprite mainPic1;
    public Sprite mainPic2;

    public Button[] buttons;

    public GameObject[] buttonsVisibled;

    public int sayac = 0;

    public void Start()
    {
        mainMenu.GetComponent<Image>().sprite = mainPic1;
     
        sayac_text.text = button_sayac.ToString();

    }
    public void IleriDevril()
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
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void NextGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
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
        if (x >= kucuk_x && x <= buyuk_x)
        {

            if (y >= kucuk_y && y <= buyuk_y)
            {
                if (z >= kucuk_z && z <= buyuk_z)
                {
                    if (button_hakkı - button_sayac <= three_star_steps)
                    {
                        sonucEkranı.SetActive(true);
                        three_star.SetActive(true);
                    }
                    if (button_hakkı - button_sayac > three_star_steps && button_hakkı - button_sayac <= two_star_steps)
                    {
                        sonucEkranı.SetActive(true);
                        two_star.SetActive(true);
                    }
                    if (button_hakkı - button_sayac >= one_star_steps)
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
 

    }
    public void SelectFuncMenu()
    {
        mainMenu.GetComponent<Image>().sprite = mainPic2;
       
    }

    public void RemoveButton1()
    {

        for (int i = 0; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(0);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton2()
    {

        for (int i = 1; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(1);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton3()
    {

        for (int i = 2; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(2);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton4()
    {

        for (int i = 3; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(3);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton5()
    {

        for (int i = 4; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(4);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton6()
    {

        for (int i = 5; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(5);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton7()
    {

        for (int i = 6; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(6);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton8()
    {

        for (int i = 7; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(7);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton9()
    {

        for (int i = 8; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(8);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton10()
    {

        for (int i = 9; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(9);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton11()
    {

        for (int i = 10; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(10);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton12()
    {

        for (int i = 11; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(11);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton13()
    {

        for (int i = 12; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(12);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton14()
    {

        for (int i = 13; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(13);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }
    public void RemoveButton15()
    {

        for (int i = 14; i < buttons.Length; i++)
        {

            if (buttons[i].GetComponent<Image>().sprite == RightButtonPic || buttons[i].GetComponent<Image>().sprite == LeftButtonPic
                || buttons[i].GetComponent<Image>().sprite == UpButtonPic || buttons[i].GetComponent<Image>().sprite == DownButtonPic
              )
            {

                buttons[i].GetComponent<Image>().sprite = buttons[i + 1].GetComponent<Image>().sprite;

            }
            else
            {
                buttonsVisibled[i - 1].SetActive(false);
            }

        }
        myList.RemoveAt(14);
        sayac = sayac - 1;
        button_sayac = button_sayac + 1;
        sayac_text.text = button_sayac.ToString();

    }

}



