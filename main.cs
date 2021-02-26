using System;
using System.IO;
using System.Collections.Generic;
class Seprite{
		public Dictionary<string, string> varstorage=
			new Dictionary<string, string>();
		void Main (string[] args) {}
	
	}
class MainClass {
	static Seprite s = new Seprite();
	public static string RemoveCOMMAND(string text) { text = text.Replace("variable.get ", "").Replace("variable.new ", "").Replace("variable.set ", "").Replace("sys.print ", "").Replace("sys.exit12",""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return oRegEx.Replace(text, string.Empty); }
	static void loop() {
		ren();
	}
	static void ren() {
		var variable = "";
		Console.Write("litsystem.shell_input$ ");
		string et = Console.ReadLine();
		if(et.Contains("variable.get")){
			string e = RemoveCOMMAND(et);
			if(s.varstorage[e] == ""){
				Console.WriteLine("[text blank]");
			}
			else{
				Console.WriteLine(s.varstorage[e]);
			}
		}
		if(et.Contains("variable.set")){
			string y_tho = RemoveCOMMAND(et);
			Console.Write("set variable "+ y_tho +" to:");
			string ytho = Console.ReadLine();
			s.varstorage[y_tho] = ytho;
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt+".litsystem_output: var \""+y_tho+"\" set to: "+ytho);
			loop();
		}
		if(et.Contains("variable.new")){
			variable = RemoveCOMMAND(et);
			s.varstorage.Add(variable, "");
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt+".litsystem_output: new var \""+variable+"\" set");
			loop();
		}
		if(et.Contains("sys.print ")){
			string etr = RemoveCOMMAND(et);
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt+".litsystem_output:"+etr);
			loop();
			
		}
		if(et == "sys.exit12"){
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt);
			System.Environment.Exit(12);
		}
		if(et == ".help."){
			Console.WriteLine("command list and uses: \n sys.print{prints a string input} \n sys.exit12{ exits the program whith exit code (12) }\n variable.new {adds a variable}\n variable.set {edits a variable}\n variable.get{prints a variable}\nlitsystem output: \n litsystem_output_code: { prints the output code } \n litsystem_output:{ shows the output } \n litsystem.shell_input$ { command line input }");
			loop();
		}
		else{
			loop();
		}
	}
  public static void Main (string[] args) {
		
    Console.WriteLine("compile a .litsystem file or  run from command line.");
		string choise = Console.ReadLine();
		if(choise == "command line"){
			Console.WriteLine("litsystem command line input, type .help. to see all commands \n coppywrite 2021, pressStart10");
			ren();
		}
  }
}