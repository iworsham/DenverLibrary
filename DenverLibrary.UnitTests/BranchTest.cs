namespace DenverLibrary.UnitTests
{
    public class BranchTest
    {
        [Fact]
        public void CreatedWithSetPropertyValues()
        {
            Branch branch1 = new Branch("Ross");
            Assert.Equal("Ross", branch1.Name);
            Assert.Equal(new List<Book>(), branch1.Books);
        }
        [Fact]
        public void CreatedWithSetMethodsValues()
        {
            Branch branch1 = new Branch("Ross");
            Book book1 = new Book("Magnus Chase", "Rick Riordan");
            branch1.AddBook(book1);
            Assert.Equal(book1 , branch1.Books[0]);
        }
        [Fact]
        public void OurListOfAuthors_HasCorrectAuthors()
        {
            Book book1 = new Book("Magnus Chase", "Rick Riordan");
            Branch branch1 = new Branch("Ross");
            branch1.AllAuthors();
            branch1.AddBook(book1);
            Assert.Equal(new List<string> {book1.Author},branch1.AllAuthors());


        }
    }
}
