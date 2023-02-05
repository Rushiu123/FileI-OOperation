using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileOperation
{
    public class SerializationOpearion
    {
        //Binary Serialization Operation
        public static void BinarySerializationFn()
        {
            string path = @"\BinaryData.txt";
            try
            {
                List<contact> contact = new List<contact>()
                {
                    new contact() {Id = 363, Name="Rushi", Age= 26},
                    new contact() {Id = 364, Name="Rana", Age= 24},
                    new contact() {Id = 365, Name="Surya", Age= 28},
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
            string path = @"C:\New Git 236\FileOperation\FileOperation\FileOperation\FileOperation.csproj\BinaryData.txt";
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
            string path = @"C:\New Git 236\FileOperation\FileOperation\FileOperation\FileOperation.csproj\JSONData.json";
            try
            {
                List<contact> contact = new List<contact>()
                {
                    new Contact() {Id = 363, Name="Manish", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Ramesh", Age= 28},
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
        //XML Serialization Operation
        public static void XMLSerializationFn()
        {
            string path = @"C:\New Git 236\FileOperation\FileOperation\FileOperation\FileOperation.csproj\XMLData.xml";
            try
            {
                List<contact> contact = new List<contact>()
                {
                    new contact() {Id = 363, name="Aniket", age= 26},
                    new contact() {Id = 364, name="Rana", age= 24},
                    new contact() {Id = 365, name="Ram", age= 28},
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<contact>));
                StreamWriter sw = new StreamWriter(path);
                xmlSerializer.Serialize(sw, contact);
                Console.WriteLine("XML Serialization Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //XML DeSerialization Operation
        public static void XMLDeSerializationFn()
        {
            try
            {
                string path = @"C:\New Git 236\FileOperation\FileOperation\FileOperation\FileOperation.csproj\XMLData.xml";
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                FileStream stream = new FileStream(path, FileMode.Open);
                List<contact> record = (List<contact>)xmlSerializer.Deserialize(stream);
                foreach (contact contact in record)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("XML Deserialization Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
