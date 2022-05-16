namespace QuaHD.Mvc.Areas.Admin.Models
{
    public class Model : Model<int>
    {
    }

    public class Model<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
