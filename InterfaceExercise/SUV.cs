using System;

namespace InterfaceExercise;
/* Done  Create 2 members that are specific to each class
 *       Example for Car: public bool HasTrunk { get; set; }
 *       Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Done  Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */
public class Suv : IVehicle, ICompany
{
 public string Size { get; set; }
 public bool HasManySeats { get; set; }
 
 public string MakeAndModel { get; set; }
 public string TireSize { get; set; }
 public string Engine { get; set; }
 public bool IsFast { get; set; }
 public void TopSpeed()
 {
  Console.WriteLine("SUVs are slower in speed, but still capable of moderate speeds. They do have less manoeuvrability at higher speeds.");
 }

 public void DisplayDetails()
 {
  //In the scope of them method, use string interpolation to display property values.
  Console.WriteLine($"The {MakeAndModel} is {Size} and it's {HasManySeats} it has many seats. Here are some other details about it:\nTire size: {TireSize}\nEngine: {Engine}\nIs it fast? {IsFast}.\nThe {MakeAndModel} is {Dealership}, from a company started in {YearCompanyStarted}.");
 }

 public int YearCompanyStarted { get; set; }
 public string Dealership { get; set; }
}