using System.ComponentModel.DataAnnotations;

namespace NETCore.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class language
    {
        /// <summary>
        /// 
        /// </summary>
        public language()
        {
        }

        
        private System.Byte _language_id;

        /// <summary>
        /// 每个表对应的实体必须指定主键属性
        /// </summary>
        [Key]
        [Required]
        public System.Byte language_id { get { return this._language_id; } set { this._language_id = value; } }

        private System.String _name;
        /// <summary>
        /// 
        /// </summary>
        public System.String name { get { return this._name; } set { this._name = value; } }

        private System.DateTime _last_update;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime last_update { get { return this._last_update; } set { this._last_update = value; } }
    }

}