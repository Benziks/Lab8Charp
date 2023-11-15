using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueElements uniqueElements = new UniqueElements();
            string inputString = "go fe ff loplo like htyh shshss";
            uniqueElements.AddInput(inputString);

            //JSON
            string fileNameJson = "hashSet.json";
            FileManager.WriteJSON(uniqueElements.UniqueElementsHashSet, fileNameJson);

            HashSet<string> uniqueElementsJson = (HashSet<string>)FileManager.ReadJSON(fileNameJson, new HashSet<string> { });
            Console.WriteLine("uniqueElementsJson :\n");
            foreach (var element in uniqueElementsJson)
            {
                Console.WriteLine(element + "\n");
            }

            Console.WriteLine("------------------------");

            //BIN
            string fileNameBin = "hashSet.bin";
            FileManager.WriteBIN(uniqueElements.UniqueElementsHashSet, fileNameBin);

            HashSet<string> uniqueElementsBinary = (HashSet<string>)FileManager.ReadBIN(fileNameBin);
            Console.WriteLine("uniqueElementsBinary:\n");
            foreach (var element in uniqueElementsBinary)
            {
                Console.WriteLine(element + "\n");
            }
        }
    }
}
