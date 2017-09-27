using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class UIObject : MonoBehaviour
{


    class UnitClass
    {
        public int Index;

        public string _Name;

        //public UnitClass (int index, string name)
        //{
        //    Index = index;
        //    Name = name;
        //}

    }

    public virtual void Initialize(string name)
    {
        //Debug.Log("DataTAble Initialize");
    }


}
