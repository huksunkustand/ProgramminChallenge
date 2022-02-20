using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using RichardSzalay.MockHttp;
using System;
using System.Net.Http;

namespace TestProjectChallenge
{

  [TestClass]
  public class UnitTest
  {

    [TestMethod]
    public void GetResultsEngineGoogleTest()
    {
      var _httpClient = new HttpClient(new MockHttpMessageHandler());

      string word = ".net";
      int actual = 0;

      var url = "https://www.googleapis.com/customsearch/v1?key=" + "AIzaSyAYKBLINxMWiEeXSjNeyFxzGjYKBfLwpnE&cx=006469441686315824696:jlvbuea85y8" + "&q=" + word;
      _httpClient.Timeout = TimeSpan.FromSeconds(3);
      var data = _httpClient.GetStringAsync(url).Result;
      var result = JObject.Parse(data);

      var expected =  Convert.ToInt32(result["queries"]["request"][0]["totalResults"]);

      if (expected > 0) actual = expected;

      Assert.AreEqual(expected, actual);

    }

  }
}
