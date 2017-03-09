using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Auxiliar.MonoEnums
{
    /// <summary>
    /// Enumerate all tags used to tag the prefabs on project
    /// </summary>
    public enum ETagName
    {
        [Description("Untagged")]
        Untagged = 0,

        [Description("Respawn")]
        Respawn = 1,

        [Description("Finish")]
        Finish = 2,

        [Description("EditorOnly")]
        EditorOnly = 3,

        [Description("MainCamera")]
        MainCamera = 4,

        [Description("Background")]
        Background = 5,
        
        [Description("Player")]
        Player = 6,

        [Description("GameController")]
        GameController = 7,

        [Description("Ground")]
        Ground = 8,

        [Description("Box")]
        Box = 9,

        [Description("CheckPoint")]
        CheckPoint = 10,

        [Description("Spike")]
        Sprike = 11
    };

    /// <summary>
    /// Represent the color of the object
    /// </summary>
    public enum EColor
    {
        [Description("White")]
        White = 0,

        [Description("Black")]
        Black = 1,

        [Description("Both")]
        Both = 2
    }
    
    /// <summary>
    /// Static class with the functions related to the MonoEnums.
    /// Do not need understanding
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// This function should only be used with MonoEnums 
        /// types, its not compatible with default enum types
        /// </summary>
        /// <returns>Returns a string description of the given enum</returns>
        public static string GetDescription(this Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}

