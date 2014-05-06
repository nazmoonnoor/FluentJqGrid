namespace FluentJqGrid.Extensions
{
    public class Utils
    {
        public static void CopyPropertyValues(object source, object destination)
        {
            if (destination == null) return;
            var destProperties =
                destination.GetType().GetProperties(System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance |
                                                    System.Reflection.BindingFlags.NonPublic);

            foreach (var sourceProperty in source.GetType().GetProperties())
            {
                foreach (var destProperty in destProperties)
                {
                    if (destProperty.Name == sourceProperty.Name &&
                destProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
                    {
                        object value = sourceProperty.GetValue(source, new object[] { });
                        if(value!=null)
                            destProperty.SetValue(destination, value, new object[] {});

                        break;
                    }
                }
            }
        }
    }
}
