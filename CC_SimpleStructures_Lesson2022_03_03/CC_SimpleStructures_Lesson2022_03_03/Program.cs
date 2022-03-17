using System;
using System.Collections;
using System.Windows.Forms;

namespace CC_SimpleStructures_Lesson2022_03_03
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            DoWork();

            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void DoWork()
        {
            //array with values
            int[] myArrayInts = {3, 2, 1};
            //array without values but with predetermiend length
            myArrayInts = new int[20];
            //array with both of the above
            myArrayInts = new int[5] {1, 2, 3, 4, 5};
            //can only add places to the array if you create a bigger one
            int[] newArray = new int[myArrayInts.Length + 5];

            //not type safe.
            ArrayList firstArrayList = new ArrayList();
            firstArrayList.Add(3);
            firstArrayList.Add("meir");
            firstArrayList.Add(new object());
            firstArrayList.Add(true);
            firstArrayList.Add(new Message());
            
            firstArrayList.AddRange(myArrayInts);

            //add new item in spacific index
            firstArrayList.Insert(2, "im from insert method");
            firstArrayList.InsertRange(4, new string[3] {"1", "2", "3"});

            //replace new item in spacific index
            firstArrayList[2] = "im from indexer";

            //remove method
            firstArrayList.Remove("meir");
            firstArrayList.RemoveAt(4);
            firstArrayList.RemoveRange(9, 2);

            StringArrayList msgArrLst = new StringArrayList();
            msgArrLst.Add("hello");
        }
    }
}