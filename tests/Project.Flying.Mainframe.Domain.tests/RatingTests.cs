using Project.Flying.Mainframe.Domain;
using Project.Flying.Mainframe.Domain.Catalog;
namespace Project.Flying.Mainframe.Domain.Tests;

[TestClass]
public class RatingTests{


    [TestMethod]
    public void Can_Create_New_Rating(){
        //arrange 
        var rating = new Rating(1, "Mike", "Great fit!");
        
        //act (empty)

        //assert 

        Assert.AreEqual(1, rating.Stars); 
        Assert.AreEqual("Mike", rating.UserName); 
        Assert.AreEqual("Great fit!", rating.Review);

    }

    [TestMethod] 
    [ExpectedException(typeof(ArgumentException))] 
    public void Cannot_Create_Rating_With_Invalid_Stars() {
        //arrange
        var rating = new Rating(0, "Mike", "Great fit!"); 
    }
}
