
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISystem
{
    void supported_commands(string[] command);
    void getFile(string name, string replace);
    void putFile(string name);
}

namespace FileSystem
{

    

    class Program
    {
        private static  MySystem sys;
        private static string shell = "SHELL>> ";
        static void Main(string[] args)
        {
            sys = new MySystem();

            while (true)
            {
                string command = "";

                while ( String.Compare(command,"") ==0 )
                {
                    Console.Write(shell);

                    command = Console.ReadLine();
                }

                if (String.Compare(command, "quit") == 0) break;

                string[] c = command.Split(' ');

                sys.supported_commands(c);

            }
            
        }

    }

    
    class MySystem : ISystem
    {
        private int maxFiles;
        private int NumOfBlocks;
        private int[] block;
        private int FilesNsystem;
       
        private MyFile[] files;
        
        
        public MySystem()
        {
            FilesNsystem = 0;
            NumOfBlocks = 1280;
            maxFiles = 128;
            
            block = new int[NumOfBlocks];
            files = new MyFile[maxFiles];

            //set each block to 4096 bytes
            for (int x = 0; x < NumOfBlocks; x++) block[x] = 4096;
        }

        public void supported_commands(string[] command)
        {

            if ( String.Compare(command[0],"get") == 0 )
                {
                    string name = command[1];
                    string replaced= null;
                    if (command[2] != null) replaced = command[2];
                    getFile(name, replaced);
                }
            if( String.Compare( command[0],"put" ) ==0 )
            {
                Console.WriteLine("PUT COMMAND!");
            }
        }

        public void getFile(string name, string replace)
        {
            return;
        }
        

        public void putFile(string name)
        {
            return;
        }
    }

    class MyFile
    {
        private string name;
        private string size;
        private string[] text;
        
        
    }
}
