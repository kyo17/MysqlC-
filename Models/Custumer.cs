namespace MysqlC_.Models
{
    public class Custumer
    {
        public Custumer()
        {
            idCustumer = Guid.NewGuid().ToString();
        }
    [Key]
    public string idCustumer { get; set; }
    [MaxLength(45)]
    public string name { get; set; }
    public int phone { get; set; }
    public int zip { get; set; }   
    }
}