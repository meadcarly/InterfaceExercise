using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done  Create 2 Interfaces called IVehicle & ICompany

            //Done  Create 3 classes called Car , Truck , & SUV

            //Done  In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //Done  In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //Done  In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Done  Now, create objects of your 3 classes and give their members values.
            
            var mercedes = new Car();
            mercedes.MakeAndModel = "Mercedes Benz";
            mercedes.HasTrunk = true; 
            mercedes.StreetTires = true;
            mercedes.TireSize = "Small";
            mercedes.Engine = "C300";
            mercedes.IsFast = true;
            mercedes.YearCompanyStarted = 1926;
            mercedes.Dealership = "International from Germany";
            
            
            var telluride = new Suv();
            telluride.MakeAndModel = "Kia Telluride";
            telluride.Size = "large";
            telluride.HasManySeats = true;
            telluride.TireSize = "Large";
            telluride.Engine = "3.8 liter V-6";
            telluride.IsFast = true;
            telluride.YearCompanyStarted = 1944;
            telluride.Dealership = "International from Korea";
            
            var tacoma = new Truck();
            tacoma.MakeAndModel = "Toyota Tacoma";
            tacoma.DriveTrain = "4-Wheel drive";
            tacoma.HasTruckBed = true;
            tacoma.TireSize = "Large";
            tacoma.Engine = "2.4 liter 4-cylinder";
            tacoma.IsFast = true;
            tacoma.YearCompanyStarted = 1937;
            tacoma.Dealership = "International from Japan";
            
            //Done  Creatively display and organize their values
            mercedes.DisplayDetails();
            mercedes.TopSpeed();
            Console.WriteLine();

            telluride.DisplayDetails();
            telluride.TopSpeed();
            Console.WriteLine();

            tacoma.DisplayDetails();
            tacoma.TopSpeed();

            
            


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
