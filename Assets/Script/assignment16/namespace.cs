using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void PrintPosition()
        {
            Debug.Log($"Position: X = {X}, Y = {Y}, Z = {Z}");
        }
    }
}