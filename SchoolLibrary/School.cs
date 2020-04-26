using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SchoolLibrary /// used to organise code and prevent Namespace collision
{
    public class School // Class library is to be consumed by another application
    {

        public string Name { get; set; }
        public string Address { get; set; }//auto properties

        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress; //can only be seen inside of this class

        public string TwitterAddress//Public Access Modifier can be seen outside of this class
        {
            get { return _twitterAddress; }// this property exposes the value by manipulation
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;/// 
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()//constructors don't have return types
        ///constructors used to handle intialisation
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;///as many contructors as you need as long
                                            /// as the method signature is different for each one


        }
        //public float AverageThreeScores(float a, float b, float c)//Method Name
        //    //retrun type which is 'int'
        //    //arguments in the Parantheses
        //    //these arguments become variables which can be used in the function body
        //    //if function doesn't return antyhing chnage return type to void
        //{
        //    var result = (a + b + c) / 3;
        //    return result;/// this will exit the method and return the result
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;//function bodied method
        //limited to very simple returns
        public static int AvaerageThreeScores(int a, int b, int c)//two methods are overloading each other 
                                                                  //Polymorphism
        {
            var result = (a + b + c) / 3;
            return result;
        }
            


            public override string ToString()//overriding string
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(this.Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
           
            return sb.ToString();
            
        }
    }
} 