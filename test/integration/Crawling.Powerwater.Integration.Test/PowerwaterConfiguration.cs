using System.Collections.Generic;
using CluedIn.Crawling.Powerwater.Core;

namespace CluedIn.Crawling.Powerwater.Integration.Test
{
  public static class PowerwaterConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { PowerwaterConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
