using System.Configuration;

namespace Model
{
    partial class ContentDataContext
    {
        public ContentDataContext()
            : this(ConfigurationManager.ConnectionStrings["ContentConnectionString"].ConnectionString)
        { 
        }
    }
}
