using System.Collections;
using UnityEngine;

public class Output : MonoBehaviour
{
    private int b = 1;
    private int a = 2;
    private int c = 3;

    public bool ascending;
    private ArrayList NUM = new();

    private void Awake()
    {
        NUM.Add(a);
        NUM.Add(b);
        NUM.Add(c);
    }

    void Start()
    {
        // Sorted internally
        NUM.Sort();
        print($"{NUM[0]} {NUM[1]} {NUM[2]}");
        
        // 조건문 사용함
        PrintSort(c, a, b); 
        
        // 배열 사용함
        print($"{NUM[1]} {NUM[2]} {NUM[0]}"); 
        print($"{NUM[2]} {NUM[0]} {NUM[1]}");
    }
    
    // Sorting method using conditional
    void PrintSort(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            if (b > c)
            {
                if (!ascending)
                {
                    print($"{a} {b} {c}");
                }
                else
                {
                    print($"{c} {b} {a}");
                }
            }
            else
            {
                if (!ascending)
                {
                    print($"{a} {c} {b}");
                }
                else
                {
                    print($"{b} {c} {a}");
                }
                
            }
        } 
        else if (b > a && b > c)
        {
            if (b > a && b > c)
            {
                if (!ascending)
                {
                    print($"{b} {a} {c}");
                }
                else
                {
                    print($"{c} {a} {b}");
                }
                
            }
            else
            {
                if (!ascending)
                {
                    print($"{b} {c} {a}");
                }
                else
                {
                    print($"{a} {c} {b}");
                }
                
            }
        } else if (c > a && c > b)
        {
            if (a > b)
            {
                if (!ascending)
                {
                    print($"{c} {a} {b}");
                }
                else
                {
                    print($"{b} {a} {c}");
                }
                
            }
            else
            {
                if (!ascending)
                {
                    print($"{c} {b} {a}");
                }
                else
                {
                    print($"{a} {b} {c}");
                }
                
            }
        }
    }
}
