﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Balloons
{

    public class UIScreen : MonoBehaviour
    {


        public virtual void Show()
        {
            gameObject.SetActive(true);
        }


        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }

    }

}