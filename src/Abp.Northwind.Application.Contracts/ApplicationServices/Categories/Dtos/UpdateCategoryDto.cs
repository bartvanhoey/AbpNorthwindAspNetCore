namespace Abp.Northwind.ApplicationServices.Categories.Dtos
{
    public class UpdateCategoryDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}