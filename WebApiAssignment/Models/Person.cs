namespace WebApiAssignment.Models
{
    public class Person
    {
        //? allow null
        //! not allow null
        public string ? lastName {  get; set; }
        public string ? firstName { get; set; }
        public int age { get; set; }
        public string ? gender { get; set; }

        public string toString()
        {
            return string.Format("firstName: {0}, lastName: {1}, age: {2}, gender: {3}",firstName,lastName,age,gender);
        }

    }
}
