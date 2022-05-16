namespace QuaHD.Mvc.Areas.Admin.Models.Products
{
    public class ProductSearchModel : SearchModel
    {
        public int? ProductTypeId { get; set; }

        public bool? CourseLink { get; set; }

        public int? CourseId { get; set; }

        public bool? IsPublished { get; set; }
    }
}
