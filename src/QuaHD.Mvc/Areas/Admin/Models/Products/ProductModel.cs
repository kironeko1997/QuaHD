namespace QuaHD.Mvc.Areas.Admin.Models.Products
{
    public class ProductModel : Model
    {
        public string? Name { get; set; }

        public string? Code { get; set; }

        public decimal Price { get; set; }

        public int ProductTypeId { get; set; }

        public int? CourseId { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }
    }
}
