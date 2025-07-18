using libary.Books;

namespace libary.Members
{
    public class Member
    {
        public int ID;
        public string Name;
        public string Job;
        public List<Book> BorrowedBooks;

        public Member(int ID, string Name, string Job)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.BorrowedBooks = new List<Book>();
        }


    }
}