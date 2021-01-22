using System;
using System.IO;
class MainClass {
	public static string RemoveCOMMAND(string text) { text = text.Replace(".filesystem !CREATETEXT. ", "").Replace(".filesystem !CODE_12. ",""); var oRegEx = new System.Text.RegularExpressions.Regex("<[^>]+>"); return oRegEx.Replace(text, string.Empty); }
	static void loop() {
		ren();
	}
	static void ren() {
		Console.Write("litsystem.shell_input$ ");
		string et = Console.ReadLine();
		if(et.Contains(".filesystem !CREATETEXT. ")){
			string etr = RemoveCOMMAND(et);
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt+".litsystem_output:"+etr);
			loop();
		}
		if(et == ".filesystem !CODE_12."){
			System.Random random = new System.Random(); 
			int rtt = random.Next(50);
			Console.WriteLine("litsystem_output_code:"+rtt);
			System.Environment.Exit(12);
		}
		if(et == ".help."){
			Console.WriteLine("command list and uses: \n .filesystem !CREATETEXT.{prints a string input} \n .filesystem !CODE_12.{ exits the program whith exit code (12) }\n litsystem output: \n litsystem_output_code: { prints the output code } \n litsystem_output:{ shows the output } \n litsystem.shell_input$ { command line input }");
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