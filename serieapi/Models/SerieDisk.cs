namespace serieapi.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class SerieDisk
	{
		#region Constantes
		#endregion

		#region Variables privées
		#endregion

		#region Propriétés publiques
		/// <summary>
		/// 
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Nom { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int DisqueNum { get; set; }
		#endregion

		#region Constructeurs
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		public SerieDisk(jf_sp_search_serie_by_nameResult r)
		{
			Id = r.serie_id;
			Nom = r.serie_nom;
			DisqueNum = r.disque_id;
		}
		#endregion

		#region Méthodes privées
		#endregion

		#region Méthodes publiques
		#endregion

		#region Méthodes statiques
		#endregion

		#region Méthodes surclassées
		#endregion
	}
}
