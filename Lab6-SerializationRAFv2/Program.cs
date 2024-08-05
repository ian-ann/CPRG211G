using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
 
namespace Lab6_Serialization
{
    // Main class to test the code
    public class MainClass 
    {
        public const string filePath = "../../event.txt";

        public static void Main(string[] args)
        {
            Event myEvent = new Event { eventNumber = 1, location = "Calgary" };

            // Serialize the object to a file
            SerializePersonObject(myEvent);

            // Deserialize the object from the file
            DeserializePersonObject();

            ReadFromFile();
        }
        private static void DeserializePersonObject()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                Event newEvent = (Event)binaryFormatter.Deserialize(fs);

                Console.WriteLine($"{newEvent.eventNumber}\n{newEvent.location}");
            }

        }

        private static void SerializePersonObject(Event e)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using(FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    binaryFormatter.Serialize(fs, e);
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                }
        }

        static void ReadFromFile()
        {
            string content = "Hackathon";

            // Write "Hackathon" to the file
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(content);
                }
            }

            // Read the first, middle, and last characters
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                char firstChar = (char)fs.ReadByte();

                // Seek to the middle character. Middle is length / 2, adjusted for 0-based index.
                fs.Seek(content.Length / 2, SeekOrigin.Begin);
                char middleChar = (char)fs.ReadByte();

                // Seek to the last character. -1 because SeekOrigin.End starts from the end.
                fs.Seek(-1, SeekOrigin.End);
                char lastChar = (char)fs.ReadByte();

                Console.WriteLine($"In Word: {content}");
                Console.WriteLine($"The First Character is: \"{firstChar}\" \nThe Middle Character is: \"{middleChar}\" \nThe Last Character is: \"{lastChar}\" ");
            }
        }
    }
}
