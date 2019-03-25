using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Sugar.Enties
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("countrylanguage")]
    public partial class countrylanguage
    {
        public countrylanguage()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public string Language { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0.0
        /// Nullable:False
        /// </summary>           
        public float Percentage { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:F
        /// Nullable:False
        /// </summary>           
        public string IsOfficial { get; set; }

    }
}
