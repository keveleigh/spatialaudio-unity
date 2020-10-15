// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using UnityEditor;
using UnityEngine;

namespace Microsoft.SpatialAudio.Spatializer.Editor
{
    /// <summary>
    /// Custom drawer for the startup of AnimationCurves. Sets the grid range for the curve editor.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurveDimensions))]
    public class CurveDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var curve = attribute as CurveDimensions;
            if (property.propertyType == SerializedPropertyType.AnimationCurve)
            {
                var rect = new Rect(curve.XMin, curve.YMin, System.Math.Abs(curve.XMin - curve.XMax), System.Math.Abs(curve.YMin - curve.YMax));
                EditorGUI.CurveField(position, property, Color.green, rect, new GUIContent(curve.Label));
            }
        }
    }
}
