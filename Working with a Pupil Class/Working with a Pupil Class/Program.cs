using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_a_Pupil_Class
{

    public class Pupil
    {
        //1. define the fields - private by default
        //These fields are an example of encapsulation.
        //They are hidden from the end-user by the programmer
        //This is achieved by making the fields private - default
        string _firstName = null;
        string _surname = null;
        string _formClass = null;
        int _christmasExamMark = 0;
        string _christmasGrade = null;
        bool _rightHanded = true;
        double _heightInMetres = 0.00;
        double _weightInKg = 0.00;

        
        //2. define the class constructor
        //This is an example of Polymorphism - there are many ways to implement
        //the pupil class constructor - the only difference is the parameters
        //that are required for the overloaded class constructor.
        public Pupil()
        {            
        }//End Constructor
        
        
        //2b. Overload the constructor
        public Pupil(string firstName, string surname, string formClass, int christmasExamMark, string christmasGrade)
        {
            //Change data in underlying fields

            //Accept without validation - not good practice

            //field     //supplied parameter
            _firstName = firstName;

            _surname = surname;

            _formClass = formClass;

            _christmasExamMark = christmasExamMark;

            _christmasGrade = christmasGrade;
        }//End Constructor
        

        //2b. Overload the constructor again - third form of overloaded constructor
        public Pupil(string firstName, string surname)
        {
            //field     //supplied parameter
            _firstName = firstName;
            _surname = surname;

        }//End Constructor


        public Pupil(string firstName, string surname, string formClass, int christmasExamMark)
        {
            //Assign 
            _firstName = firstName;

            _surname = surname;

            _formClass = formClass;

            _christmasExamMark = christmasExamMark;
        }//End Pupil Constructor
        

        //3. Properties
        public string FirstName
        {
            //property accessors  - get will return the field
            get { return _firstName; }

            //Set will set a value
            set { _firstName = value; }

        }//End FirstName
        

        public string Surname
        {
            //property accessors  - get will return the field
            get { return _surname; }

            //Set will set a value
            set { _surname = value; }

        }//End surname
        

        public string FormClass
        {
            //property accessors  - get will return the field
            get { return _formClass; }

            //Set will set a value
            set { _formClass = value; }

        }//End FormClass

        
        public int ChristmasExamMark
        {
            //property accessors  - get will return the field
            get { return _christmasExamMark; }

            //Set will set a value
            set { _christmasExamMark = value; }

        }//End ChristmasExamMark
        

        public string ChristmasGrade
        {
            //property accessors  - get will return the field
            get { return _christmasGrade; }

            //Set will set a value
            set { _christmasGrade = value; }

        }//End ChristmasGrade


        public bool RightHanded
        {
            //property accessors  - get will return the field
            get { return _rightHanded; }

            //Set will set a value
            set { _rightHanded = value; }

        }//End RightHanded


        public double HeightInMetres
        {
            //property accessors  - get will return the field
            get { return _heightInMetres; }

            //Set will set a value
            set { _heightInMetres = value; }

        }//End HeightInMetres


        public double WeightInKg
        {
            //property accessors  - get will return the field
            get { return _weightInKg; }

            //Set will set a value
            set { _weightInKg = value; }

        }//End WeightInKg


        //4. Class Methods
        //Method prints full name
        public void PrintFullName()
        {
            Console.WriteLine("Full Name: " + _firstName + " " + _surname);

        }//End PrintFullName


        public string GetPupilGrade(int examScore)
        {
            string pupilGrade = null;

            //Check and assign to object the grade earned as a result of their mark
            if (examScore > 80)
            {
                pupilGrade = "A";
            }
            else if (examScore > 70)
            {
                pupilGrade = "B";
            }
            else if (examScore > 60)
            {
                pupilGrade = "C";
            }
            else if (examScore > 50)
            {
                pupilGrade = "D";
            }
            else if (examScore > 40)
            {
                pupilGrade = "E";
            }
            else
            {
                pupilGrade = "U";
            }//End mark to grade if
            
            return pupilGrade;

        }//End GetPupilGrade
        
    }//End Class Pupil
    


    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string surname;
            string formClass;
            int christmasExamMark;
            string christmasGrade;


            //declaring new object - instantiating the object (creates an instance of the object) using default constructor
            Pupil pupilA = new Pupil();

            //Pupil B details
            firstName = "Tom";
            surname = "Jones";
            formClass = "4D";
            christmasExamMark = 10;
            christmasGrade = "U";

            //Using overloaded method
            Pupil pupilB = new Pupil(firstName, surname, formClass, christmasExamMark, christmasGrade);     //Separate Object

            //Pupil C details
            firstName = "Sarah";
            surname = "Jones";
            formClass = "4D";
            christmasExamMark = 10;
            christmasGrade = pupilA.GetPupilGrade(christmasExamMark);
            
            Pupil pupilC = new Pupil(firstName, surname, formClass, christmasExamMark);

            pupilC.ChristmasGrade = pupilC.GetPupilGrade(pupilC.ChristmasExamMark);

            //Pause
            Console.ReadKey();

        }//End Main

    }//End Program class

}//End Namespace
