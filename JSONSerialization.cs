using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    public class SerializatioOpearion
    {
        //Binary Serialization Operation
        public static void BinarySerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\BinaryData.txt";
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 363, Name="Hitesh", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Surya", Age= 28},
                };
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, contact);
                stream.Close();
                Console.WriteLine("Binary Serialization Completed Succesfully");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Binary DeSerialization Operation
        public static void BinaryDeSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\BinaryData.txt";
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                List<Contact> listofcontact = (List<Contact>)bf.Deserialize(stream);
                stream.Close();
                foreach (Contact contact in listofcontact)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("Binary Deserialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //JSON Serialization Operation
        public static void JSONSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\JSONData.json";
            try
            {
                List<contact> contact = new List<contact>()
                {
                    new contact() {Id = 363, Name="Aniket", Age= 26},
                    new contact() {Id = 364, Name="Rana", Age= 24},
                    new contact() {Id = 365, Name="Ram", Age= 28},
                };
                string jsonData = JsonConvert.SerializeObject(contact);
                File.WriteAllText(path, jsonData);
                Console.WriteLine("JSON Serialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //JSON DeSerialization Operation
        public static void JSONDeSerializationFn()
        {
            string path = @"C:\New Git 236\FileOperation\FileOperation\FileOperation\FileOperation.csproj\JSONData.json";
            try
            {
                string jsonData = File.ReadAllText(path);
                List<contact> contacts = JsonConvert.DeserializeObject<List<contact>>(jsonData);
                foreach (contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("JSON Deserialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
