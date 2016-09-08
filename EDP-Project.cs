using System;
class Rafiki_Self_Help{
	// note: separete the different modules into methods
	static void Main(string[] args){
		// Declarations //
		string[] members = {"Alex", "Kelly", "Ken", "Wanjugu", "Sandie"};
		double[] totalsavings = {1000.0, 2000.0, 100.0, 10000.0, 5000.0};
		int[] time = {4, 6, 1, 2, 3};//time in months
		// each memory location for members, totalavings and time corresponds to one member
		// for instance Alex has 1000.0 saved and has been a member for 4 months
		int count = 5;// number of memebers
		string member_name = "";
		double loan = 0;
		int n;
		
		Console.WriteLine("Enter the members name");
		member_name = Console.ReadLine();
		for(n = 0; n < count++; n++){//loop used to go through the array members[]
			// the line below is used to compare two strings and see if they are equal and also ignores the case meaning 'a' is equal to 'A'
			if((member_name.Equals(members[n], StringComparison.OrdinalIgnoreCase)) == true){ 
				Console.WriteLine("Client is a member");
				
				if(time[n] >= 3){
					Console.WriteLine("Member can apply for a loan");
					Console.WriteLine("How much would the member like to borrow?");
					loan = Convert.ToDouble(Console.ReadLine());
					
					if(loan <= 3.0 * totalsavings[n]){
						Console.WriteLine("Loan accepted");
						Console.WriteLine("What type of loan would you like to apply for? (1, 2 or 3)");
						Console.WriteLine("|---------------------------------------------------------|");
						Console.WriteLine("| No. | Type       | Rate | Max Amount| Max Payment Period|");
						Console.WriteLine("|-----|------------|------|-----------|-------------------|");
						Console.WriteLine("| 1.  | Investment | 12%  | 100,000   | 36 months/3 years |");
						Console.WriteLine("| 2.  | Emergency  | 8%   | 50,000    | 12 months/1 year  |");
						Console.WriteLine("| 3.  | Education  | 10%  | 60,000    | 24 months/2 years |");
						Console.WriteLine("|---------------------------------------------------------|");
						int ans = Convert.ToInt32(Console.ReadLine());
						
						switch(ans){
							case 1:
								Console.WriteLine("Applicant's Name: " + members[n]);
								Console.WriteLine("Type of loan applied for: Investment");
								Console.WriteLine("Amount applied for: " + loan);
								Console.WriteLine("Repayment Period: 36 months or 3 years");
								Console.WriteLine("Total amount to pay: NEEDS TO BE DONE");//needs to be done
								Console.WriteLine("Loan Application Status: Approved");
								break;
							case 2:
								Console.WriteLine("Applicant's Name: " + members[n]);
								Console.WriteLine("Type of loan applied for: Emergency");
								Console.WriteLine("Amount applied for: " + loan);
								Console.WriteLine("Repayment Period: 12 months or 1 year");
								Console.WriteLine("Total amount to pay: NEEDS TO BE DONE");//needs to be done
								Console.WriteLine("Loan Application Status: Approved");
								break;
							case 3:
								Console.WriteLine("Applicant's Name: " + members[n]);
								Console.WriteLine("Type of loan applied for: Education");
								Console.WriteLine("Amount applied for: " + loan);
								Console.WriteLine("Repayment Period: 24 months or 2 years");
								Console.WriteLine("Total amount to pay: NEEDS TO BE DONE");//needs to be done
								Console.WriteLine("Loan Application Status: Approved");
								break;
							default:
								Console.WriteLine("Error encountered :( ");
								break;
						}
						break;// successfully completed all conditions
					}else {
						Console.WriteLine("That loan is way to high you need to cut it");
						break;// loan condition not met
					}
				}else {
					Console.WriteLine("That time is way to short you need to add it");
					break; // time period condition not met
				}
			}
			// the else-if block below does not appear to work //
			// the program crashes when its supposed to run this part // 
			else if(n == count){// ideally when it reaches th end of the members[] array it should ask if they would like to add the client as a member
					Console.WriteLine("Client is not a member");
					Console.WriteLine("Would you like to add client as member? (1: yes or 2: no)");
					int answer = Convert.ToInt32(Console.ReadLine());
					if(answer == 1){
						Console.WriteLine("Enter clients name");
						member_name = Console.ReadLine();
						count = count + 1;
						members[count] = member_name;
						Console.WriteLine("Enter amount member will deposit");
						totalsavings[count] = Convert.ToDouble(Console.ReadLine());
						time[count] = 0;
					}else{
						break;
					}
			}else{
				continue;
			}
		}
		Console.WriteLine("This is the end and it works until here :D"); // if this line runs know that all is well
	}
}
//had planned on using files to save all the member information
//FileStream F = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
//F.WriteInt((byte)i);