﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData
{
    //at load add the interractable monobehavior to the object?

    public string AssetBundleName { get; private set; }
    //is this even needed?
    public Vector3 TransformLocation { get; set; }
    public Quaternion TransformRotation { get; set; }
}
