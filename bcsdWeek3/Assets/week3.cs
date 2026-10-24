using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.InputSystem;
using System.IO;
using UnityEngine.Networking;
using System;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
//public class Player
//{
//    public string name;
//    public int age;

//    [NonSerialized]
//    public string address;

//    public Player(string name, int age, string address)
//    {
//        this.name = name;
//        this.age = age;
//        this.address = address;
//    }

//    public void PrintData()
//    {
//        Debug.Log($"{name} : 나이는 {age}, 주소는 {address}");
//    }

//}

public class week3 : MonoBehaviour
{

    void Awake()
    {
        ////객체 직렬화
        //Stream writeStream = new FileStream("BinaryFormatter.dat", FileMode.Create);

        //BinaryFormatter binaryFormatter = new BinaryFormatter();

        //Player writePlayer = new Player("고박사", 35, "고박사의 유니티 노트");

        //binaryFormatter.Serialize(writeStream, writePlayer);

        //writeStream.Close();

        //Stream readStream = new FileStream("BinaryFormatter.dat", FileMode.Open);

        //Player readPlayer = binaryFormatter.Deserialize(readStream) as Player;

        //readStream.Close();

        //readPlayer.PrintData();

        ////텍스트파일 처리
        //Stream writeStream = new FileStream("TextFileStream.dat", FileMode.Create);
        //StreamWriter streamWriter = new StreamWriter(writeStream);

        //streamWriter.Write(35);
        //streamWriter.Write(12.34f);
        //streamWriter.Write("BCSD");

        //streamWriter.Close();

        //Stream readStream = new FileStream("TextFileStream.dat", FileMode.Open);
        //StreamReader streamReader = new StreamReader(readStream);

        //while (streamReader.EndOfStream == false) 
        //{
        //    Debug.Log(streamReader.ReadLine());
        //}

        //streamReader.Close();

        ////이진데이터 처리
        //Stream streamWriter = new FileStream("TextFileStream.dat", FileMode.Create);
        //BinaryWriter binaryWriter = new BinaryWriter(writeStream);

        //binaryWriter.Write(35);
        //binaryWriter.Write(12.34f);
        //binaryWriter.Write("BCSD");

        //binaryWriter.Close();

        //Stream readStream = new FileStream("BinaryFileStream.dat", FileMode.Open);
        //BinaryReader binaryReader = new BinaryReader(readStream);

        //Debug.Log(binaryReader.ReadInt32());
        //Debug.Log(binaryReader.ReadSingle());
        //Debug.Log(binaryReader.ReadString());

        //binaryReader.Close();

        ////fileStream Class

        ////파일에 데이터 쓰기
        //int writeData = 35;
        ////1. 파일 스트림 생성 (새 파일 생성 모드)
        //Stream writeStream = new FileStream("FileStream.dat", FileMode.Create);
        ////2. int를 byte 베열로 변환
        //byte[] writeBytes = BitConverter.GetBytes(writeData);
        ////3. 변환한 byte 배열으 파일 스트림을 통해 파일에 기록
        //writeStream.Write(writeBytes, 0, writeBytes.Length);
        ////4. 파일 스트림 닫기
        //writeStream.Close();

        ////파일로부터 데이터 읽기
        //byte[] readBytes = new byte[8];
        ////1. 파일 스트림 생성 (파일 열기 모드)
        //Stream readStream = new FileStream("FileStream.dat", FileMode.Open);
        ////2. bytes 길이만큼(8바이트) 데이털ㄹ 읽어 bytes에 저장
        //readStream.Read(readBytes, 0, readBytes.Length);
        ////3. Bitconverter를 이용하여 bytes에 담겨 있는 값을 int 형식으로 변환
        //int readData = BitConverter.ToInt32(readBytes, 0);
        ////4. 파일 스트임 닫기
        //readStream.Close();

        //Debug.Log($"파일에 저장되어 있는 데이터 : {readData}");

        ////DirectoryInfo Class
        //DirectoryInfo currentDirectory;

        ////C 드라이브 경로
        ////string path = "C:\\"

        ////바탕화면 경로
        ////Environment.GetFolderPath() : 윈도우에 존재하는 폴더 경로를 얻어오는 메소드
        ////Environment.SpecialFoder : 윈도우에 존재하는 특수 폴더 열거형
        ////string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        ////Application.dataPath는 ㅍ로젝트 폴더\Assets\경로
        //string path = Application.dataPath;

        ////메모리를 할당할 때 생성자 매개변수에 사용할 폴더의 경로/파일명을 문자열로 작성
        //currentDirectory = new DirectoryInfo(path);

        ////현재 폴더의 하위에 새 폴더 생성(매개변수 : 입력된 경로/파일명)
        //currentDirectory.CreateSubdirectory("TestA");

        //Debug.Log($"전체경로 + 폴더이름 : {currentDirectory.FullName}");
        //Debug.Log($"폴더이름 : {currentDirectory.Name}");

        //bool isExists = currentDirectory.Exists;
        //Debug.Log($"{currentDirectory.Name} 폴더 존재 여부 : {isExists}");

        //FileAttributes attr = currentDirectory.Attributes;
        //Debug.Log($"{currentDirectory.Name} 폴더 속성 : {attr}");

        //Debug.Log($"== 현재 촐더에 존재하는 모든 폴더 ==");
        //foreach (DirectoryInfo directory in currentDirectory.GetDirectories()) 
        //{
        //    Debug.Log(directory.Name);
        //}

        //Debug.Log($"== 현재 촐더에 존재하는 모든 파일 ==");
        //foreach (DirectoryInfo file in currentDirectory.GetDirectories())
        //{
        //    Debug.Log(file.Name);
        //}

        ////Directory Class
        //Directory.CreateDirectory("Exercise");

        //Directory.Move("Exercise", "Exercise2");

        //bool isExists = Directory.Exists("Exercise2");
        //Debug.Log($"Exercise2 폴더 존재 여부 : {isExists}");

        //string[] directorys = Directory.GetDirectories("Exercise2");
        //Debug.Log($"하위 폴더 개수 : {directorys.Length}");

        //string[] files = Directory.GetFiles("Exercise2");
        //Debug.Log($"하위 파일 개수 : {files.Length}");

        //Directory.Delete("Exercise2");


        ////FileInfo class 생성
        //FileInfo fileInfo = new FileInfo("d.dat");

        //FileStream file = fileInfo.Create();

        //file.Close();

        //fileInfo.CopyTo("e.dat");

        //fileInfo.MoveTo("f.dat");

        //bool isExists = fileInfo.Exists;
        //Debug.Log($"{fileInfo.Name} 파일 존재 여부 : {isExists}");

        //FileAttributes attr = fileInfo.Attributes; 
        //Debug.Log($"{fileInfo.Name} 파일 속성 : {attr}");

        //fileInfo.Delete();

        ////파일입출력
        //FileStream file = File.Create("a.dat");
        ////외부 파일 제어를 위해서는 반드시 close() 필요
        //file.Close();

        //File.Copy("a.dat", "b.dat");

        //File.Move("a.dat", "c.dat");

        //bool isExists = File.Exists("c.dat");
        //Debug.Log($"c.dat 파일 존재 여부 : {isExists}");

        //FileAttributes attr = File.GetAttributes("c.dat");
        //Debug.Log($"c.dat 파일 속성 : {attr}");

        ////File.Delete("c.dat");
        ////File.Delete("b.dat");

        ////Dictionary()
        //Dictionary<string, string> dictionary = new Dictionary<string, string>();

        //dictionary["1"] = "First";
        //dictionary["2"] = "Second";
        //dictionary["3"] = "Third";

        //PrintDictionary(dictionary);

        //dictionary.Remove("1");

        //PrintDictionary(dictionary);

        ////일반화 컬렉션 Stack<int>()
        //Stack<int> stack = new Stack<int>();

        //for (int i = 0; i < 5; ++i)
        //{
        //    stack.Push(i);
        //}

        //Debug.Log($"Stack Count : {stack.Count}");

        //while (stack.Count > 0)
        //{
        //    Debug.Log($"Stack Data : {stack.Pop()}");
        //}

        //Debug.Log($"Stack Count : {stack.Count}");


        ////일반화 컬렉션 Queue<int>()
        //Queue<int> queue = new Queue<int>();

        //for (int i = 0; i < 5; ++i)
        //{
        //    queue.Enqueue(i);
        //}

        //Debug.Log($"Queue Count : {queue.Count}");

        //while (queue.Count > 0) 
        //{
        //    Debug.Log($"Queue Data : {queue.Dequeue()}");
        //}

        //Debug.Log($"Queue Count : {queue.Count}");

        //일반화 컬렉션 List<int>()
        //List<int> list = new List<int>();

        //for (int i = 0; i < 5; ++i) 
        //{
        //    list.Add(i);
        //}

        //PrintList<int>(list);

        //list.Insert(0, 10000);

        //PrintList(list);

        //list.RemoveAt(1);

        //PrintList(list);

        //Debug.Log($"List Count : {list.Count}");



        ////Hashtable();
        //Hashtable hash = new Hashtable();

        //Goblin goblin = new Goblin();
        //Slime slime = new Slime();

        ////요소 추가 방법 1
        //hash["Goblin"] = goblin;
        ////요소 추가 방법 2
        //hash.Add("Slime", slime);
        //hash.Add(1, "정수");
        //hash.Add(1.2f, "실수");
        //hash.Add("BCSD", "문자열");

        ////hashtable은 for문으로 탐색 불가 -> foreach 사용
        //foreach (object key in hash.Keys) 
        //{
        //    Debug.Log($"hash[{key}] = {hash[key]}");
        //}

        //if (hash.ContainsKey("Slime")) 
        //{
        //    Debug.Log($"Slime 키 존재");
        //}

        //if (hash.ContainsKey(goblin))
        //{
        //    Debug.Log($"{goblin} 값 존재");
        //}

        //Debug.Log($"Hashtable Count : {hash.Count}");

        //hash.Remove("Slime");

        //Debug.Log($"Hashtable Count : {hash.Count}");

        //hash.Clear();

        //Debug.Log($"Hashtable Count : {hash.Count}");

        //Stack stack = new Stack();

        //for (int i = 0; i < 5; ++i)
        //{
        //    stack.Push(i);
        //}

        //Debug.Log($"Stack Count : {stack.Count}");

        //Debug.Log($"마지막에 추가된 요소 : {stack.Peek()}");

        //Debug.Log($"Stack Count : {stack.Count}");

        //object data = stack.Pop();
        //Debug.Log($"Stack에서 빠져나온 데이터 : {data}");

        //Debug.Log($"Stack Count : {stack.Count}");

        //stack.Clear();

        //Debug.Log($"Stack Count : {stack.Count}");

        ////Queue()
        //Queue queue = new Queue();

        //for(int i =0; i<5; ++i)
        //{
        //    queue.Enqueue(i);
        //}

        //Debug.Log($"Queue Count : {queue.Count}");

        //Debug.Log($"현재 0번 요소 : {queue.Peek()}");

        //Debug.Log($"Queue Count : {queue.Count}");

        //object data = queue.Dequeue();
        //Debug.Log($"Queue에서 빠져나온 데이터 : {data}");

        //Debug.Log($"Queue Count : {queue.Count}");

        //queue.Clear();

        //Debug.Log($"Queue Count : {queue.Count}");


        //    //ArrayList()
        //    ArrayList arrayList = new ArrayList();

        //    Debug.Log(arrayList.Add(10));
        //    Debug.Log(arrayList.Add(12.3f));
        //    Debug.Log(arrayList.Add("BCSD"));

        //    //PrintArrayList(arrayList);

        //    arrayList.Insert(1, 100);

        //    //PrintArrayList(arrayList);

        //    Collection<int> data = new Collection<int>();
        //    data.Add(1);
        //    data.Add(3);
        //    data.Add(2);
        //    arrayList.AddRange(data);

        //    //PrintArrayList(arrayList);

        //    arrayList.Sort();

        //    //PrintArrayList(arrayList);

        //    arrayList.Remove(10);

        //    //PrintArrayList(arrayList);

        //    arrayList.RemoveAt(0);

        //    //PrintArrayList(arrayList);

        //    arrayList.RemoveRange(0, 2);
        //    //PrintArrayList(arrayList);

        //    arrayList.Clear();

        //    Debug.Log(arrayList.Count);




    }

    //public void PrintArrayList(ArrayList list)
    //{
    //    Debug.Log("====================================");
    //    for (int i = 0; i < list.Count; ++i)
    //    {
    //        Debug.Log($"list[{i}] = {list[i]}");
    //    }


    //}

    //class Goblin 
    //{ 

    //}

    //class Slime 
    //{

    //}

    //public void PrintList<T>(List<T> list) 
    //{
    //    Debug.Log("====================================");
    //    for (int i = 0; i < list.Count; ++i)
    //    {
    //        Debug.Log($"list[{i}] = {list[i]}");
    //    }

    //}

    //public void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
    //{
    //    Debug.Log("====================================");
    //    foreach (KeyValuePair<TKey, TValue> pair in dictionary)
    //    {
    //        Debug.Log($"dictionary[{pair.Key}] = {pair.Value}");
    //    }
    //}


}
