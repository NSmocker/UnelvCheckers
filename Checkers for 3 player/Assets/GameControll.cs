using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControll : MonoBehaviour {
    public GameObject lattice;
    public GameObject Checker;
    public GameObject Cell;
    public Material[] Material;
    int size = Info.size;
    GameObject[,,] lattices;
    public Camera Camera;
    int Status;
    GameObject SelecedChecker;
    GameObject SelecedCell;
    public Text WinerText;
    public
    void Start() {
        Info.GameField = new char[size, size, size];
        Info.Cell = new GameObject[size, size, size];
        lattices = new GameObject[size, size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    lattices[i, j, k] = Instantiate(lattice);
                    lattices[i, j, k].transform.position = new Vector3(i, j - 0.5f, k);
                    lattices[i, j, k].SetActive(false);
                   Info.Cell[i, j, k] = Instantiate(Cell);
                    Info.Cell[i, j, k].transform.position = new Vector3(i, j, k);
                    if (i == 0 && (j % 2 == 0 && k % 2 == 0 || j % 2 == 1 && k % 2 == 1) && j > 1 && k > 1)
                    {
                        GameObject ch = Instantiate(Checker);
                        ch.transform.position = new Vector3(i, j, k);
                        ch.GetComponent<MeshRenderer>().material = Material[0];
                        Info.PlayerX.Add(ch);
                        Info.GameField[i, j, k] = 'X';
                    }
                    if (j == 0 && (i % 2 == 0 && k % 2 == 0 || i % 2 == 1 && k % 2 == 1) && i > 1 && k > 1)
                    {
                        GameObject ch = Instantiate(Checker);
                        ch.transform.position = new Vector3(i, j, k);
                        ch.GetComponent<MeshRenderer>().material = Material[3];
                        Info.PlayerY.Add(ch);
                        Info.GameField[i, j, k] = 'Y';
                    }
                    if (k == 0 && (j % 2 == 0 && i % 2 == 0 || j % 2 == 1 && i % 2 == 1) && j > 1 && i > 1)
                    {
                        GameObject ch = Instantiate(Checker);
                        ch.transform.position = new Vector3(i, j, k);
                        ch.GetComponent<MeshRenderer>().material = Material[6];
                        Info.PlayerZ.Add(ch);
                        Info.GameField[i, j, k] = 'Z';
                    }
                }
            }
        }


    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        lattices[i, j, k].SetActive(!lattices[i, j, k].activeSelf);
                    }
                }
            }
        }
        for (int i = 0; i < Info.PlayerX.Count; i++)
        {
            if (Info.PlayerX[i] == null)
                Info.PlayerX.RemoveAt(i);
        }
        for (int i = 0; i < Info.PlayerY.Count; i++)
        {
            if (Info.PlayerY[i] == null)
                Info.PlayerY.RemoveAt(i);
        }
        for (int i = 0; i < Info.PlayerZ.Count; i++)
        {
            if (Info.PlayerZ[i] == null)
                Info.PlayerZ.RemoveAt(i);
        }

        if (Info.PlayerX.Count == 0 && Info.NumberStroke == 0)
            Info.NumberStroke = 1;
        if (Info.PlayerY.Count == 0 && Info.NumberStroke == 1)
            Info.NumberStroke = 2;
        if (Info.PlayerZ.Count == 0 && Info.NumberStroke == 2)
            Info.NumberStroke = 0;
        if(Info.PlayerX.Count == 0 && Info.PlayerY.Count == 0 || Info.PlayerX.Count == 0 && Info.PlayerZ.Count == 0 || Info.PlayerY.Count == 0 && Info.PlayerZ.Count == 0)
        {
            WinerText.gameObject.SetActive(true);
            if(Info.PlayerX.Count != 0)
                WinerText.text = "Переміг перший гравець ";
            if (Info.PlayerY.Count != 0)
                WinerText.text = "Переміг другий гравець ";
            if (Info.PlayerZ.Count != 0)
                WinerText.text = "Переміг третій гравець ";
        }
        if (Status == 0)
        {
            Info.D = false;
            switch (Info.NumberStroke)
            {
                case 0:
                    for (int i = 0; i < Info.PlayerX.Count; i++)
                    {
                        Info.PlayerX[i].GetComponent<MeshRenderer>().material = Material[1];
                        Info.PlayerX[i].layer = 0;
                    }
                    for (int i = 0; i < Info.PlayerY.Count; i++)
                    {
                        Info.PlayerY[i].GetComponent<MeshRenderer>().material = Material[3];
                        Info.PlayerY[i].layer = 2;
                    }
                    for (int i = 0; i < Info.PlayerZ.Count; i++)
                    {
                        Info.PlayerZ[i].GetComponent<MeshRenderer>().material = Material[6];
                        Info.PlayerZ[i].layer = 2;
                    }
                    break;
                case 1:
                    for (int i = 0; i < Info.PlayerX.Count; i++)
                    {
                        Info.PlayerX[i].GetComponent<MeshRenderer>().material = Material[0];
                        Info.PlayerX[i].layer = 2;
                    }
                    for (int i = 0; i < Info.PlayerY.Count; i++)
                    {
                        Info.PlayerY[i].GetComponent<MeshRenderer>().material = Material[4];
                        Info.PlayerY[i].layer = 0;
                    }
                    for (int i = 0; i < Info.PlayerZ.Count; i++)
                    {
                        Info.PlayerZ[i].GetComponent<MeshRenderer>().material = Material[6];
                        Info.PlayerZ[i].layer = 2;
                    }
                    break;
                case 2:
                    for (int i = 0; i < Info.PlayerX.Count; i++)
                    {
                        Info.PlayerX[i].GetComponent<MeshRenderer>().material = Material[0];
                        Info.PlayerX[i].layer = 2;
                    }
                    for (int i = 0; i < Info.PlayerY.Count; i++)
                    {
                        Info.PlayerY[i].GetComponent<MeshRenderer>().material = Material[3];
                        Info.PlayerY[i].layer = 2;
                    }
                    for (int i = 0; i < Info.PlayerZ.Count; i++)
                    {
                        Info.PlayerZ[i].GetComponent<MeshRenderer>().material = Material[7];
                        Info.PlayerZ[i].layer = 0;
                    }
                    break;
            }
            Status = 1;
        }

        if (Status == 1 && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Checker")
                {
                    SelecedChecker = hit.transform.gameObject;
                }
                if (hit.transform.tag == "Cell")
                {
                    SelecedCell = hit.transform.gameObject;
                }
            }
        }

        if (Status == 1 && SelecedChecker != null)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        Info.Cell[i, j, k].SetActive(false);
                    }
                }
            }
            if (!SelecedChecker.GetComponent<CheckerScript>().Damka)
            {
                switch (Info.NumberStroke)
                {
                    case 0:
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    Info.Cell[i, j, k].GetComponent<MeshRenderer>().material = Material[1];
                                    if ((i + j + k) % 2 == 0)
                                    {

                                        bool T = i - SelecedChecker.transform.position.x <= 1 && i - SelecedChecker.transform.position.x >= 0;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.y - j) <= 1;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.z - k) <= 1;
                                        T = T && !(SelecedChecker.transform.position.x == i && SelecedChecker.transform.position.y == j && SelecedChecker.transform.position.z == k);
                                        if (T)
                                        {
                                            if (Info.GameField[i, j, k] == 0)
                                                Info.Cell[i, j, k].SetActive(true);
                                            if (Info.GameField[i, j, k] == 'Z' || Info.GameField[i, j, k] == 'Y')
                                            {
                                                Vector3 a = new Vector3(-SelecedChecker.transform.position.x + i, -SelecedChecker.transform.position.y + j, -SelecedChecker.transform.position.z + k);

                                                try
                                                {
                                                    if (Info.GameField[i + (int)a.x, j + (int)a.y, k + (int)a.z] == 0)
                                                        Info.Cell[i + (int)a.x, j + (int)a.y, k + (int)a.z].SetActive(true);
                                                }
                                                catch { }
                                            }
                                        }


                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    Info.Cell[i, j, k].GetComponent<MeshRenderer>().material = Material[4];
                                    if ((i + j + k) % 2 == 0)
                                    {
                                        bool T = j - SelecedChecker.transform.position.y <= 1 && j - SelecedChecker.transform.position.y >= 0;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.x - i) <= 1;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.z - k) <= 1;
                                        T = T && !(SelecedChecker.transform.position.x == i && SelecedChecker.transform.position.y == j && SelecedChecker.transform.position.z == k);
                                        if (T)
                                        {
                                            if (Info.GameField[i, j, k] == 0)
                                                Info.Cell[i, j, k].SetActive(true);
                                            if (Info.GameField[i, j, k] == 'Z' || Info.GameField[i, j, k] == 'X')
                                            {
                                                Vector3 a = new Vector3(-SelecedChecker.transform.position.x + i, -SelecedChecker.transform.position.y + j, -SelecedChecker.transform.position.z + k);
                                                try
                                                {
                                                    if (Info.GameField[i + (int)a.x, j + (int)a.y, k + (int)a.z] == 0)
                                                        Info.Cell[i + (int)a.x, j + (int)a.y, k + (int)a.z].SetActive(true);
                                                }
                                                catch { }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    Info.Cell[i, j, k].SetActive(false);
                                    Info.Cell[i, j, k].GetComponent<MeshRenderer>().material = Material[7];
                                    if ((i + j + k) % 2 == 0)
                                    {
                                        bool T = k - SelecedChecker.transform.position.z <= 1 && k - SelecedChecker.transform.position.z >= 0;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.x - i) <= 1;
                                        T = T && Mathf.Abs(SelecedChecker.transform.position.y - j) <= 1;
                                        T = T && !(SelecedChecker.transform.position.x == i && SelecedChecker.transform.position.y == j && SelecedChecker.transform.position.z == k);
                                        if (T)
                                        {
                                            if (Info.GameField[i, j, k] == 0)
                                                Info.Cell[i, j, k].SetActive(true);
                                            if (Info.GameField[i, j, k] == 'X' || Info.GameField[i, j, k] == 'Y')
                                            {
                                                Vector3 a = new Vector3(-SelecedChecker.transform.position.x + i, -SelecedChecker.transform.position.y + j, -SelecedChecker.transform.position.z + k);
                                                try
                                                {
                                                    if (Info.GameField[i + (int)a.x, j + (int)a.y, k + (int)a.z] == 0)
                                                        Info.Cell[i + (int)a.x, j + (int)a.y, k + (int)a.z].SetActive(true);
                                                }
                                                catch { }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        break;
                }

            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            bool T = i == SelecedChecker.transform.position.x && j - SelecedChecker.transform.position.y == k - SelecedChecker.transform.position.z;
                            T = T || (i == SelecedChecker.transform.position.x && j - SelecedChecker.transform.position.y == -k + SelecedChecker.transform.position.z);
                            T = T || (j == SelecedChecker.transform.position.y && i - SelecedChecker.transform.position.x == k - SelecedChecker.transform.position.z);
                            T = T || (j == SelecedChecker.transform.position.y && i - SelecedChecker.transform.position.x == -k + SelecedChecker.transform.position.z);
                            T = T || (k == SelecedChecker.transform.position.z && i - SelecedChecker.transform.position.x == j - SelecedChecker.transform.position.y);
                            T = T || (k == SelecedChecker.transform.position.z && i - SelecedChecker.transform.position.x == -j + SelecedChecker.transform.position.y);
                            if (T && Info.GameField[i, j, k] == 0)
                            {
                                Info.Cell[i, j, k].SetActive(true);
                            }
                        }
                    }
                }
            }
        }

        if (Status == 1 && SelecedCell != null)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        Info.Cell[i, j, k].SetActive(false);
                    }
                }
            }
            Info.GameField[(int)SelecedChecker.transform.position.x, (int)SelecedChecker.transform.position.y, (int)SelecedChecker.transform.position.z] = (char)0;
            Status = 2;
        }

        if (Status == 2)
        {
            if (SelecedChecker.transform.position == SelecedCell.transform.position)
            {
                char P = 'X';
                switch(Info.NumberStroke)
                {
                    case 0:
                        P = 'X';
                        if (SelecedChecker.transform.position.x == size - 1)
                        {
                            SelecedChecker.GetComponent<CheckerScript>().Damka = true;
                            SelecedChecker.transform.localScale = new Vector3(0.9f,0.9f,0.9f);
                        }
                        if (!Info.D)
                            Info.NumberStroke = 1;
                        break;
                    case 1:
                        P = 'Y';
                        if (SelecedChecker.transform.position.y == size - 1)
                        {
                            SelecedChecker.GetComponent<CheckerScript>().Damka = true;
                            SelecedChecker.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                        }
                        if (!Info.D)
                            Info.NumberStroke = 2;
                        break;
                    case 2:
                        P = 'Z';
                        if (SelecedChecker.transform.position.z == size - 1)
                        {
                            SelecedChecker.GetComponent<CheckerScript>().Damka = true;
                            SelecedChecker.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                        }
                        if (!Info.D)
                            Info.NumberStroke = 0;
                        break;
                }
                Info.GameField[(int)SelecedChecker.transform.position.x, (int)SelecedChecker.transform.position.y, (int)SelecedChecker.transform.position.z] = P;
                SelecedChecker.GetComponent<CheckerScript>().NoDestoy = false;
                SelecedChecker = null;
                SelecedCell = null;
                Status = 0;
            }
            else
            {
                Vector3 a =  SelecedCell.transform.position - SelecedChecker.transform.position;
                a.Normalize();
                SelecedChecker.GetComponent<CheckerScript>().NoDestoy = true;
                SelecedChecker.transform.position += a * Time.deltaTime * 2;
                if (Vector2.Distance(SelecedCell.transform.position, SelecedChecker.transform.position) < 0.1f)
                    SelecedChecker.transform.position = SelecedCell.transform.position;
            }
        }
    }


    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
