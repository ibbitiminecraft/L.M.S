using libary.Books;
using libary.Members;

namespace libary.classes
{
    public class Libary
    {
        public string Name;
        public List<Book> BookList;

        public List<Member> MemberList;


        public Libary(string name)
        {

            this.Name = Name;

            this.BookList = new List<Book>();
            this.MemberList = new List<Member>();
        }
    }
}
    