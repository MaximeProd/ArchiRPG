namespace ArchiRPG.Helper
{
  public class RandomLibrary
  {
    

    public int getPourcentage(int pourcentageMax)
    {
      var random = new Random();
      return random.Next(1, pourcentageMax + 1);
    }

    public int getDesDouze()
    {
      var random = new Random();
      return random.Next(1, 13);      
    }

    public static object getPourcentages(params (object obj, int percent)[] pourcent)
    {
      var randomNum = new System.Random().Next(0,pourcent.Select(x=>x.percent).Sum());

      var lastNum = 0;
      foreach (var item in pourcent)
      {
        var num = lastNum + item.percent;
        if(lastNum >= randomNum && num < randomNum){
          return item.obj;
        }else{
          randomNum = num;
        }
      }
      return null;
    }
  }
}
