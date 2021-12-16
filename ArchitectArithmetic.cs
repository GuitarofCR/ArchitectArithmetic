using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
    }

    static double RectangleArea(double length, double width)
    {
      double recArea = length * width;
      return recArea; 
      
    }

    static double CircleArea(double radius)
    {
      double circleArea;
      return circleArea = Math.PI * Math.Pow(radius, 2);
    }

    static double TriangleArea(double bottom, double height)
    {
      double triArea = 0.5 * bottom * height;
      return triArea;
    }

    static void CalculateTotalCost()
    {
      Console.WriteLine("What monument would you like to work with?");
      string monument = Console.ReadLine();
      monument = monument.ToLower();

      if (monument == "teotihuacan")
      {        
      double teoTriArea = TriangleArea(750, 500);
      double teoRecArea = RectangleArea(2500, 1500);
      double teoCircleArea = CircleArea(375) / 2;
      double teoAreaEstimate = teoTriArea + teoRecArea + teoCircleArea;
      double costEstimate = teoAreaEstimate * 180;
      costEstimate = Math.Round(costEstimate, 2);
      Console.WriteLine($"The plan for the flooring of the {monument} costs {costEstimate} pesos!");
      
      } else if (monument == "taj mahal") {
        double tajTriArea = TriangleArea(25, 25);
        double tajSquareArea = RectangleArea(90.5, 90.5);
        double tajTotalArea = tajSquareArea - (tajTriArea * 4);
        double costEstimateTaj = tajTotalArea * 180;
        costEstimateTaj = Math.Round(costEstimateTaj, 2);  
        Console.WriteLine($"The plan for the flooring of the {monument} costs {costEstimateTaj} pesos!");
      } else if (monument == "great mosque of mecca") {
        double mosqueRec1 = RectangleArea(180, 106);
        double mosqueRec2 = RectangleArea(284, 264);
        double mosqueTri = TriangleArea(264, 84);
        double mosqueAreaTotal = mosqueRec1 + mosqueRec2 - mosqueTri;
        double costEstimateMecca = mosqueAreaTotal * 180;
        costEstimateMecca = Math.Round(costEstimateMecca, 2);
        Console.WriteLine($"The plan for the flooring of the {monument} costs {costEstimateMecca} pesos!");
      } else {
        Console.WriteLine("Sorry we don't have that moument in our catalogue, we currently have the 'Teotihuacan', the 'Great Mosque of Mecca' and the 'Taj Mahal' in our catalogue, try one of these.");
      }
    }
  }
}