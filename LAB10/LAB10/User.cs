namespace LAB10
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID={UserID} Name={Name} Age={Age}";
        }
    }
}