using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serieapi.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class SearchSerie
	{
		#region Constantes
		#endregion

		#region Variables privées
		#endregion

		#region Propriétés publiques
		/// <summary>
		/// 
		/// </summary>
		public List<SerieDisk> Series { get; set; }
		#endregion

		#region Constructeurs
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		public SearchSerie(string text)
		{
			Init(text);
		}
		#endregion

		#region Méthodes privées
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		private void Init(string text)
		{
			var tts = text.Replace("_", "%");
			using (var db = new SerieTvDataContext())
			{
				Series = db.jf_sp_search_serie_by_name(tts).Select(o => new SerieDisk(o)).ToList();
			}
		}
		#endregion

		#region Méthodes publiques
		#endregion

		#region Méthodes statiques
		#endregion

		#region Méthodes surclassées
		#endregion
	}
}
