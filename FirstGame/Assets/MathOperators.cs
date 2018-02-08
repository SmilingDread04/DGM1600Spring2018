using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour
{

    public int A = 10;
    public int B = 10;
    public int C = 10;

    // Use this for initialization
    void Start()
    {
        if (A + B == C)
        {
            print(C);
        }

        if (C - A == B)
        {
            print(B);
        }

        if (A * B == C)
        {
            print(C);
        }

        if (A / B == C)
        {
            print(C);
        }

        if (A <= 0)
        {
            A++;
        }

        if (A >= 10)
        {
            A--;
        }

        C = A + B;
		C += A + B;
		C -= A - B;
    }

}
