using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Info
{
    public static char[,,] GameField;
    public static GameObject[,,] Cell;
    public static List<GameObject> PlayerX = new List<GameObject>();
    public static List<GameObject> PlayerY = new List<GameObject>();
    public static List<GameObject> PlayerZ = new List<GameObject>();
    public static int size = 6;
    public static int NumberStroke;
    public static bool D;
}
