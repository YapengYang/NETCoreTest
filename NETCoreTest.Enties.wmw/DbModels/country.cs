using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NETCoreTest.Enties.wmw
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("country")]
    public partial class country
    {
        public country()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Code2 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LocalName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:Asia
        /// Nullable:False
        /// </summary>           
        public string Continent { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public float? GNP { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public int Population { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public float? GNPOld { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Region { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string GovernmentForm { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0.00
        /// Nullable:False
        /// </summary>           
        public float SurfaceArea { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string HeadOfState { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? Capital { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public short? IndepYear { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public string Code { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public float? LifeExpectancy { get; set; }

    }
}
