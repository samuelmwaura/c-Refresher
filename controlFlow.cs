namespace fundamentals
{
  public class ControlFlow
  {
    public void controlFlow()
    {
        //CONTROL FLOWS
        bool promoEligible = false;
        var currentSeason = seasonsOfTheYear.summer;// can just use var instead of casting

        if(promoEligible){
            Console.WriteLine("customer Qualifies");
        }
        else
        {
            Console.WriteLine("Unfortunately you have not hit the threshhold.");
        }

        switch(currentSeason)
        {
            case seasonsOfTheYear.summer:
              Console.WriteLine("This would be the best time to stay in your home country.");
              break;

            case seasonsOfTheYear.winter:
               Console.WriteLine("Please find a tropical country.");
              break;

            default:
              Console.WriteLine("you can choose home or away");
              break;
        }

    }

  }
}