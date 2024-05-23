using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShortListOfHospitalManagement.Repository
{
    public static class EnumExtensions
    {
        public static SelectList ToSelectList<TEnum>(this TEnum enumObj) where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum));
            var items = new List<SelectListItem>();

            foreach (var value in values)
            {
                items.Add(new SelectListItem
                {
                    Text = Enum.GetName(typeof(TEnum), value),
                    Value = ((int)value).ToString()
                });
            }

            return new SelectList(items, "Value", "Text");
        }
    }
}
