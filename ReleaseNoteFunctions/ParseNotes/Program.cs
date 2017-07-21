using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ParseNotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            private static readonly HttpClient client = new HttpClient;






			// Read the file and display it line by line.
			System.IO.StreamReader file =
			   new System.IO.StreamReader("/Users/arnav/Documents/SocedoReleaseNotes.md");


            //var line = file.ReadLine();
            string line;


            //This array? should be a list of words in a line


            string ticketLabelKey = "SOC-";
            string ticketLabelKey2 = "Soc-";
            var ticketNames = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
				string[] splitLine = line.Split(null);
                //This foreach loops through the words in the array
				foreach (var check in splitLine)
				{
					//This if statement checks if the word contains the project key (SOC)
					if (check.Contains(ticketLabelKey) || check.Contains(ticketLabelKey2))
					{
						ticketNames.Add(check);
						Console.WriteLine(check, " has entered the list");

					}

				}
            }
	            
                

			file.Close();

            // Print the contents of the list of tickets
            foreach (var ticket in ticketNames)
            {
                Console.WriteLine(ticket);
            }
            Console.WriteLine("The number of ticket names are: {0}", ticketNames.Count);



        }
    }
}
