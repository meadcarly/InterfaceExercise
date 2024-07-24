namespace InterfaceExercise;
/* Done  Create 2 members that are specific to each every company
 *       regardless of vehicle type.
 *       Example: public string Logo { get; set; }
 */
public interface ICompany
{
 public int YearCompanyStarted { get; set; }
 public string Dealership { get; set; }
}