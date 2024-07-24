using System.ComponentModel.Design;

namespace InterfaceExercise;
/* Done  Create 4 members that Car, Truck, & SUV all have in common.
 * Done  Example: public int NumberOfWheels { get; set; }*/
public interface IVehicle
{
 public string MakeAndModel { get; set; }
 public string TireSize { get; set; }
 public string Engine { get; set; }
 public bool IsFast { get; set; }

 public void TopSpeed();
 public void DisplayDetails();
}