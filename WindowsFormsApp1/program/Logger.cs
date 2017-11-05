using System;

namespace LayoutProject
{
    internal class Logger
    {
        internal static string GetTxt()
        {
            return
                "Version 1.6" +
                "\n- helper now supports ac remotes without display" +
                "\n- shared prefs made to all user inputs" +
                "\n\nVersion 1.5" +
                "\n- fixed screen rect element" +
                "\n\nVersion 1.4" +
                "\n- added vertifaction btn" +
                "\n\nVersion 1.3" +
                "\n- minor bug fixes with the config file" +
                "\n\nVersion 1.2" +
                "\n- added tinyPng support. Produce api key and use it:" +
                "\n- if you only want to use tiny png compressor, keep the xml path empty!" +
                "\n\nVersion 1.1" +
                "\n- added an AC display support " +
                "\n- now, if you want to add an element and position it on screen add a prefix of 'screen_element_' to it " +
                "\n- power button name simplified to 'power' (it was 'power_c25f1_1')" +
                "\n\nVersion 1.0" +
                "\nthis program will help you mark all of the relevent buttons on an ac remote." +
                "\nAT THE END OF THE MARKING It will delete all of the nodes which have a 'screen_element' preifx to them, from of the xml." +
                "\n\ntake Notice: the program will ALWAYS run over existing values.";
        }
    }
}