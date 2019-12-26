namespace Abp.Northwind.ApplicationServices.Categories.Dtos
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}