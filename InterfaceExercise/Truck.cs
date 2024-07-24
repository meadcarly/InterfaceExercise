using System;

namespace InterfaceExercise;
/* Done  Create 2 members that are specific to each class
 *       Example for Car: public bool HasTrunk { get; set; }
 *       Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Done  Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */
public class Truck : IVehicle, ICompany
{
    public bool HasTruckBed { get; set; }
    public string DriveTrain { get; set; }
    
    public string MakeAndModel { get; set; }
    public string TireSize { get; set; }
    public string Engine { get; set; }
    public bool IsFast { get; set; }
    public void TopSpeed()
    {
        Console.WriteLine("A truck can be moderately fast, but is more well known for strength and power.");
    }

    public void DisplayDetails()
    {
//In the scope of them method, use string interpolation to display property values.
        Console.WriteLine($"The {MakeAndModel} comes with a {DriveTrain} and it's {HasTruckBed}, the truck bed is spacious! Here are some other details about it:\nTire size: {TireSize}\nEngine: {Engine}\nIs it fast? {IsFast}.\nThe {MakeAndModel} is {Dealership}, from a company started in {YearCompanyStarted}.");    
    }

    public int YearCompanyStarted { get; set; }
    public string Dealership { get; set; }
}